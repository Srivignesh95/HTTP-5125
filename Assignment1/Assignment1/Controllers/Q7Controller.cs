using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q7Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP get request and returns the string representation of the current date adjusted by the parameter days (integer) 
        /// </summary>
        /// <param name="days"> The integer value of the number of days the string representation of the current date has to be adjusted </param>
        /// <returns> An HTTP response with the string representation of the current date adjusted by the parameter "days" (integer)</returns>
        /// <example>
        /// GET https://localhost:xxx/api/Q7/timemachine?days=2 ---> 2024-09-29
        /// </example>
        [HttpGet(template: "timemachine")]
        public string timemachine(int days) { 
            DateTime todayDate = DateTime.Today;
            DateTime AdditionDate = todayDate.AddDays(days);
            string formatted = AdditionDate.ToString("yyyy-MM-dd");
            return formatted;
        }
    }
}
