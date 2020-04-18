using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("COM_Facturas")]
    public partial class ComFacturas
    {
        [Key]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal NumeroFactura { get; set; }
        public int Periodo { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
        [Required]
        [StringLength(20)]
        public string Login { get; set; }
        [Column("IDCliente")]
        [StringLength(50)]
        public string Idcliente { get; set; }
        [Required]
        [StringLength(255)]
        public string NombreCliente { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CashbackAdicional { get; set; }
        [Required]
        [StringLength(1)]
        public string Reportada { get; set; }
        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Required]
        [StringLength(255)]
        public string Observacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(255)]
        public string UsuarioAnula { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAnula { get; set; }
        [StringLength(255)]
        public string UsuarioCierra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaCierra { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? NumeroCierre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Efectivo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Tarjeta { get; set; }
        [StringLength(10)]
        public string NumeroCertificado { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MontoCertificado { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Deposito { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Cheque { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? CuentaCobrar { get; set; }
        [StringLength(10)]
        public string Documento { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Vuelto { get; set; }
        [StringLength(20)]
        public string UsuarioAtiende { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRecibe { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MontoElectronico { get; set; }
        [StringLength(255)]
        public string MotivoAnulacion { get; set; }
        public int? CodigoLocal { get; set; }
        [StringLength(1)]
        public string Area { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Descuento { get; set; }
        [StringLength(1)]
        public string TipoDescuento { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MontoDescuento { get; set; }
        public int? NumeroMesa { get; set; }
        [StringLength(255)]
        public string MotivoRegalia { get; set; }
        [StringLength(1)]
        public string EnviadoNube { get; set; }
        [StringLength(255)]
        public string MotivoError { get; set; }
        [StringLength(100)]
        public string CodigoMiPueblo { get; set; }
        [Column("pointstoRedeem")]
        public int? PointstoRedeem { get; set; }
        [Column("pointsAvailableBefore")]
        public int? PointsAvailableBefore { get; set; }
        [Column("pointsAvailable")]
        public int? PointsAvailable { get; set; }
        [Column("FacturaXML")]
        public byte[] FacturaXml { get; set; }
        public int? FacturaFlorida { get; set; }
        [StringLength(20)]
        public string ConsecutivoElectronico { get; set; }
        [StringLength(50)]
        public string ClaveElectronica { get; set; }
        [StringLength(12)]
        public string Identificacion { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DolaresTarjeta { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DolaresEfectivo { get; set; }
        public int? NumeroPedido { get; set; }
        [StringLength(20)]
        public string CedulaEnvia { get; set; }
        [StringLength(100)]
        public string NombreEnvia { get; set; }
        [StringLength(60)]
        public string CorreoEnvia { get; set; }
        [StringLength(60)]
        public string TelefonoEnvia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaEntrega { get; set; }
        [StringLength(20)]
        public string UsuarioEntrega { get; set; }
        [StringLength(100)]
        public string CorreoRecibe { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? NumeroFacturaDevuelta { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MontoDevuelto { get; set; }
        [Column("FacturaXMLHacienda")]
        public byte[] FacturaXmlhacienda { get; set; }
        [Column("FacturaPDF")]
        public byte[] FacturaPdf { get; set; }
        [StringLength(20)]
        public string ConsecutivoElectronicoCred { get; set; }
        [StringLength(50)]
        public string ClaveElectronicaCred { get; set; }
        [Column("PeriodoCXP")]
        public int? PeriodoCxp { get; set; }
        [Column("NumeroCXP")]
        public int? NumeroCxp { get; set; }
    }
}
