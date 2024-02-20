# Custom Authentication in Blazor Web App - SSR

Blazor 8 may authentication ka process kafi siplify kar dia gaya hay. Auhentication ko implement karnay k leay mandraja zail steps darkar hain

1. Sub say pehlay aik project banana hay jis may kisi bhi kisam ki authentication na ho
2. Authentication ko configure karnay k leay Program.cs file may yeh tabdilia required hain


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(c =>
{
    c.Cookie.Name = "app_token";
    c.Cookie.MaxAge = TimeSpan.FromMinutes(30);
    c.LoginPath = "/account/login";
    c.AccessDeniedPath = "/access-denied";
});
builder.Services.AddAuthentication();
builder.Services.AddCascadingAuthenticationState();


3. Service ko configure karnay k baad middile ware may yeh update requried hay


app.UseAuthentication();
app.UseAuthorization();

app.UseAntiforgery();


4. login credntial pass karnay k leay LoginVM.cs class darkar ho gee
5. login page darkar hoga
6. Login Credential pass karnay per yeh code darkar ho ga




