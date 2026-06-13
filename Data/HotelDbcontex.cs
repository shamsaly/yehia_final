using Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data
{
    public class HotelDbcontex:DbContext
    {
        public HotelDbcontex(DbContextOptions<HotelDbcontex>options):base(options)
        {
            
        }


        public DbSet<Staff>staffs { get; set; }
        public DbSet<Room> rooms { get; set; }  
        public DbSet<Guest> guests { get; set; }    
        public DbSet<Department> department { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guest>().HasOne(s => s.Room).WithOne();
            base.OnModelCreating(modelBuilder);
        }

    }
}
