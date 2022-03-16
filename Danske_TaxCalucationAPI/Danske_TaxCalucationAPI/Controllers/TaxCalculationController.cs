using Danske_TaxCalucationAPI.Interfaces;
using Danske_TaxCalucationAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Danske_TaxCalucationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxCalculationController : ControllerBase
    {
        private readonly ITax_Calculation _tax;

        public TaxCalculationController(ITax_Calculation tax)
        {
            _tax = tax;
        }
        // GET: api/<TaxCalculationController>
        [HttpGet]
        [Route("GetTaxCalculationResult")]
        public IActionResult GetTaxCalculationResult(DateTime Date)
        {
            var result = _tax.getCalculatedTax(Date);
            return Ok(result);
        }

        [HttpPost]
        [Route("UpdateTaxRule")]
        public IActionResult UpdateTaxRule(PeriodDetailsDTO obj)
        {
            var result = _tax.UpdateTaxRule(obj);
            return Ok(result);
        }
    }
    
}
