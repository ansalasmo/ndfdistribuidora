using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_MovimientosExtra")]
    public partial class RhMovimientosExtra
    {
        [Key]
        public int CodigoEmpleado { get; set; }
        [Key]
        public int CodigoMovimiento { get; set; }
        [Key]
        public int Consecutivo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Monto { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        public int? PeriodoPlanilla { get; set; }
        public int? NumeroPlanilla { get; set; }

        [ForeignKey(nameof(CodigoEmpleado))]
        [InverseProperty(nameof(RhEmpleados.RhMovimientosExtra))]
        public virtual RhEmpleados CodigoEmpleadoNavigation { get; set; }
        [ForeignKey(nameof(CodigoMovimiento))]
        [InverseProperty(nameof(RhMovimientos.RhMovimientosExtra))]
        public virtual RhMovimientos CodigoMovimientoNavigation { get; set; }
    }
}
