using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Answer2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckController : ControllerBase
    {
        [HttpPost("check")]
        public IActionResult CheckHesCodes([FromBody] List<HesCode> hesCodes) // The reason for using frombody is to be able to use the data in the body of the http request as an hes object.
        {
            if (hesCodes == null || hesCodes.Count == 0) //checking if the codes are null
            {
                return BadRequest("HES codes are required.");
            }

            List<HesResult> results = new List<HesResult>();

            foreach (var item in hesCodes) // According to the information given, we describe the risky or riskless informations.
            {
                string status = "";

                if (item.Hes == "G1B5-6449-15")
                {
                    status = "risky";
                }
                else if (item.Hes == "G5B2-3442-88")
                {
                    status = "riskless";
                }

                results.Add(new HesResult { Hes = item.Hes, Status = status }); // Then we add new datas to our model.
            }

            // We get the result by comparing the data entered with the data we have.
            var riskyCodes = results.Where(r => r.Status == "risky").ToList();
            var risklessCodes = results.Where(r => r.Status == "riskless").ToList();

            return Ok(new { RiskyCodes = riskyCodes, RisklessCodes = risklessCodes });

        }
    }
}
