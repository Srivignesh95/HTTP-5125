using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class cupCake : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request and calculates the remaining cupcakes after distributing them to students.
        /// </summary>
        /// <param name="regularBoxes">The number of regular boxes, where each regular box contains 8 cupcakes.</param>
        /// <param name="smallBoxes">The number of small boxes, where each small box contains 3 cupcakes.</param>
        /// <returns>Returns an integer representing the remaining number of cupcakes after distributing them to 28 students.</returns>
        /// <example>
        /// POST https://localhost:7191/api/cupCake/balanceCupcakes?regularBoxes=x&smallBoxes=x  ---> xx
        /// </example>

        [HttpPost(template: "balanceCupcakes")]
        public int balanceCupcakes([FromForm] int regularBoxes, [FromForm] int smallBoxes) {
            int totalRegularCake = regularBoxes * 8;
            int totalSmallCake = smallBoxes * 3;
            int totalCupcakes = totalRegularCake + totalSmallCake;
            int noOfstudents = 28;
            int balaceCake = totalCupcakes - noOfstudents;
            return (balaceCake);
        }
    }
}
