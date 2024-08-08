using CRUD_stuff.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;

namespace CRUD_stuff.Contexts
{
    public class AppDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= DESKTOP-1TK00A3; database = Shop; trusted_connection = true;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
