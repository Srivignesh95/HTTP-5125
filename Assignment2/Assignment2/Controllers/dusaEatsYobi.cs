using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class dusaEatsYobi : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request and calculates Dusa's size after encountering a series of Yobis.
        /// Dusa can only eat Yobis that are smaller than its current size, absorbing their sizes to grow. 
        /// The process continues until Dusa encounters a Yobi that is the same size or larger, at which point it stops.
        /// </summary>
        /// <param name="dusaSize">The initial size of Dusa before encountering any Yobis.</param>
        /// <param name="yobiSize">A list of integers representing the sizes of Yobis encountered in order.</param>
        /// <returns>Returns an integer representing Dusa's final size after encountering the Yobis.</returns>
        /// <example>
        /// POST https://localhost:7191/api/dusaEatsYobi/dusaYobi?dusaSize=x&yobiSize=x&yobiSize=x ---> xx
        /// </example>
        [HttpPost(template: "dusaYobi")]
        public int dusaYobi([FromForm] int dusaSize, [FromForm] List<int> yobiSize) {
            int currentDusaSize = dusaSize;
            foreach (int yobiSizes in yobiSize)
            {
                if (yobiSizes < currentDusaSize)
                {
                   currentDusaSize += yobiSizes;
                }
                else
                {
                   break;
                }
            }
            return currentDusaSize;

        }
    }
}
