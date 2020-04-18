using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_CuentasReportes")]
    public partial class CgCuentasReportes
    {
        public int? CodigoReporte { get; set; }
        [StringLength(20)]
        public string Cuenta { get; set; }
        public int? CodigoEmpresa { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
    }
}
