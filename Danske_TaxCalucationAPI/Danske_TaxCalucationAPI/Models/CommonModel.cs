using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Danske_TaxCalucationAPI.Models
{
    public class CommonModel
    {
        //[Key]
        //public int MunicipalityID { get; set; }
        public string MunicipalityName { get; set; }
        public DateTime Date { get; set; }
        public string RuleType { get; set; }
        public decimal Result { get; set; }
    }
}
