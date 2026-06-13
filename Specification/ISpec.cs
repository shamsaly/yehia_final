using System.Linq.Expressions;

namespace Final_Project.Specification
{
    public interface ISpec <T> where T : class
    {
        public Expression<Func<T, bool>> condition { get; set; }
        public List<Expression<Func<T,object>>> Includes { get; set; }

    }
}
