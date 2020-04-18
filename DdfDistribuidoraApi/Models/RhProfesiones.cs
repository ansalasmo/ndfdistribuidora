using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_Profesiones")]
    public partial class RhProfesiones
    {
        public int CodigoProfesion { get; set; }
        [Required]
        [StringLength(255)]
        public string NombreProfesion { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(20)]
        public string UsuarioModifica { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
    }
}
