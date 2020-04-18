using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_SeparacionPedidos")]
    public partial class FacSeparacionPedidos
    {
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Mes { get; set; }
        [Key]
        public int Dia { get; set; }
        [Key]
        public int NumeroPedido { get; set; }
        [Key]
        public int Consecutivo { get; set; }
        public int Linea { get; set; }
        public int CodigoProducto { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cantidad { get; set; }
        public int NumeroMesa { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? NumeroFactura { get; set; }
        [StringLength(1)]
        public string EsExtra { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? PrecioVenta { get; set; }
        public int? Cuenta { get; set; }
        [StringLength(1)]
        public string TipoDescuento { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Descuento { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MontoDescuento { get; set; }
        [StringLength(100)]
        public string CodigoMiPueblo { get; set; }
        [StringLength(1)]
        public string Clave { get; set; }
        [Column("IDCliente")]
        [StringLength(50)]
        public string Idcliente { get; set; }
        public int? LineaFactura { get; set; }
    }
}
