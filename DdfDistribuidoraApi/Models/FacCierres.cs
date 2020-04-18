using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_Cierres")]
    public partial class FacCierres
    {
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Mes { get; set; }
        [Key]
        public int Dia { get; set; }
        [Key]
        [StringLength(20)]
        public string Login { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaCierre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MontoCashBack { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Efectivo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Tarjeta { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DiferenciaEfectivo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DiferenciaTarjeta { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Deposito { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cheque { get; set; }
        [Column("CuentaXCobrar", TypeName = "decimal(18, 2)")]
        public decimal CuentaXcobrar { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? VentasSinImp { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CashbackOtorgado { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? PagoElectronico { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? IngresosCaja { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MontoRecargas { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Recargas { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Descuentos { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? EfectivoIncluido { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TarjetaIncluida { get; set; }
        [Column("ArchivoPDF")]
        public byte[] ArchivoPdf { get; set; }

        [ForeignKey("Periodo,Mes,Dia,Login")]
        [InverseProperty("FacCierres")]
        public virtual FacCajasIniciales FacCajasIniciales { get; set; }
    }
}
