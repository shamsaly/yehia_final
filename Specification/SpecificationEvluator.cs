using Microsoft.EntityFrameworkCore;

namespace Final_Project.Specification
{
    public static class SpecificationEvluator<T>where T : class
    {

        public static IQueryable<T> getquery(IQueryable<T>startquery,ISpec<T>spec)
        {

            var query = startquery;

            if (spec.condition != null)
            {
               
                query=query.Where(spec.condition);

            }

            query = spec.Includes.Aggregate(query, (curr, next) => curr.Include(next));


            return query;


        }


    }
}
