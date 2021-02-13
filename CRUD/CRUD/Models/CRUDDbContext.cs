using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class CRUDDbContext : DbContext
    {
        public CRUDDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
    }
}
