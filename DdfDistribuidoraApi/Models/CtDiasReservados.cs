using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CT_DiasReservados")]
    public partial class CtDiasReservados
    {
        [Key]
        public int CodigoZona { get; set; }
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Mes { get; set; }
        [Key]
        public int Dia { get; set; }
        [Key]
        public int CodigoHorario { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistra { get; set; }

        [ForeignKey(nameof(CodigoZona))]
        [InverseProperty(nameof(CtZonas.CtDiasReservados))]
        public virtual CtZonas CodigoZonaNavigation { get; set; }
    }
}
