using HospitalManagementSystem.Models.Enum;

namespace HospitalManagementSystem.Models.Entity
{
    public class Appointment
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public Patient Patient { get; set; }

        public int DoctorId { get; set; }

        public Doctor Doctor { get; set; }

        public DateTime AppointmentDate { get; set; }

        public AppointmentStatus Status { get; set; }

        public string Notes { get; set; }
    }
}