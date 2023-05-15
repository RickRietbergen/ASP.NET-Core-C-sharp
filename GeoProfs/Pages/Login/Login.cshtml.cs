using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class LoginModel : PageModel
{
    public IActionResult OnPost(string username, string password)
    {
        // Perform authentication logic here
        if (IsValidCredentials(username, password))
        {
            // Redirect to the home page or any other page upon successful login
            return RedirectToPage("/Index");
        }
        else
        {
            // Add a model error to display an error message
            ModelState.AddModelError(string.Empty, "Invalid username or password");
            return Page();
        }
    }

    private bool IsValidCredentials(string username, string password)
    {
        // Add your authentication logic here, such as checking against a database or external service
        // Return true if the credentials are valid, false otherwise
        // For this example, let's assume username = "admin" and password = "password"
        return username == "admin" && password == "password";
    }
}