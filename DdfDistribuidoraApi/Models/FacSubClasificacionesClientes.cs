using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_SubClasificacionesClientes")]
    public partial class FacSubClasificacionesClientes
    {
        [Key]
        public int CodigoLocal { get; set; }
        [Key]
        public int CodigoTipoClasificacion { get; set; }
        [Key]
        public int CodigoSubClasificacion { get; set; }
        [Required]
        [StringLength(100)]
        public string NombreSubClasificacion { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(1)]
        public string ProductosRapidos { get; set; }
        [StringLength(1)]
        public string Promociones { get; set; }
        [StringLength(1)]
        public string Ventas { get; set; }
        [StringLength(1)]
        public string Guarniciones { get; set; }
        [StringLength(1)]
        public string TipoExtra { get; set; }
    }
}
