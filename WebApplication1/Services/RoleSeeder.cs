using Microsoft.AspNetCore.Identity;

namespace AcxiomCRM.Services
{
    public static class RoleSeeder
    {
        public static async Task SeedRolesAsync(
            IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider
                .GetRequiredService<RoleManager<IdentityRole>>();

            string[] roles =
            {
                "Admin",
                "Manager",
                "Sales Executive"
            };

            foreach (string role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(
                        new IdentityRole(role));
                }
            }
        }
    }
}