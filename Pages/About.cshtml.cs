using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MySimpleWebPageApp.Pages
{
    public class AboutModel : PageModel
    {
        public void OnGet()
        {
            ViewData["BuildNumber"] = Environment.GetEnvironmentVariable("BUILD_BUILDNUMBER") ?? "Local Development";
        }
    }
}

