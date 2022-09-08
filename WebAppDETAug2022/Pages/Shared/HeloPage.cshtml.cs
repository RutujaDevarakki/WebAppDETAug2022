using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Pages.Shared
{
    public class HeloPageModel : PageModel
    {
        public IHelo ob { get; set; }



        public string Message { get; set; }
        public HeloPageModel(IHelo i)
        {
            ob = i;



        }
        public void OnGet()
        {
            Message = ob.SayHello("Dhanush");
        }
    }
}
