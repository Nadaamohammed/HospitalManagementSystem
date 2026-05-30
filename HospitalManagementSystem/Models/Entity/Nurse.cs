using HospitalManagementSystem.Models.Identity;

namespace HospitalManagementSystem.Models.Entity
{
    public class Nurse
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
