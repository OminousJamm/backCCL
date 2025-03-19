using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backCCL.Models;

namespace backCCL.Data
{
    public class backCCLContext : DbContext
    {
        public backCCLContext (DbContextOptions<backCCLContext> options)
            : base(options)
        {
        }

        public DbSet<backCCL.Models.Product> Product { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Establecer esquema "public"
            modelBuilder.HasDefaultSchema("public");

            modelBuilder.Entity<backCCL.Models.Product>().ToTable("products");
        }
    }
}
