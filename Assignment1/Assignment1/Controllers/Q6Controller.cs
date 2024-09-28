using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q6Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP get request and returns the area of a regular hexagon 
        /// </summary>
        /// <param name="side"> The value that has to be applied in the formula </param>
        /// <returns> An HTTP response with the area of a regular hexagon</returns>
        /// <example>
        /// GET https://localhost:xxx/api/Q6/hexagon?side=2 ---> 10.392304845413264
        /// </example>
        [HttpGet(template: "hexagon")]
        public double hexagon(double side)
        {
            double cal = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return cal;
        }
    }
}
