using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Danske_TaxCalucationAPI.Models
{
   
    public class ManageRuleDTO
    {
        [Key]
        public int RuleID { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string RuleType { get; set; }
        public int PeriodId { get; set; }
    }
}
