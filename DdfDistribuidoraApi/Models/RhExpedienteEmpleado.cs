using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_ExpedienteEmpleado")]
    public partial class RhExpedienteEmpleado
    {
        [Key]
        public int PeriodoArchivo { get; set; }
        [Key]
        public int ConsecutivoArchivo { get; set; }
        public int CodigoEmpleado { get; set; }
        public int CodigoTipoDoc { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        public int? PeriodoAmonestacion { get; set; }
        public int? NumeroAmonestacion { get; set; }
    }
}
