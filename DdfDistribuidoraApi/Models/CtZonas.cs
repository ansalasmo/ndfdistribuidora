using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CT_Zonas")]
    public partial class CtZonas
    {
        public CtZonas()
        {
            CtDiasReservados = new HashSet<CtDiasReservados>();
        }

        [Key]
        public int CodigoZona { get; set; }
        public int CodigoTipoZona { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        public int? CodigoEmpleado { get; set; }

        [InverseProperty("CodigoZonaNavigation")]
        public virtual ICollection<CtDiasReservados> CtDiasReservados { get; set; }
    }
}
