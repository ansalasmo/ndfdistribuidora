using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("AD_Paises")]
    public partial class AdPaises
    {
        [Key]
        public int CodigoPais { get; set; }
        [StringLength(255)]
        public string NombrePais { get; set; }
    }
}
