using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("MCT_TiposJustificaciones")]
    public partial class MctTiposJustificaciones
    {
        public int CodigoJustificacion { get; set; }
        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(1)]
        public string Rebaja { get; set; }
        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }
        public int MinutosGracia { get; set; }
        [Required]
        [StringLength(255)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
