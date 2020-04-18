using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_TiposHabitaciones")]
    public partial class FacTiposHabitaciones
    {
        [Key]
        [StringLength(1)]
        public string TipoHabitacion { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistra { get; set; }
    }
}
