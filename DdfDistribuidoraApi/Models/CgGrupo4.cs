using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_Grupo4")]
    public partial class CgGrupo4
    {
        [Key]
        public int CodigoReporte { get; set; }
        [Key]
        public int GrupoUno { get; set; }
        [Key]
        public int GrupoDos { get; set; }
        [Key]
        public int GrupoTres { get; set; }
        [Key]
        public int GrupoCuatro { get; set; }
        [Required]
        [StringLength(255)]
        public string NombreCuatro { get; set; }
        [StringLength(100)]
        public string LineaCuatroA { get; set; }
        [StringLength(100)]
        public string LineaCuatroB { get; set; }
        [Required]
        [StringLength(1)]
        public string MostrarLineaCuatroA { get; set; }
        [Required]
        [StringLength(1)]
        public string MostrarLineaCuatroB { get; set; }
        [Required]
        [StringLength(1)]
        public string MostrarEncabezadoCuatro { get; set; }
        [Required]
        [StringLength(1)]
        public string MostrarPieCuatro { get; set; }
        [StringLength(255)]
        public string PieCuatro { get; set; }
        public int? CodigoEmpresa { get; set; }
        [StringLength(3)]
        public string Nota4 { get; set; }
    }
}
