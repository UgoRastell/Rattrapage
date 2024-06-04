// Controllers/AuthController.cs
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    [HttpGet("login")]
    public IActionResult Login()
    {
        var properties = new AuthenticationProperties { RedirectUri = Url.Action("Callback") };
        return Challenge(properties, GoogleDefaults.AuthenticationScheme);
    }

    [HttpGet("callback")]
    public async Task<IActionResult> Callback()
    {
        var authenticateResult = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        if (!authenticateResult.Succeeded)
            return BadRequest(); // Or any other appropriate error handling

        var accessToken = authenticateResult.Properties.GetTokenValue("access_token");
        var refreshToken = authenticateResult.Properties.GetTokenValue("refresh_token");

        // Use the tokens to access Google APIs or store them securely

        return Ok(new { accessToken, refreshToken });
    }
}
