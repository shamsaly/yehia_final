using System.ComponentModel.DataAnnotations;

namespace Final_Project.DTO
{
    public class StaffcreateDto
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string? phone { get; set; }


        public int Departmentid { get; set; }
    }
}
