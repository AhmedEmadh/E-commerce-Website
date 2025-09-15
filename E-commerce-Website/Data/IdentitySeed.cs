using Microsoft.AspNetCore.Identity;

namespace E_commerce_Website.Data
{
    public static class IdentitySeed
    {
        public static async Task EnsureVisitorRoleAndAdminAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            // Ensure 'visitor' role exists
            if (!await roleManager.RoleExistsAsync("visitor"))
            {
                await roleManager.CreateAsync(new IdentityRole("visitor"));
            }
        }
    }
}
