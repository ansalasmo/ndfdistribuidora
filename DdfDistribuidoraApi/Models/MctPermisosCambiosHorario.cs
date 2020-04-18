using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("MCT_PermisosCambiosHorario")]
    public partial class MctPermisosCambiosHorario
    {
        public int CodigoPermiso { get; set; }
        [Required]
        [StringLength(1)]
        public string PermiteMismoDia { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
