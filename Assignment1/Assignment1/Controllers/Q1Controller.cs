using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP get request and returns a welcome message
        /// </summary>
        /// <returns> An HTTP response with welcome message</returns>
        /// <example>
        /// GET http://localhost:xx/api/q1/welcome ---> Welcome to 5125!
        /// </example>
        [HttpGet(template:"welcome")]
       public string welcome(){
            return "Welcome to 5125!";
        }
    }
}
