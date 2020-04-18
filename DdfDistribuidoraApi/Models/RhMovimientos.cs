using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_Movimientos")]
    public partial class RhMovimientos
    {
        public RhMovimientos()
        {
            RhMovimientosExtra = new HashSet<RhMovimientosExtra>();
            RhPlanilla = new HashSet<RhPlanilla>();
        }

        [Key]
        public int CodigoMovimiento { get; set; }
        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoMovimiento { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoComponente { get; set; }
        [Required]
        [StringLength(1)]
        public string Porcentual { get; set; }
        [Required]
        [StringLength(1)]
        public string AfectaTodos { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ValorMovimiento { get; set; }
        [Required]
        [StringLength(1)]
        public string Momento { get; set; }
        [Required]
        [StringLength(20)]
        public string CuentaContable { get; set; }
        [StringLength(20)]
        public string CodigoPresupuesto { get; set; }
        [Required]
        [StringLength(1)]
        public string AplicaImpuesto { get; set; }
        [Required]
        [Column("AplicaCCSS")]
        [StringLength(1)]
        public string AplicaCcss { get; set; }
        [Required]
        [Column("AplicaBP")]
        [StringLength(1)]
        public string AplicaBp { get; set; }
        [Required]
        [StringLength(1)]
        public string AplicaDeducPorc { get; set; }
        [Required]
        [StringLength(1)]
        public string AplicaAguinaldo { get; set; }
        [Required]
        [StringLength(1)]
        public string AplicaSalarioEscolar { get; set; }
        [Required]
        [StringLength(1)]
        public string PlanPension { get; set; }
        [StringLength(15)]
        public string Cedula { get; set; }
        public int? CodigoConcepto { get; set; }
        public int? CodigoSubConcepto { get; set; }
        [StringLength(12)]
        public string CodigoArticulo { get; set; }
        public int? CodigoPrograma { get; set; }
        [Column("CodigoUE")]
        public int? CodigoUe { get; set; }
        public int? CodigoCuenta { get; set; }
        public int? CodigoSubCuenta { get; set; }
        [Column("IndicadorCS")]
        [StringLength(1)]
        public string IndicadorCs { get; set; }
        [StringLength(100)]
        public string NombreCuenta { get; set; }
        [StringLength(17)]
        public string CuentaCliente { get; set; }
        public int? CodigoGrupo { get; set; }
        [StringLength(1)]
        public string AplicaRiesgos { get; set; }
        [StringLength(20)]
        public string CuentaPasivo { get; set; }
        [StringLength(1)]
        public string AplicaEmbargo { get; set; }

        [InverseProperty("CodigoMovimientoNavigation")]
        public virtual ICollection<RhMovimientosExtra> RhMovimientosExtra { get; set; }
        [InverseProperty("CodigoMovimientoNavigation")]
        public virtual ICollection<RhPlanilla> RhPlanilla { get; set; }
    }
}
