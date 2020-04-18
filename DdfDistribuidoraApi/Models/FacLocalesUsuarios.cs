using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_LocalesUsuarios")]
    public partial class FacLocalesUsuarios
    {
        [Key]
        [StringLength(20)]
        public string Cedula { get; set; }
        [Key]
        public int CodigoLocal { get; set; }
    }
}
