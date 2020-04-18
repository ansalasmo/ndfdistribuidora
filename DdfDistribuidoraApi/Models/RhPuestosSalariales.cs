using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_PuestosSalariales")]
    public partial class RhPuestosSalariales
    {
        [Column("CodigoPuestoES")]
        public int CodigoPuestoEs { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SalarioBase { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MontoAnualidad { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
