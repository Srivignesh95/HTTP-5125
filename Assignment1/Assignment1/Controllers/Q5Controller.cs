using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP post request with a body and returns the acknowledgement of a secret number (integer) 
        /// </summary>
        /// <returns> An HTTP response with the acknowledgement of a secret number</returns>
        /// <example>
        /// POST https://localhost:xxx/api/Q5/secret
        /// HEADER: Content-Type: application/json
        /// FORM DATA: "val (5)" ---> Shh.. the secret is 5
        /// </example>
        [HttpPost(template: "secret")]
        public string secret([FromBody] int val) {
            return "Shh.. the secret is " + val;
        }
    }
}
