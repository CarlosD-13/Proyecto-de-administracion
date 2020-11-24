using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Admin_Remix.Models
{
    public class Formularios
    {
        [Key]
        public int FormularioID { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int Cedula { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Apellido { get; set; }

        [Column(TypeName = "varchar(max)")]
        [Required]
        public string correo { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int celular { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int telefono { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Nacionalidad { get; set; }

        [Column(TypeName = "varchar(25)")]
        [Required]
        public string Sexo { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required]
        public string Fech_Naciemento { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required]
        public string Estado_civil { get; set; }
    }
}
