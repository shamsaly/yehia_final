using System.ComponentModel.DataAnnotations;

namespace Final_Project.DTO
{
    public class GuestcreateDto
    {

        [MaxLength(50)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public List<int>? staffides { get; set; }=new List<int>();


        public RoomCreateDto? Room { get; set; }





    }
}
