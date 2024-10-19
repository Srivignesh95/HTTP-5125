using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChiliPeppers : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP get request, calculates the spiciness according to the input, and returns the sum of all.
        /// </summary>
        /// <param name="ingredients">The ingredients (comma-separated string) which need to be calculated</param>
        /// <returns>An HTTP response containing the sum of all the ingredients' SHU values</returns>
        /// <example>
        /// GET https://localhost:7191/api/ChiliPeppers/spiceLevel?ingredients=xxx ---> The total SHU is: xxx !
        /// </example>
        [HttpGet(template: "spiceLevel")]
        public string spiceLevel([FromQuery] string ingredients)
        {

            if (string.IsNullOrEmpty(ingredients))
            {
                return "Error: Ingredients are required.";
            }

            var spices = ingredients.Split(',');
            int totalSpices = 0;

            foreach (var pepper in spices)
            {
                switch (pepper.Trim().ToLower())
                {
                    case "poblano":
                        totalSpices += 1500;
                        break;
                    case "mirasol":
                        totalSpices += 6000;
                        break;
                    case "serrano":
                        totalSpices += 15500;
                        break;
                    case "cayenne":
                        totalSpices += 40000;
                        break;
                    case "thai":
                        totalSpices += 75000;
                        break;
                    case "habanero":
                        totalSpices += 125000;
                        break;
                    default:
                        return "Invalid pepper type: " + pepper;
                }
            }
            //https://learn.microsoft.com/en-us/dotnet/csharp/how-to/concatenate-multiple-strings
            return $"The total SHU is: {totalSpices}";
        }
    }
}
