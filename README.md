**# Custom Authentication in Blazor Web App - SSR**

Blazor 8 has significantly simplified the authentication process. Here are the steps involved in implementing custom authentication:

1. **Project Setup:** Start by creating a Blazor project without any built-in authentication.

2. **Authentication Configuration (Program.cs):** Modify your `Program.cs` file to include the following code:

   ```csharp
   builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(c =>
   {
     c.Cookie.Name = "app_token";
     c.Cookie.MaxAge = TimeSpan.FromMinutes(30); 
     c.LoginPath = "/account/login"; 
     c.AccessDeniedPath = "/access-denied"; 
   });
   builder.Services.AddAuthentication(); 
   builder.Services.AddCascadingAuthenticationState();
   ```

   * This configures cookie-based authentication, sets cookie parameters, and defines redirection paths for login and access denied scenarios.

3. **Middleware Updates:**  In your app's middleware pipeline, add the following:

   ```csharp
   app.UseAuthentication(); 
   app.UseAuthorization(); 
   app.UseAntiforgery(); 
   ```

   * These lines enable authentication and authorization middleware, as well as anti-forgery protection.

4. **Login View Model (LoginVM.cs):**  Create a view model class to hold login credentials (e.g., username and password). 

5. **Login Page:** Design a login page where users can enter their credentials.

6. **Login Logic:** Write the code to handle login credential submission:
   * This would likely involve validating credentials against a user store (database, etc.)
   * On success, create an authentication cookie to establish the user's session.

**Let me know if you'd like me to expand on any specific parts of the authentication process or provide more detailed code examples!** 
