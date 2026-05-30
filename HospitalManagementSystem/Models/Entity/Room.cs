namespace HospitalManagementSystem.Models.Entity
{
    public class Room
    {
        public int Id { get; set; }

        public string RoomNumber { get; set; }

        public string RoomType { get; set; }

        public bool IsOccupied { get; set; }
    }
}
