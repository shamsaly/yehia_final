using Final_Project.Specification;

namespace Final_Project.Generic
{
    public interface IgenericRepo<T>where T : class
    {

        Task<IEnumerable<T>> GetAll(ISpec<T> spec);
        Task<T>GetById(ISpec<T> spec);

        Task Add(T item);
        Task Delete(T item);
        Task Update(T item);




    }
}
