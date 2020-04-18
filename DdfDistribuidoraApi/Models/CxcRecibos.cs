using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CXC_Recibos")]
    public partial class CxcRecibos
    {
        [Key]
        public int PeriodoRecibo { get; set; }
        [Key]
        public int NumeroRecibo { get; set; }
        public int Periodo { get; set; }
        public int Numero { get; set; }
        public int CodigoTipoRecibo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Monto { get; set; }
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
        public int? PeriodoPlanilla { get; set; }
        public int? MesPlanilla { get; set; }
        public int? PeriodoGarantia { get; set; }
        public int? NumeroGarantia { get; set; }
        public int? PeriodoAsiento { get; set; }
        public int? NumeroAsiento { get; set; }
        public int? Linea { get; set; }
        [StringLength(255)]
        public string Observacion2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistraReal { get; set; }
        [StringLength(1)]
        public string TipoRegistro { get; set; }
        [StringLength(1)]
        public string EnviadoNube { get; set; }
        public int? Dia { get; set; }

        [ForeignKey(nameof(CodigoTipoRecibo))]
        [InverseProperty(nameof(CxcTiposRecibos.CxcRecibos))]
        public virtual CxcTiposRecibos CodigoTipoReciboNavigation { get; set; }
        [ForeignKey("Periodo,Numero")]
        [InverseProperty("CxcRecibos")]
        public virtual CxcCuentas CxcCuentas { get; set; }
    }
}
