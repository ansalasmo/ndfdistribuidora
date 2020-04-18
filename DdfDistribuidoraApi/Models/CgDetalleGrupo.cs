using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_DetalleGrupo")]
    public partial class CgDetalleGrupo
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
        [Key]
        [StringLength(20)]
        public string Cuenta { get; set; }
        [Required]
        [StringLength(255)]
        public string NombreDetalle { get; set; }
        [StringLength(1)]
        public string Negativo { get; set; }
        [StringLength(1)]
        public string Formula { get; set; }
        public int? CodigoEmpresa { get; set; }
        [StringLength(1)]
        public string PrimeraColumna { get; set; }
        [StringLength(3)]
        public string NotaDetalle { get; set; }
    }
}
