using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_TiposAcciones")]
    public partial class RhTiposAcciones
    {
        public int CodigoTipoAccion { get; set; }
        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(250)]
        public string TextoAccion { get; set; }
        [Required]
        [StringLength(1)]
        public string AceptaFechaHasta { get; set; }
        [StringLength(1)]
        public string JustificaMarca { get; set; }
        public int? CodigoTipoJustificacion { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(1)]
        public string AplicaAccionPlaza { get; set; }
        [Column("IDFirma1")]
        public int? Idfirma1 { get; set; }
        [Column("IDFirma2")]
        public int? Idfirma2 { get; set; }
        [Required]
        [StringLength(1)]
        public string Automatica { get; set; }
    }
}
