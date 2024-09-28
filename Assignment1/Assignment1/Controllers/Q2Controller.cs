using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP get request and returns a greeting message with name
        /// </summary>
        /// <param name="name"> The name (string) of the user to be greeted </param>
        /// <returns> An HTTP response containing a greeting message with personalized name</returns>
        /// <example>
        /// GET https://localhost:zzz/api/Q2/greeting?name=xxx ---> Hi xxx !
        /// </example>
        [HttpGet(template: "greeting")]
        public string greeting(string name) {
            return "Hi "+ name + "  !";
        }
    }
}
