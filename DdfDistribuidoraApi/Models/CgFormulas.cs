using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_Formulas")]
    public partial class CgFormulas
    {
        public int CodigoReporte { get; set; }
        public int GrupoUno { get; set; }
        public int GrupoDos { get; set; }
        public int GrupoTres { get; set; }
        public int GrupoCuatro { get; set; }
        [Required]
        [StringLength(20)]
        public string Cuenta { get; set; }
        [Required]
        [StringLength(20)]
        public string CuentaFormula { get; set; }
        [StringLength(1)]
        public string NegativoSub { get; set; }
        public int? CodigoEmpresa { get; set; }
    }
}
