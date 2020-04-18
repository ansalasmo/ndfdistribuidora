using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("MCT_EmpleadosMarcasEspeciales")]
    public partial class MctEmpleadosMarcasEspeciales
    {
        public int CodigoEmpleado { get; set; }
        [Required]
        [StringLength(100)]
        public string NombreEmpleado { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoMarca { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
