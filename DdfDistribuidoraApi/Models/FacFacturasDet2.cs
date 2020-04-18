using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_FacturasDet2")]
    public partial class FacFacturasDet2
    {
        [Key]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal NumeroFactura { get; set; }
        [Key]
        public int Linea { get; set; }
        public int CodigoProducto { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Cantidad { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Descuento { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioVenta { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MontoCashback { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MontoTotal { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CostoTotal { get; set; }
        [Column("IV", TypeName = "decimal(18, 4)")]
        public decimal? Iv { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? ImpS { get; set; }
        [Column("IVI", TypeName = "decimal(18, 4)")]
        public decimal? Ivi { get; set; }
        [Column("IVSI", TypeName = "decimal(18, 4)")]
        public decimal? Ivsi { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? RebajoComisio { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? RebajoComision { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [StringLength(1)]
        public string EnviadoNube { get; set; }
        [StringLength(255)]
        public string MotivoError { get; set; }
        public int? LineaFlorida { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? CantidadDevuelta { get; set; }
        [StringLength(1)]
        public string EstadoDevolucion { get; set; }
        [StringLength(20)]
        public string UsuarioAprueba { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAprueba { get; set; }
    }
}
