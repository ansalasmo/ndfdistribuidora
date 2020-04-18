using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("IN_MovimientosDet")]
    public partial class InMovimientosDet
    {
        [Key]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal NumeroMov { get; set; }
        [Key]
        public int Linea { get; set; }
        public int? CodigoBodegaOri { get; set; }
        public int? CodigoBodegaDes { get; set; }
        public int CodigoProducto { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cantidad { get; set; }
        [Column("IDComercio")]
        public int? Idcomercio { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? CostoUnitario { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? CostoTotal { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? CantidadRecibida { get; set; }
        public int? ProductoPadre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? CantidadComponente { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? CantidadPadre { get; set; }
        [StringLength(1)]
        public string Exento { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ImpuestoAdicional { get; set; }
        [StringLength(1)]
        public string TipoDescuento { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MontoDescuento { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Utilidad { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? PrecioVentaActual { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? CostoUnitarioActual { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? UtilidadActual { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? PrecioModificado { get; set; }
    }
}
