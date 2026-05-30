namespace HospitalManagementSystem.Models.Entity
{
    public class MedicalRecord
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public Patient Patient { get; set; }

        public int DoctorId { get; set; }

        public Doctor Doctor { get; set; }

        public string Diagnosis { get; set; }

        public string Treatment { get; set; }

        public string Notes { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
