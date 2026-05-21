using Microsoft.AspNetCore.Identity;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Services;

public class AuthenticationService
{
    private readonly UserManager<ApplicationUser>
        _userManager;

    private readonly SignInManager<ApplicationUser>
        _signInManager;

    public AuthenticationService(
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<IdentityResult> RegisterAsync(
        ApplicationUser user,
        string password)
    {
        return await _userManager
            .CreateAsync(user, password);
    }

    public async Task SignInAsync(
        string email,
        string password)
    {
        await _signInManager
            .PasswordSignInAsync(
                email,
                password,
                false,
                false);
    }

    public async Task LogoutAsync()
    {
        await _signInManager
            .SignOutAsync();
    }
}