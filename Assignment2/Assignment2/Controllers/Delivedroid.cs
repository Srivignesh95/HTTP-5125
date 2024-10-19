using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Delivedroid : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request and calculates the total score based on the number of packages delivered and the number of collisions with obstacles.
        /// If the number of deliveries exceeds the number of collisions, a bonus is applied to the score.
        /// </summary>
        /// <param name="deliveries">The number of packages delivered, where each delivery adds 50 points.</param>
        /// <param name="collisions">The number of collisions with obstacles, where each collision subtracts 10 points.</param>
        /// <returns>Returns an integer representing the total score, including a 500-point bonus if the number of deliveries is greater than the number of collisions.</returns>
        /// <example>
        /// POST https://localhost:7191/api/Delivedroid/score?collisions=x&deliveries=x --->  xxx 
        /// </example>

        [HttpPost(template: "score")]
        public int score([FromForm] int collisions, [FromForm] int deliveries) {
            int calculatedScore = (deliveries * 50) - (collisions * 10);
            if (deliveries > collisions)
            {
                calculatedScore += 500;
            }
            return calculatedScore;
        }
    }
}
