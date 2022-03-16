using Danske_TaxCalucationAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Danske_TaxCalucationAPI.Interfaces
{
    public interface ITax_Calculation
    {
        List<CommonModel> getCalculatedTax(DateTime date);
        int UpdateTaxRule(PeriodDetailsDTO obj);
    }
}
