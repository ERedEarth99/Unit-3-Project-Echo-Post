using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace EchoPost.Models
{
    
    
        public class RegisterModel : PageModel
        {
            [BindProperty]
            public string Username { get; set; }

            [BindProperty]
            public string Password { get; set; }

            [BindProperty]
            public string Email { get; set; }

            public IActionResult OnPostRegister()
            {
                // In a real application, you'd save user data to a database here

                return RedirectToPage("Login");
            }
        }
    }


