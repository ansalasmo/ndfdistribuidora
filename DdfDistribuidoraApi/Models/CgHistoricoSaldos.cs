using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_HistoricoSaldos")]
    public partial class CgHistoricoSaldos
    {
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int SubPeriodo { get; set; }
        [Key]
        public int CodigoEmpresa { get; set; }
        [Key]
        [StringLength(20)]
        public string Cuenta { get; set; }
        [Column(TypeName = "money")]
        public decimal Saldo { get; set; }
        [StringLength(20)]
        public string CuentaPadre { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        public short Nivel { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoCuenta { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoSaldo { get; set; }
        [Required]
        [StringLength(1)]
        public string AceptaMov { get; set; }
        [Required]
        [StringLength(1)]
        public string CuentaOrden { get; set; }
        [Required]
        [StringLength(1)]
        public string CuentaBloqueada { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MontoMoneda { get; set; }
    }
}
