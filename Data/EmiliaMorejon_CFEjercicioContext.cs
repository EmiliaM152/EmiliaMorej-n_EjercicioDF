using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmiliaMorejon_CFEjercicio.Models;

namespace EmiliaMorejon_CFEjercicio.Data
{
    public class EmiliaMorejon_CFEjercicioContext : DbContext
    {
        public EmiliaMorejon_CFEjercicioContext (DbContextOptions<EmiliaMorejon_CFEjercicioContext> options)
            : base(options)
        {
        }

        public DbSet<EmiliaMorejon_CFEjercicio.Models.Burger> Burger { get; set; } = default!;
    }
}
