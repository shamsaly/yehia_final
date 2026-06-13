using Final_Project.Models;

namespace Final_Project.Specification
{
    public class StaffSpec:BaseSpecification<Staff>
    {
        public StaffSpec():base()
        {
            Includes.Add(s => s.Department);
            Includes.Add(s=>s.Guests);

            
        }



        public StaffSpec(int id) : base(s=>s.Id==id)
        {
            Includes.Add(s => s.Department);
            Includes.Add(s => s.Guests);


        }


    }
}
