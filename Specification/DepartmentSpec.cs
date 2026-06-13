using Final_Project.Models;

namespace Final_Project.Specification
{
    public class DepartmentSpec:BaseSpecification<Department>
    {

        public DepartmentSpec():base()
        {
            Includes.Add(D=>D.staff);
        }



        public DepartmentSpec(int id) : base(D=>D.Id==id)
        {
            Includes.Add(D => D.staff);
        }


    }
}
