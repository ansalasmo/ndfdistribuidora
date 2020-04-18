using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CT_TiposAcciones")]
    public partial class CtTiposAcciones
    {
        public CtTiposAcciones()
        {
            CtCitasAcciones = new HashSet<CtCitasAcciones>();
        }

        [Key]
        public int CodigoAccion { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoAccion { get; set; }
        [Required]
        [StringLength(1)]
        public string AccionPor { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }

        [InverseProperty("CodigoAccionNavigation")]
        public virtual ICollection<CtCitasAcciones> CtCitasAcciones { get; set; }
    }
}
