using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("MCT_Horarios")]
    public partial class MctHorarios
    {
        public int CodigoEmpleado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LunesEntrada { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LunesSalida { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MartesEntrada { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MartesSalida { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MiercolesEntrada { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MiercolesSalida { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JuevesEntrada { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JuevesSalida { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ViernesEntrada { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ViernesSalida { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SabadoEntrada { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SabadoSalida { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DomingoEntrada { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DomingoSalida { get; set; }
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
