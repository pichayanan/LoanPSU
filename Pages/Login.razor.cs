using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class Login
    {
        private object currentPrincipal;

        [CascadingParameter]
        private Task<AuthenticationState> AuthStateTask { get; set; }
        public async Task adminAsync()
        {
            var authState = await AuthStateTask;
            var user = authState.User;
            if (user.Identity.IsAuthenticated)
            {

    

                /*var identity = user.Identity as ClaimsIdentity;*/

                // check for existing claim and remove it
                /* var existingClaim = identity.FindFirst(ClaimTypes.Role);
                 if (existingClaim != null) {
                     identity.RemoveClaim(existingClaim);
                 }*/

                // add new claim
                /*identity.AddClaim(new Claim(key, value));*/
                /*  NavigationManager.NavigateTo("/", true);*/

            }
        }

        public void user()
        {
            /*await sessionStorage.SetItemAsync("role", "user");*/
            /*NavigationManager.NavigateTo("/Login", true);*/
        }
    }
}
