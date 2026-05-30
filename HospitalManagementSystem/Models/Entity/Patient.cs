using HospitalManagementSystem.Models.Identity;

namespace HospitalManagementSystem.Models.Entity
{
    public class Patient
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string BloodGroup { get; set; }
        //relationship --> one patient can have many appointments

        public ICollection<Appointment> Appointments { get; set; }
    }
}
