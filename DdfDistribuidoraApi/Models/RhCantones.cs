using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_Cantones")]
    public partial class RhCantones
    {
        public int CodigoProvincia { get; set; }
        public int CodigoCanton { get; set; }
        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }
        public int? CodigoPais { get; set; }
    }
}
