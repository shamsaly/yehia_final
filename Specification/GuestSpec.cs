using Final_Project.Models;

namespace Final_Project.Specification
{
    public class GuestSpec :BaseSpecification<Guest>
    {

        public GuestSpec():base()
        {
            Includes.Add(G=>G.staff);
            Includes.Add(G => G.Room);

        }

        public GuestSpec(int id ) : base(G=>G.Id==id)
        {
            Includes.Add(G => G.staff);
            Includes.Add(G => G.Room);

        }


    }
}
