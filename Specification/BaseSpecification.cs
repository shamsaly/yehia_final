using System.Linq.Expressions;

namespace Final_Project.Specification
{
    public class BaseSpecification<T> : ISpec<T> where T : class
    {
        public Expression<Func<T, bool>> condition { get; set; }
        public List<Expression<Func<T, object>>> Includes { get; set; } = new List<Expression<Func<T, object>>>();

        public BaseSpecification()
        {
            
        }

        public BaseSpecification(Expression<Func<T,bool>>expression)
        {
            condition = expression;
            
        }


    }
}
