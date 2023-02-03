using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5112Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns the string "Hello World!"
        /// </summary>
        /// <example>POST api/Greeting</example>
        /// <param name="greeting">"Hello World!"</param>
        /// <returns>"Hello World!"</returns>

        [HttpPost]
        public string PostGreeting()
        {
            return "Hello World!";
        }

        /// <summary>
        /// This method returns the string "Greetings to {id} people!" - depending on what number is inputed
        /// </summary>
        /// <example>GET api/Greeting/{id}</example>
        /// <param name="id">3, 6, 0</param>
        /// <returns>"Greetings to 3 people!","Greetings to 6 people!", "Greetings to 0 people!"</returns>
        /// 
      
        public string GetGreeting(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}

