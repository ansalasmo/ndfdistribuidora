using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_ProductosProveedor")]
    public partial class FacProductosProveedor
    {
        [Key]
        [StringLength(20)]
        public string CedulaCliente { get; set; }
        [Key]
        public int CodigoProducto { get; set; }
        [Required]
        [StringLength(20)]
        public string CodigoProductoProveedor { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? CantidadSeparacion { get; set; }
    }
}
