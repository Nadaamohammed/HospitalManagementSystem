using System.Numerics;

namespace HospitalManagementSystem.Models.Entity
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
    }
}
