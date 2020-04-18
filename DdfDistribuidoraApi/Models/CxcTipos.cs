using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CXC_Tipos")]
    public partial class CxcTipos
    {
        public CxcTipos()
        {
            CxcCuentas = new HashSet<CxcCuentas>();
        }

        [Key]
        public int CodigoTipo { get; set; }
        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Required]
        [StringLength(20)]
        public string CuentaContable { get; set; }
        [Required]
        [StringLength(1)]
        public string EsSalario { get; set; }
        public int? CodigoDeduccion { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistro { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [StringLength(1)]
        public string RequiereAprobacion { get; set; }
        [Column("CuentaContableLP")]
        [StringLength(20)]
        public string CuentaContableLp { get; set; }
        [StringLength(1)]
        public string Impuestos { get; set; }
        public int? CodigoMovimiento { get; set; }

        [InverseProperty("CodigoTipoNavigation")]
        public virtual ICollection<CxcCuentas> CxcCuentas { get; set; }
    }
}
