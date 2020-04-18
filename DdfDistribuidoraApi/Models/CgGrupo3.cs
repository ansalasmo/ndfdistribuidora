using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_Grupo3")]
    public partial class CgGrupo3
    {
        [Key]
        public int CodigoReporte { get; set; }
        [Key]
        public int GrupoUno { get; set; }
        [Key]
        public int GrupoDos { get; set; }
        [Key]
        public int GrupoTres { get; set; }
        [Required]
        [StringLength(255)]
        public string NombreTres { get; set; }
        [StringLength(100)]
        public string LineaTresA { get; set; }
        [StringLength(100)]
        public string LineaTresB { get; set; }
        [Required]
        [StringLength(1)]
        public string MostrarLineaTresA { get; set; }
        [Required]
        [StringLength(1)]
        public string MostrarLineaTresB { get; set; }
        [Required]
        [StringLength(1)]
        public string MostrarEncabezadoTres { get; set; }
        [Required]
        [StringLength(1)]
        public string MostrarPieTres { get; set; }
        [StringLength(255)]
        public string PieTres { get; set; }
        public int? CodigoEmpresa { get; set; }
        [StringLength(3)]
        public string Nota3 { get; set; }
    }
}
