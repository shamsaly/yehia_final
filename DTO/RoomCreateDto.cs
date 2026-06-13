using System.ComponentModel.DataAnnotations;

namespace Final_Project.DTO
{

    public class RoomCreateDto
    {
        public string RoomNumber { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
    }
}
