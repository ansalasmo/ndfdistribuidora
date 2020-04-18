using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("AD_Bloqueos")]
    public partial class AdBloqueos
    {
        [Key]
        public int NumeroBloqueo { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [StringLength(20)]
        public string UsuarioCancela { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaCancela { get; set; }
    }
}
