using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Guest
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }


        public ICollection<Staff>staff { get; set; }=new List<Staff>();

        [ForeignKey("Room")]
        public int? RoomId { get; set; }
        public Room Room { get; set; }
    }
}
