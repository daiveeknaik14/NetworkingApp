using Server.Entities;
using Microsoft.EntityFrameworkCore;
namespace Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options): base(options){
        }   
        public DbSet<AppUser> Users {get; set;}
    }
}