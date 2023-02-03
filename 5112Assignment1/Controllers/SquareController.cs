using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5112Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// The following method returns the square of an integer that's inputed 
        /// </summary>
        /// <param name="id">2, -2, 10</param>
        /// <returns>4,4,100</returns>
        /// <example>GET api/square/10</example>
        public int Get(int id)
        {
            return (id * id);
        }
    }
}
