using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Danske_TaxCalucationAPI.Models
{
    public class MunicipalityDTO
    {
        [Key]
        public int MunicipalityID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string MunicipalityName { get; set; }
        public int RuleID { get; set; }
    }
}
