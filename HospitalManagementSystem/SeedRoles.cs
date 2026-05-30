using Microsoft.AspNetCore.Identity;

namespace HospitalManagementSystem
{
    public static class SeedRoles
    {
        public static async Task SeedAsync(
        RoleManager<IdentityRole> roleManager)
        {
            string[] roles =
            {
            "Admin",
            "Doctor",
            "Patient",
            "Receptionist",
            "Nurse"
        };

            foreach (var role in roles)
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
