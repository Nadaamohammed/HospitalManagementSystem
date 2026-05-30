using HospitalManagementSystem.Models.Enum;

namespace HospitalManagementSystem.Models.Entity
{
    public class Payment
    {
        public int Id { get; set; }

        public int BillId { get; set; }

        public Billing Bill { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
    }
}