using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models.ORM
{
    public class NortWindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2KUVAQ5\\SQLEXPRESS;Database=UniversityDb;Trusted_Connection=true;TrustServerCertificate=true;");

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
