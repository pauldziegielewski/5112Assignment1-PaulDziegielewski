using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5112Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This method is a calculation that will output a sum depending on what number is inputed
        /// </summary>
        /// <example>Get api/NumberMachine/{id}</example>
        /// <param name="id">10, -5, 30</param>
        /// <returns>260, 230, 300</returns>
        public int Get(int id)
        {
            return (2 * id) + (10 + 40) / (2 * 2) * (100 - 80);
        }

    }
}
