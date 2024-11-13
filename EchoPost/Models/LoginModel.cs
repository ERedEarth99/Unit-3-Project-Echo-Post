using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace EchoPost.Models
{
   

    
        public class LoginModel : PageModel
        {
            [BindProperty]
            public string Username { get; set; }

            [BindProperty]
            public string Password { get; set; }

            public IActionResult OnPostLogin()
            {
                // Simple authentication (for demonstration only)
                if (Username == "testuser" && Password == "password")
                {
                    return RedirectToPage("Account", new { username = Username });
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return Page();
            }
        }
    }


