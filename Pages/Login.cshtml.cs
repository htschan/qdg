using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace qdg.Pages
{
   public class LoginModel : PageModel
   {
      private readonly ILogger<IndexModel> _logger;

      public LoginModel(ILogger<IndexModel> logger)
      {
         _logger = logger;
      }

      public void OnGet()
      {

      }
      public string ReturnUrl { get; set; }
      public string Username { get; set; }
      public string Password { get; set; }
      public bool RememberLogin { get; set; }
   }
}
