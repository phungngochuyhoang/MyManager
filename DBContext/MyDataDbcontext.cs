using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Manager.Data.Entities;
//using System.Data.Entity;

namespace Manager.DBContext
{
    public class MyDataDbContext : DbContext
    {
        public MyDataDbContext(DbContextOptions<MyDataDbContext> options)
        : base(options)
    { }
        public virtual DbSet<AccountEntity> AccountEntity { get; set; } 
        
    }
}