using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("SG_OpcionesMenu")]
    public partial class SgOpcionesMenu
    {
        [Key]
        public int CodigoOpcion { get; set; }
        [Key]
        public int CodigoMenu { get; set; }
        [Key]
        public int CodigoSistema { get; set; }
        [Required]
        [StringLength(50)]
        public string DescripcionOpcion { get; set; }
        [Required]
        [StringLength(1)]
        public string EstadoOpcion { get; set; }
        [StringLength(50)]
        public string ImagenOpcion { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistra { get; set; }
        [StringLength(1)]
        public string SietePulgadas { get; set; }
    }
}
