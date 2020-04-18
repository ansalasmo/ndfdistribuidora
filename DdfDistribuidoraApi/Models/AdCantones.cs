using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("AD_Cantones")]
    public partial class AdCantones
    {
        [Key]
        public int CodigoPais { get; set; }
        [Key]
        public int CodigoProvincia { get; set; }
        [Key]
        public int CodigoCanton { get; set; }
        [Required]
        [StringLength(100)]
        public string NombreCanton { get; set; }
        [StringLength(2)]
        public string Identificador { get; set; }
    }
}
