namespace HospitalManagementSystem.Models.Entity
{
    public class Prescription
    {
        public int Id { get; set; }

        public int MedicalRecordId { get; set; }

        public MedicalRecord MedicalRecord { get; set; }

        public string MedicineName { get; set; }

        public string Dosage { get; set; }

        public string Instructions { get; set; }
    }
}
