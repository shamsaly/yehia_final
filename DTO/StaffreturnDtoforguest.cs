using System.ComponentModel.DataAnnotations;

namespace Final_Project.DTO
{
    public class StaffreturnDtoforguest
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string? phone { get; set; }
    }
}
