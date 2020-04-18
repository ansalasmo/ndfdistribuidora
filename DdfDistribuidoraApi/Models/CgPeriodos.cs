using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_Periodos")]
    public partial class CgPeriodos
    {
        [Key]
        public int Periodo { get; set; }
        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FecDesde { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FecHasta { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(1)]
        public string EstadoPeriodo { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
    }
}
