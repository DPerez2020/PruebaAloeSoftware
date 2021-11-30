using Microsoft.EntityFrameworkCore;
using PruebaAloe.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAloe.data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Departamento>().HasData(new core.Departamento[] {
                new Departamento(){Id=1, Codigo="DPT-01",Nombre="Departamento de ventas" },
                new Departamento(){Id=2,Codigo="DPT-02",Nombre="Departamento de Compras" },
            });
        }

    }
}
