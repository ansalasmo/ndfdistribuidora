using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("SG_OpcionesUsuario")]
    public partial class SgOpcionesUsuario
    {
        [Key]
        public int CodigoOpcion { get; set; }
        [Key]
        public int CodigoMenu { get; set; }
        [Key]
        public int CodigoSistema { get; set; }
        [Key]
        [StringLength(20)]
        public string Cedula { get; set; }
    }
}
