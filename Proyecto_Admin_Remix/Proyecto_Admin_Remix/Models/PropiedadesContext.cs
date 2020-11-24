using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto_Admin_Remix.Models;

namespace Proyecto_Admin_Remix.Models
{
    public class PropiedadesContext: DbContext
    {
        public PropiedadesContext(DbContextOptions<PropiedadesContext> options):base(options)
        {
        }

        public DbSet<Propiedades> PropiedadesEN { get; set; }

        public DbSet<Proyecto_Admin_Remix.Models.Formularios> Formularios { get; set; }
    }
}
