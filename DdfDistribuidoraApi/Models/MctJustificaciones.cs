using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("MCT_Justificaciones")]
    public partial class MctJustificaciones
    {
        public int Periodo { get; set; }
        public int NumeroJustificacion { get; set; }
        public int CodigoJustificacion { get; set; }
        public int CodigoEmpleado { get; set; }
        public int CodigoPrograma { get; set; }
        [Column("CodigoUE")]
        public int CodigoUe { get; set; }
        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        public int Minutos { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoUsuario { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistra { get; set; }
        [StringLength(20)]
        public string UsuarioEnvia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaEnvia { get; set; }
        [StringLength(20)]
        public string UsuarioAprueba { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAprueba { get; set; }
        [StringLength(20)]
        public string UsuarioAnula { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAnula { get; set; }
        [StringLength(1)]
        public string Justifica { get; set; }
    }
}
