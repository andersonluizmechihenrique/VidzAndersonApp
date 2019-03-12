using Microsoft.EntityFrameworkCore;
using VidzAnderson.API.Models;

namespace VidzAnderson.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { } 
        
            
         

       public DbSet<Value> Values { get; set; }
    }
}