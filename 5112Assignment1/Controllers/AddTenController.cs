using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5112Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
      
        /// <summary>
        /// This method will return (input number from user + 10) => if input from user is 21 ===> 31
        /// </summary>
        /// <example>Get api/addten/21</example>
        /// <param name="id">21, 0, -9</param>
        /// <returns>31,10,1</returns>
        public int Get(int id)
        {
            return 10 + id;
        }
    }
}
