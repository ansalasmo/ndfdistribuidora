using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_Reportes")]
    public partial class CgReportes
    {
        [Key]
        public int CodigoReporte { get; set; }
        [StringLength(255)]
        public string NombreReporte { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [StringLength(255)]
        public string NombreArchivo { get; set; }
    }
}
