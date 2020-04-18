using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("IN_Bodegas")]
    public partial class InBodegas
    {
        [Key]
        public int CodigoBodega { get; set; }
        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }
        public int CodigoLocal { get; set; }
        [Required]
        [StringLength(1)]
        public string ParaVenta { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
