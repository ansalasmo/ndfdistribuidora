using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("SG_Sistemas")]
    public partial class SgSistemas
    {
        public SgSistemas()
        {
            IdFormularios = new HashSet<IdFormularios>();
        }

        [Key]
        public int CodigoSistema { get; set; }
        [Required]
        [StringLength(50)]
        public string DescripcionSistema { get; set; }
        [Required]
        [StringLength(1)]
        public string EstadoSistema { get; set; }
        public int? ImagenSistema { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistra { get; set; }
        [StringLength(1)]
        public string EsWeb { get; set; }

        [InverseProperty("CodigoSistemaNavigation")]
        public virtual ICollection<IdFormularios> IdFormularios { get; set; }
    }
}
