using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace EchoPost.Models
{
        public class AccountModel
        {
            [BindProperty(SupportsGet = true)]
            public string Username { get; set; }

            public void OnGet()
            {
                // Normally, you'd retrieve user-specific data here (like posts or comments)
            }
        }
    }

}
