using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_Cuentas")]
    public partial class CgCuentas
    {
        [Key]
        [StringLength(20)]
        public string Cuenta { get; set; }
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
        public int? CodigoCuenta { get; set; }
        public int? CodigoSubCuenta { get; set; }
        [StringLength(30)]
        public string CuentaContaNac { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [StringLength(1)]
        public string Depreciacion { get; set; }
        [StringLength(30)]
        public string CuentaNueva { get; set; }
        [StringLength(1)]
        public string OrdenBalance { get; set; }
        [StringLength(1)]
        public string Interna { get; set; }
    }
}
