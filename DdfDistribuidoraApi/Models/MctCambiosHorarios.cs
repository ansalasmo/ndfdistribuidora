using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("MCT_CambiosHorarios")]
    public partial class MctCambiosHorarios
    {
        public int PeriodoCambioHorario { get; set; }
        public int NumCambioHorario { get; set; }
        public int CodigoEmpleado { get; set; }
        public int? CodigoTipoHorario { get; set; }
        public int CodigoPrograma { get; set; }
        [Column("CodigoUE")]
        public int CodigoUe { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Entrada { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Salida { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaTrabaja { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EntradaTrabaja { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SalidaTrabaja { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaTrabaja2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EntradaTrabaja2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SalidaTrabaja2 { get; set; }
        public int? Minutos { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(20)]
        public string UsuarioAprueba { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAprueba { get; set; }
        [StringLength(20)]
        public string UsuarioEnvia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaEnvia { get; set; }
        [StringLength(20)]
        public string ApruebaFuncionario { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaFuncionario { get; set; }
        [StringLength(20)]
        public string UsuarioAnula { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAnula { get; set; }
        public int? PeriodoSemanal { get; set; }
        public int? NumeroSemanal { get; set; }
        [StringLength(1)]
        public string TipoAplica { get; set; }
    }
}
