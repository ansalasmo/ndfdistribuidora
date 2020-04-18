using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("IN_Movimientos")]
    public partial class InMovimientos
    {
        [Key]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal NumeroMov { get; set; }
        public int CodigoTipoMov { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoRegistro { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(20)]
        public string UsuarioEnvia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaEnvia { get; set; }
        [StringLength(20)]
        public string UsuarioAprueba { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAprueba { get; set; }
        [StringLength(20)]
        public string UsuarioAnula { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAnula { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? NumeroFactura { get; set; }
        public int? Periodo { get; set; }
        public int? Mes { get; set; }
        public int? Dia { get; set; }
        public int? NumeroPedido { get; set; }
        [StringLength(20)]
        public string CedulaProveedor { get; set; }
        [StringLength(20)]
        public string UsuarioCierra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaCierra { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? NumeroCierre { get; set; }
        [Column("IDComercio")]
        public int? Idcomercio { get; set; }
        public int? NumeroMovOrigen { get; set; }
        public int? DiasCredito { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [StringLength(20)]
        public string Cedula { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaInventarios { get; set; }
    }
}
