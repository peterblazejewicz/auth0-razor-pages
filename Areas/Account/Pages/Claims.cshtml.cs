using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleMvcApp.Areas.Account.Pages
{
    /// <summary>
    /// This is just a helper action to enable you to easily see all claims related to a user. It helps when debugging your
    /// application to see the in claims populated from the Auth0 ID Token
    /// </summary
    [Authorize]
    public class ClaimsModel : PageModel
    {
        [ViewData]
        public string Title { get; set; } = "Claims page";

        public void OnGet()
        {
        }
    }
}
