using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_CuentasEmpresas")]
    public partial class CgCuentasEmpresas
    {
        [Key]
        public int CodigoEmpresa { get; set; }
        [Key]
        [StringLength(20)]
        public string Cuenta { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
    }
}
