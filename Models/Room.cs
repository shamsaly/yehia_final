using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{



    [Index(nameof(RoomNumber),IsUnique =true)]
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }

    }
}
