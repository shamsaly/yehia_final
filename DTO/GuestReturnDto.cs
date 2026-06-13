using System.ComponentModel.DataAnnotations;

namespace Final_Project.DTO
{
    public class GuestReturnDto
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public ICollection<StaffreturnDtoforguest>staff { get; set; }=new List<StaffreturnDtoforguest>();    



        public RoomCreateDto Room { get; set; } 
    }
}
