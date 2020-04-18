using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_CierresAnuales")]
    public partial class CgCierresAnuales
    {
        public int CodigoEmpresa { get; set; }
        public int Periodo { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoCierre { get; set; }
        public int? Numero { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Column(TypeName = "money")]
        public decimal? Resultado { get; set; }
        [Required]
        [StringLength(20)]
        public string Cuenta { get; set; }
        public int? SubPeriodo { get; set; }
    }
}
