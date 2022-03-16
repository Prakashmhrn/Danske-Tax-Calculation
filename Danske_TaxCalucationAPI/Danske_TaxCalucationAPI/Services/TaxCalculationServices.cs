using Danske_TaxCalucationAPI.Interfaces;
using Danske_TaxCalucationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Danske_TaxCalucationAPI.Services
{
    public class TaxCalculationServices : ITax_Calculation
    {
        private readonly Context _context;

        public TaxCalculationServices(Context context)
        {
            _context = context;
        }
        public List<CommonModel> getCalculatedTax(DateTime date)
        {
            return  _context.CommonModel.FromSqlRaw("EXECUTE dbo.Tax_Calculation {0}", date).ToList();
        }

        public int UpdateTaxRule(PeriodDetailsDTO obj)
        {
            int result = 0;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@PeriodId", obj.PeriodId));
                parameters.Add(new SqlParameter("@PeriodType", obj.PeriodType));
                parameters.Add(new SqlParameter("@StartDate", obj.StartDate.ToString("yyyy-MM-dd")));
                parameters.Add(new SqlParameter("@EndDate", obj.EndDate.ToString("yyyy-MM-dd")));
                parameters.Add(new SqlParameter("@Value", obj.Value));
                parameters.Add(new SqlParameter("@RuleID", obj.RuleID));

                var res = _context.PeriodDetailsDTO.FromSqlRaw("EXECUTE dbo.UpdateTaxRuleSet {0}", parameters).ToListAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return result;
        }
    }
}
