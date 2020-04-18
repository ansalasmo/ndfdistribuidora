using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CT_ZonasHorarios")]
    public partial class CtZonasHorarios
    {
        [Key]
        public int CodigoZona { get; set; }
        [Key]
        public int DiaSemana { get; set; }
        [Key]
        public int CodigoHorario { get; set; }
        public int Maximo { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
