using EfCoreCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreCrud.Data
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) 
        //: base(options)
        //{
         //   options.UseSqlite();
        //} 

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase(databaseName: "todos");
            //options.UseSqlite($"Data Source={DbPath}");
        }    


        public DbSet<Todo> Todos { get; set; }

    }
}