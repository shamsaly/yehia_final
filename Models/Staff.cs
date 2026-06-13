using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Staff
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string? phone { get; set; }


        public ICollection<Guest> Guests { get; set; } = new List<Guest>();

        [ForeignKey("Department")]
        public int Departmentid { get; set; }
        public Department Department { get; set; }  



    }
}
