using HospitalManagementSystem.Models.Enum;

namespace HospitalManagementSystem.Models.Entity
{
    public class Room
    {
        public int Id { get; set; }

        public string RoomNumber { get; set; }

        public RoomType RoomType { get; set; }

        public bool IsOccupied { get; set; }
    }
}
