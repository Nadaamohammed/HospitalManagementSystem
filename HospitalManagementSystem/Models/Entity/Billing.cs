namespace HospitalManagementSystem.Models.Entity
{
    public class Billing
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public Patient Patient { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime BillDate { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
