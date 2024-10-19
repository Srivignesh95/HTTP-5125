using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class bronzeCount : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request and calculates the bronze score and the number of participants who achieved it.
        /// </summary>
        /// <param name="scores">A list of integers representing the scores of all participants.</param>
        /// <returns>Returns a string indicating the bronze score and the number of participants who achieved that score.</returns>
        /// <example>
        /// POST https://localhost:7191/api/bronzeCount/bronzeWinner?scores=x&scores=xx&scores=xx&scores=xx --> Bronze score is: xx, No. of Partcipant: xx
        /// </example>
        [HttpPost("bronzeWinner")]
        public string bronzeWinner([FromForm] List<int> scores) {
            //https://www.educative.io/answers/how-to-remove-duplicates-from-a-list-in-c-sharp
            //https://stackoverflow.com/questions/3062513/how-can-i-sort-generic-list-desc-and-asc
            var distinctScores = scores.Distinct().OrderByDescending(i => i).ToList();
            int bronzeScore = distinctScores[2];
            // https://stackoverflow.com/questions/1444615/using-c-sharp-count-with-a-function
            int bronzeCount = scores.Count(i => i == bronzeScore);
            //https://learn.microsoft.com/en-us/dotnet/csharp/how-to/concatenate-multiple-strings
            return $"Bronze score is: {bronzeScore}, No. of Partcipant: {bronzeCount}";

        }
    }
}
