using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace SampleMvcApp.Areas.Account.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        [ViewData]
        public string Title { get; set; } = "User Profile";
        [ViewData]
        public string? EmailAddress { get; set; }
        [ViewData]
        public string? Name { get; set; }
        [ViewData]
        public string? ProfileImage { get; set; }

        public void OnGet()
        {
            Name = User.Identity!.Name;
            EmailAddress = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            ProfileImage = User.Claims.FirstOrDefault(c => c.Type == "picture")?.Value;
        }

    }
}
