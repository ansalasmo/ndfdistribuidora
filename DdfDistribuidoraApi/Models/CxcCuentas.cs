using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CXC_Cuentas")]
    public partial class CxcCuentas
    {
        public CxcCuentas()
        {
            CxcRecibos = new HashSet<CxcRecibos>();
        }

        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Numero { get; set; }
        [Required]
        [StringLength(20)]
        public string CedulaCliente { get; set; }
        public int CodigoTipo { get; set; }
        [StringLength(50)]
        public string Documento { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(1)]
        public string DeduciblePlanilla { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime InicioDevolucion { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? MontoTotal { get; set; }
        public int Plazo { get; set; }
        [Required]
        [StringLength(255)]
        public string Referencia { get; set; }
        [Required]
        [StringLength(255)]
        public string Observaciones { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoRegistro { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaVencimiento { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistro { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        public int? PeriodoAsiento { get; set; }
        public int? NumeroAsiento { get; set; }
        [Column("PeriodoID")]
        public int? PeriodoId { get; set; }
        [Column("NumeroID")]
        public int? NumeroId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TasaInteres { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAprueba { get; set; }
        [StringLength(20)]
        public string UsuarioAprueba { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAnula { get; set; }
        [StringLength(20)]
        public string UsuarioAnula { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistroReal { get; set; }
        [StringLength(20)]
        public string UsuarioEnvia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaEnvia { get; set; }
        [StringLength(20)]
        public string UsuarioCancela { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaCancela { get; set; }
        [StringLength(20)]
        public string CuentaBalance { get; set; }
        [StringLength(1)]
        public string CorreoEnviado { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MontoDeduccion { get; set; }
        [StringLength(1)]
        public string EnviadoNube { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? IdGasto { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? MontoTotalImpuesto { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TotalMercaderiasExentas { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TotalMercaderiasGravadas { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TotalServiciosExentos { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TotalServiciosGravados { get; set; }
        [StringLength(2)]
        public string CodigoImpuesto { get; set; }
        [StringLength(1)]
        public string CodigoTarifa { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Tarifa { get; set; }
        [StringLength(10)]
        public string ActividadComercial { get; set; }
        [StringLength(1)]
        public string EsSimplificado { get; set; }

        [ForeignKey(nameof(CedulaCliente))]
        [InverseProperty(nameof(CxcClientes.CxcCuentas))]
        public virtual CxcClientes CedulaClienteNavigation { get; set; }
        [ForeignKey(nameof(CodigoTipo))]
        [InverseProperty(nameof(CxcTipos.CxcCuentas))]
        public virtual CxcTipos CodigoTipoNavigation { get; set; }
        [InverseProperty("CxcCuentas")]
        public virtual ICollection<CxcRecibos> CxcRecibos { get; set; }
    }
}
