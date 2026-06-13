using Final_Project.Data;
using Final_Project.Specification;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Generic
{
    public class GenericRepo<T> : IgenericRepo<T> where T : class
    {
        private readonly HotelDbcontex hotel;

        public GenericRepo(HotelDbcontex hotel)
        {
            this.hotel = hotel;
        }

        public async Task Add(T item)
        {
           await hotel.AddAsync(item);
            await hotel.SaveChangesAsync(); 
        }

        public async Task Delete(T item)
        {
           hotel.Set<T>().Remove(item);
            await hotel.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll(ISpec<T> spec)
        {
            return await SpecificationEvluator<T>.getquery(hotel.Set<T>(), spec).ToListAsync() ;
        }

        public async Task<T> GetById(ISpec<T> spec)
        {
            return await SpecificationEvluator<T>.getquery(hotel.Set<T>(), spec).FirstOrDefaultAsync();
        }

        public async Task Update(T item)
        {
          hotel.Update(item);
            await hotel.SaveChangesAsync() ;
        }
    }
}
