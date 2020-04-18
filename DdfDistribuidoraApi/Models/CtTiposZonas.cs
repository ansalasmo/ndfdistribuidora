using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CT_TiposZonas")]
    public partial class CtTiposZonas
    {
        [Key]
        public int CodigoTipoZona { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        public int CodigoPrograma { get; set; }
        [Column("CodigoUE")]
        public int CodigoUe { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
