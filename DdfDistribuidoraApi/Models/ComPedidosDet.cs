using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("COM_PedidosDet")]
    public partial class ComPedidosDet
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
        public int Linea { get; set; }
        public int CodigoProducto { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Cantidad { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(255)]
        public string Observacion { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(20)]
        public string UsuarioEnvia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaEnvia { get; set; }
        [StringLength(255)]
        public string UsuarioPrepara { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaPrepara { get; set; }
        [StringLength(255)]
        public string UsuarioSirve { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaSirve { get; set; }
        [StringLength(20)]
        public string UsuarioPreparando { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaPreparando { get; set; }
        [StringLength(1)]
        public string Rapido { get; set; }
        public int? Cuenta { get; set; }
        [StringLength(1)]
        public string RapidoIncluido { get; set; }
        public int? PedidoOrigen { get; set; }
        public int? LineaOrigen { get; set; }
        [StringLength(1)]
        public string MiPuebloCanje { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Descuento { get; set; }
        [StringLength(1)]
        public string TipoDescuento { get; set; }
        [StringLength(1)]
        public string Alerta { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? PrecioVenta { get; set; }
        public int? LineaComanda { get; set; }
    }
}
