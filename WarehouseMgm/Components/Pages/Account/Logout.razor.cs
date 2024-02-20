using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components;

namespace WarehouseMgm.Components.Pages.Account;

public partial class Logout
{
    [CascadingParameter] HttpContext httpContext { get; set; }


    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        if (httpContext.User.Identity.IsAuthenticated)
        {
            await httpContext.SignOutAsync();
            navMgr.NavigateTo("/account/login", true);
        }
        else
        {
            navMgr.NavigateTo("/", true);
        }
    }

}
