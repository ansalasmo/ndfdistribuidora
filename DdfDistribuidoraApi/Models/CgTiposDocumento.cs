using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_TiposDocumento")]
    public partial class CgTiposDocumento
    {
        public int? CodigoDocumento { get; set; }
        [StringLength(255)]
        public string Descripcion { get; set; }
    }
}
