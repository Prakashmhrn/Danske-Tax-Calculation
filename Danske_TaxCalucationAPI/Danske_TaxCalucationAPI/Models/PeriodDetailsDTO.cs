using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Danske_TaxCalucationAPI.Models
{
    public class PeriodDetailsDTO
    {
        [Key]
        public int PeriodId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string PeriodType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Value { get; set; }
        public int RuleID { get; set; }
    }
}
