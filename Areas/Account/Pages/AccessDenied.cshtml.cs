using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleMvcApp.Areas.Account.Pages
{
    public class AccessDeniedModel : PageModel
    {
        [ViewData]
        public string Title { get; set; } = "Access denied";

        public void OnGet()
        {
        }
    }
}
