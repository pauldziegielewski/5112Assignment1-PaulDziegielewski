using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5112Assignment1.Controllers
{
    public class HostingCostController : ApiController

    {
        /// <summary>
        /// This method will calculate and determine 3 sums (FEE, HST, FEE + TOTAL). The sums will depend on how many days is spent maintaining a website
        /// </summary>
        /// <param name="days">1-13, 14-27, 28+</param>
        /// <returns>Based on 1 - 13 days (FEE = $5.50, HST = .72, TOTAL = $6.22)</returns>
        /// <returns>Based on 14 - 27 days (FEE = $11, HST = $1.43, TOTAL = $12.43)</returns>
        /// <returns>Based on 28 days + (FEE = $16.5, HST = $2.14, TOTAL = $18.64)</returns>
        /// <example>GET api/HostingCost/{days}</example>
        /// 
        [HttpGet]
        [Route("api/HostingCost/{days}")]
        public IEnumerable <string> GetCost(decimal days)
        {
            decimal fee = (decimal)5.50;
            decimal hst = (decimal).13;


            if (days < 14)
            {
                return new string[] { days + " fortnights at $5.50/FN = " + (fee), "HST 13% = " + Math.Round((fee * hst), 2) + " CAD", "Total = $" + Math.Round(((fee * hst) + fee),2) + " CAD" };
            }
            else if (days >= 14 && days < 28)
            {
                return new string[] { days + " fortnights at $5.50/FN = " + Math.Round((fee * 2),2), "HST 13% = " + Math.Round((fee * hst * 2),2) + " CAD", "Total = $" + Math.Round(((fee * hst * 2) + fee *2),2) + " CAD" };
            }
            else
            {
                return new string[] { days + " fortnights at $5.50/FN = " + Math.Round((fee * 3),2), "HST 13% = " + Math.Round((fee * hst * 3),2) + " CAD", "Total = $" + Math.Round(((fee * hst * 3) + fee *3),2) + " CAD" };
            }
        }
    } 
}
  

