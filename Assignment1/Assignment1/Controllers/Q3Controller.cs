using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q3Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP get request and returns the cube of an integer 
        /// </summary>
        /// <param name="qwe"> The integer value that has to be cubed </param>
        /// <returns> An HTTP response with the cube value of the integer</returns>
        /// <example>
        /// GET https://localhost:xxx/api/Q3/cube/3 ---> 27
        /// </example>
        [HttpGet(template: "cube/{qwe}")]
        public int cube(int qwe)
        {
            return (qwe * qwe* qwe);
        }
    }
}
