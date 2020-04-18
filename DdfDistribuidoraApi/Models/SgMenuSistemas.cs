using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("SG_MenuSistemas")]
    public partial class SgMenuSistemas
    {
        [Key]
        public int CodigoMenu { get; set; }
        [Key]
        public int CodigoSistema { get; set; }
        [Required]
        [StringLength(50)]
        public string DescripcionMenu { get; set; }
        [Required]
        [StringLength(1)]
        public string EstadoMenu { get; set; }
        public int? ImagenMenu { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistra { get; set; }
    }
}
