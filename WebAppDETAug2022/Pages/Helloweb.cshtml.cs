using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppDETAug2022.Pages
{
    public class HellowebModel : PageModel
    {
        public string Message { get; set; }
        //HTTPGET
        public int Discount { get; set; }

        public string Coupon { get; set; }
        
        public void OnGet()
        {
            Message = "ASP.Net Core is Important";
            Discount = 20;
            Coupon = "'Sonata10'";
        }
    }
}
