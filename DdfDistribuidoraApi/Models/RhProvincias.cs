using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_Provincias")]
    public partial class RhProvincias
    {
        [Key]
        public int CodigoPais { get; set; }
        [Key]
        public int CodigoProvincia { get; set; }
        [Required]
        [StringLength(100)]
        public string NombreProvincia { get; set; }
    }
}
