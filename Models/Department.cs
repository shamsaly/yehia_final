using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Department
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<Staff>staff { get; set; }=new List<Staff>();

    }
}
