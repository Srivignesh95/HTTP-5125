using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Numerics;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q8Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP post request with a multi-part form data with 2 parameters (small plushie count and large plushie count) and returns the checkout summary of the order including taxes 
        /// </summary>
        /// <returns> An HTTP response with the checkout summary of the order</returns>
        /// <example>
        /// POST https://localhost:xxx/api/Q8/squashfellows
        /// HEADER: Content-Type: multipart/form-data
        /// FORM DATA: 'small=1' \ 'large=2' ---> 1 Small @ $25.5 = $25.5; 2 Large @ $45.5 = 91; Subtotal = 116.5; Tax = 15.15 HST; Total = $131.65
        /// </example>
        [HttpPost (template: "squashfellows")]
        public string squashfellows([FromForm] int small, [FromForm] int large)
        {
            double small_price = 25.50;
            double large_price = 45.50;
            double tax = 0.13;
            double total_amount = (small_price * small) + (large_price * large);
            double total_tax = Math.Round(total_amount * tax, 2);
            double total_with_tax = Math.Round(total_amount + total_tax, 2);
            return small + " Small @ $" + small_price + " = $" + (small_price * small) + "; "
                + large + " Large @ $" + large_price + " = " + (large_price * large) + "; "
                + "Subtotal = " + total_amount + "; Tax = " + total_tax + " HST;"
                + " Total = $" + total_with_tax;

        }
    }
}
