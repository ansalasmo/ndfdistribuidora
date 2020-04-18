using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("MCT_CierresMes")]
    public partial class MctCierresMes
    {
        public int Periodo { get; set; }
        public int Mes { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(20)]
        public string UsuarioIncluye { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaIncluye { get; set; }
        [StringLength(20)]
        public string UsuarioAprueba { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAprueba { get; set; }
    }
}
