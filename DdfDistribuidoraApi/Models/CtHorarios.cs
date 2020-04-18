using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CT_Horarios")]
    public partial class CtHorarios
    {
        [Key]
        public int CodigoHorario { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        public int HoraDesde { get; set; }
        public int HoraHasta { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
