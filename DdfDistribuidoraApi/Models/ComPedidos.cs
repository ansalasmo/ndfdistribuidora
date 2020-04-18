using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("COM_Pedidos")]
    public partial class ComPedidos
    {
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Mes { get; set; }
        [Key]
        public int Dia { get; set; }
        [Key]
        public int NumeroPedido { get; set; }
        public int? NumeroMesa { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(255)]
        public string Direccion { get; set; }
        [StringLength(20)]
        public string Telefono { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        public int? CodigoLocal { get; set; }
        [Column("IDCliente")]
        [StringLength(50)]
        public string Idcliente { get; set; }
        [StringLength(255)]
        public string NombreCliente { get; set; }
        [StringLength(1)]
        public string Genero { get; set; }
        [StringLength(1)]
        public string FacturasCorreo { get; set; }
        public int? PosicionX { get; set; }
        public int? PosicionY { get; set; }
        public int? CodigoProvincia { get; set; }
        public int? CodigoCanton { get; set; }
        [StringLength(1)]
        public string Area { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? NumeroFactura { get; set; }
        [StringLength(255)]
        public string MotivoCancela { get; set; }
        [StringLength(20)]
        public string UsuarioCancela { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaCancela { get; set; }
        [StringLength(1)]
        public string ComandaImpresa { get; set; }
        [StringLength(1)]
        public string RapidoIncluido { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Descuento { get; set; }
        [StringLength(1)]
        public string TipoDescuento { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MontoDescuento { get; set; }
        [StringLength(100)]
        public string CodigoMiPueblo { get; set; }
        public int? Personas { get; set; }
        [StringLength(1)]
        public string PreviaImpresa { get; set; }
        [StringLength(1)]
        public string Clave { get; set; }
        [StringLength(50)]
        public string IdentificadorApp { get; set; }
        [StringLength(1)]
        public string DebeLlamar { get; set; }
        public int? PeriodoCita { get; set; }
        public int? MesCita { get; set; }
        public int? DiaCita { get; set; }
        public int? NumeroCita { get; set; }
        public int? CodigoCliente { get; set; }
        [StringLength(1)]
        public string AplicarImpuestos { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DescuentoDevolucion { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? FacturaDevuelta { get; set; }
    }
}
