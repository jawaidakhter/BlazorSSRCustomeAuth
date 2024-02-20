using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using System.Security.Claims;

namespace WarehouseMgm.Components.Pages.Account
{
    public partial class Login
    {


        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            if(httpContext.User.Identity.IsAuthenticated)
            {
                navMgr.NavigateTo("/");
            }
        }

        [CascadingParameter] HttpContext? httpContext { get; set; }
        [SupplyParameterFromForm] private LoginVM LoginModel { get; set; } = new LoginVM();

        private bool isHttpNull = true;
        public async Task DoLogin()
        {
            if (LoginModel.UserName == "admin" && LoginModel.Password == "admin")
            {
                var claims = new List<Claim>
            {
                new Claim (ClaimTypes.Name, LoginModel.UserName)
            };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                await httpContext.SignInAsync(principal);

                navMgr.NavigateTo("/");
            }
        }
    }
}
