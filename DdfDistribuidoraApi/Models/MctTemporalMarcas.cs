using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("MCT_TemporalMarcas")]
    public partial class MctTemporalMarcas
    {
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        public int CodigoEmpleado { get; set; }
        [Required]
        [StringLength(10)]
        public string Dia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [Required]
        [StringLength(1)]
        public string Modalidad { get; set; }
        [Required]
        [StringLength(1)]
        public string Problema { get; set; }
        public int? CodigoTipoJustificacion { get; set; }
        [StringLength(255)]
        public string Descripcion { get; set; }
        public int? Consecutivo { get; set; }
        [StringLength(10)]
        public string Estado { get; set; }
        public int? MinutosRebajar { get; set; }
    }
}
