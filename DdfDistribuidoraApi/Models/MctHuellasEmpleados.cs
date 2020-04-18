using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("MCT_HuellasEmpleados")]
    public partial class MctHuellasEmpleados
    {
        public int CodigoEmpleado { get; set; }
        [Required]
        [StringLength(1)]
        public string Mano { get; set; }
        [Required]
        [StringLength(1)]
        public string Dedo { get; set; }
        [Required]
        [StringLength(1)]
        public string Principal { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
