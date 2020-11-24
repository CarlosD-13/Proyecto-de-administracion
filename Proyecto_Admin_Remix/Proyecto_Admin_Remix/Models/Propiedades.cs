using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Admin_Remix.Models
{
    public class Propiedades
    {
        [Key]
        public int InmuebleID { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Nombre { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int Habitaciones { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int Baños { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int Parqueo { get; set; }

        [Column(TypeName = "varchar(15)")]
        [Required]
        public string Opcion { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int Precio { get; set; }

        [Column(TypeName = "varchar(max)")]
        [Required]
        public string Imagen { get; set; }

        [Column(TypeName = "varchar(max)")]
        [Required]
        public string Observacion { get; set; }

    }
}
