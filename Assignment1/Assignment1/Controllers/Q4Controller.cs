using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP post request with an empty body and returns the start of a knock knock joke 
        /// </summary>
        /// <returns> An HTTP response with the start of a knock knock joke</returns>
        /// <example>
        /// POST https://localhost:xxx/api/Q4/knockknock ---> Who's there?
        /// </example>
        [HttpPost(template: "knockknock")]
        public string knockknock()
        {
            return "Who’s there?";
        }
    }
}
