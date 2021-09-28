using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public class SignInModel : PageModel
    {
        //private readonly ModelContext _context;
        public async Task<IActionResult> OnGet()
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, "Wachirawit"),
                new Claim(ClaimTypes.Email, "wachirawit.j@psu.ac.th"),
                new Claim("StaffID", "0001972"),
                new Claim(ClaimTypes.Role, "user"),
            };

/*            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }*/

            var claimsIdentity = new ClaimsIdentity(
                claims,
                CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(
               CookieAuthenticationDefaults.AuthenticationScheme,
               new ClaimsPrincipal(claimsIdentity));
            return LocalRedirect(Url.Content("~/"));
        }
    }
}
