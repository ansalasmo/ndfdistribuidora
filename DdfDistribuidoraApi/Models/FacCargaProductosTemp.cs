using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_CargaProductosTemp")]
    public partial class FacCargaProductosTemp
    {
        [StringLength(255)]
        public string NombreClasificacion { get; set; }
        [StringLength(100)]
        public string NombreSubClasificacion { get; set; }
        public int? CodigoProducto { get; set; }
        [StringLength(100)]
        public string NombreProducto { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? PrecioVenta { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? CostoUnitario { get; set; }
        [StringLength(1)]
        public string RequierePreparacion { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? CantidadInicial { get; set; }
        [StringLength(60)]
        public string CodigoBarras { get; set; }
        public int? CodigoTipoClasificacion { get; set; }
        public int? CodigoSubClasificacion { get; set; }
        [StringLength(1)]
        public string AplicarComision { get; set; }
    }
}
