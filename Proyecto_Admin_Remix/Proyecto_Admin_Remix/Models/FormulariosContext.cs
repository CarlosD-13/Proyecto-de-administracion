using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Admin_Remix.Models
{
    public class FormulariosContext:DbContext
    {
        public FormulariosContext(DbContextOptions<FormulariosContext> options) : base(options)
        {
        }

        public DbSet<Formularios> FormulariosEN { get; set; }
    }
}
