using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CT_ObjetosText")]
    public partial class CtObjetosText
    {
        public int CodigoSistema { get; set; }
        [Required]
        [StringLength(100)]
        public string NombreFormulario { get; set; }
        [Required]
        [StringLength(100)]
        public string NombreObjeto { get; set; }
        [Required]
        [StringLength(255)]
        public string ValorText { get; set; }
    }
}
