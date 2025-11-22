public class AccountService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<IdentityResult> RegisterAsync(string email, string password, string fullName)
    {
        var user = new ApplicationUser { UserName = email, Email = email, CreatedAt = DateTime.UtcNow };
        var result = await _userManager.CreateAsync(user, password);
        if (result.Succeeded)
        {
            // optionally add to default role
            await _userManager.AddToRoleAsync(user, "User");
        }
        return result;
    }
}
