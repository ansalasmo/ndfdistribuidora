using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_Grupo2")]
    public partial class CgGrupo2
    {
        [Key]
        public int CodigoReporte { get; set; }
        [Key]
        public int GrupoUno { get; set; }
        [Key]
        public int GrupoDos { get; set; }
        [Required]
        [StringLength(255)]
        public string NombreDos { get; set; }
        [StringLength(100)]
        public string LineaDosA { get; set; }
        [StringLength(100)]
        public string LineaDosB { get; set; }
        [Required]
        [StringLength(1)]
        public string MostrarLineaDosA { get; set; }
        [Required]
        [StringLength(1)]
        public string MostrarLineaDosB { get; set; }
        [Required]
        [StringLength(1)]
        public string MostrarEncabezadoDos { get; set; }
        [Required]
        [StringLength(1)]
        public string MostrarPieDos { get; set; }
        [StringLength(255)]
        public string PieDos { get; set; }
        public int? CodigoEmpresa { get; set; }
        [StringLength(3)]
        public string Nota2 { get; set; }
    }
}
