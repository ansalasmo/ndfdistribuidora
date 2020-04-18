using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_MovSaldos")]
    public partial class RhMovSaldos
    {
        [Key]
        [Column("IDOperacion")]
        public int Idoperacion { get; set; }
        public int CodigoEmpleado { get; set; }
        public int CodigoMovimiento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SaldoPrincipal { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MontoAporte { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SaldoOperacion { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Interes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecUltimoAporte { get; set; }
        [StringLength(255)]
        public string Observaciones { get; set; }
    }
}
