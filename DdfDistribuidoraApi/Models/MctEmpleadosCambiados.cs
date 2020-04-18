using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("MCT_EmpleadosCambiados")]
    public partial class MctEmpleadosCambiados
    {
        public int CodigoEmpleado { get; set; }
        public int CodigoPrograma { get; set; }
        [Column("CodigoUE")]
        public int CodigoUe { get; set; }
        [Required]
        [StringLength(255)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(20)]
        public string UsuarioModifica { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
    }
}
