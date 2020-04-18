using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_Planilla")]
    public partial class RhPlanilla
    {
        [Key]
        public int PeriodoPlanilla { get; set; }
        [Key]
        public int CodigoEmpleado { get; set; }
        [Key]
        public int NumeroPlanilla { get; set; }
        [Key]
        public int CodigoMovimiento { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Monto { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaDesde { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaHasta { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Ajuste { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Reportar { get; set; }
        [StringLength(1)]
        public string PagarExtras { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Salario { get; set; }
        [StringLength(1)]
        public string TipoSalario { get; set; }
        [Column("RebajarCCSS")]
        [StringLength(1)]
        public string RebajarCcss { get; set; }
        [Column("ValorRebajarCCSS", TypeName = "decimal(18, 2)")]
        public decimal? ValorRebajarCcss { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Aguinaldo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AguinaldoReportar { get; set; }
        [Column(TypeName = "text")]
        public string Observaciones { get; set; }

        [ForeignKey(nameof(CodigoEmpleado))]
        [InverseProperty(nameof(RhEmpleados.RhPlanilla))]
        public virtual RhEmpleados CodigoEmpleadoNavigation { get; set; }
        [ForeignKey(nameof(CodigoMovimiento))]
        [InverseProperty(nameof(RhMovimientos.RhPlanilla))]
        public virtual RhMovimientos CodigoMovimientoNavigation { get; set; }
    }
}
