using HospitalManagementSystem.Models.Identity;

namespace HospitalManagementSystem.Models.Entity
{
    public class Doctor
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int DepartmentId { get; set; }
        //relationship --> one doctor belongs to one department

        public Department Department { get; set; }

        public string Specialization { get; set; }

        public decimal ConsultationFee { get; set; }

        public int ExperienceYears { get; set; }
        //relationship --> one doctor can have many appointments

        public ICollection<Appointment> Appointments { get; set; }
    }
}