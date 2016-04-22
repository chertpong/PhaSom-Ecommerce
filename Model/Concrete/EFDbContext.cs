using Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concrete
{
   public class EFDbContext : DbContext
    {
        public EFDbContext() : base("EFDbContext")
        {
        }
        public DbSet<Product> CreateProduct { get; set; }
        public DbSet<Product> ReadProduct { get; set; }
        public DbSet<Product> UpdateProduct { get; set; }
        public DbSet<Product> DeleteProduct { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
