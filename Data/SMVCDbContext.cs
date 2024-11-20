
using Microsoft.EntityFrameworkCore;
using SimpleLoginPage1.Models;

namespace SimpleLoginPage1.Data
{
    public class SMVCDbContext:DbContext{

        public SMVCDbContext(DbContextOptions<SMVCDbContext> options):base(options){

        }
        public DbSet<User> Users{get;set;}
    
    }
}