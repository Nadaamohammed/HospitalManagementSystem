using Microsoft.AspNetCore.Identity;

namespace HospitalManagementSystem.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
       

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
