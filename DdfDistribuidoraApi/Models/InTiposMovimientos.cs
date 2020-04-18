using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("IN_TiposMovimientos")]
    public partial class InTiposMovimientos
    {
        [Key]
        public int CodigoTipoMov { get; set; }
        [Required]
        [StringLength(100)]
        public string NombreTipoMov { get; set; }
        [Required]
        [StringLength(2)]
        public string TipoAccion { get; set; }
        [Required]
        [StringLength(1)]
        public string RequiereAprobacion { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(1)]
        public string RequiereBodegas { get; set; }
        public int? CodigoTipo { get; set; }
    }
}
