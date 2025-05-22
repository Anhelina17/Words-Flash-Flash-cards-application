using Fiszki.Infrastructure.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fiszki.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LoginInputModel LoginInput { get; set; }
        public string ErrorMessage { get; set; }

        public class LoginInputModel
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = _context.Users.FirstOrDefault(u =>
            u.Username == LoginInput.Username && u.Password == LoginInput.Password);
            
            if (user == null)
            {
                ErrorMessage = "Invalid username or password";
                return Page();
            }

            return Redirect("/Privacy"); // PLCAEHOLDER TO BE CHANGED TO THE PAGE WE WANT THE USER TO SEE AFTERH  LOGIN
        }
    }
}
