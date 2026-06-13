using System.ComponentModel.DataAnnotations;

namespace Final_Project.DTO
{
    public class DepartmentCreateDto
    {
        [MaxLength(50)]
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
