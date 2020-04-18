using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_ClasificacionesClientes")]
    public partial class FacClasificacionesClientes
    {
        [Key]
        public int CodigoLocal { get; set; }
        [Key]
        public int CodigoTipoClasificacion { get; set; }
        [Required]
        [StringLength(255)]
        public string NombreClasificacion { get; set; }
        [StringLength(1)]
        public string Promociones { get; set; }
        [StringLength(1)]
        public string Ventas { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(1)]
        public string ProductosRapidos { get; set; }
        [StringLength(1)]
        public string Recargas { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DescuentoClasificacion { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DescuentoSubClasificacion { get; set; }
        [StringLength(20)]
        public string Cuenta { get; set; }
    }
}
