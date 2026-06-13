using Final_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.DTO
{
    public class StaffreturnDto
    {


        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string? phone { get; set; }

        public DepartmentCreateDto Department { get; set; } 

       
    }
}
