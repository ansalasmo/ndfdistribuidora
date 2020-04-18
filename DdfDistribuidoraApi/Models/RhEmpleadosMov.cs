using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_EmpleadosMov")]
    public partial class RhEmpleadosMov
    {
        [Key]
        public int CodigoEmpleado { get; set; }
        [Key]
        public int CodigoMovimiento { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MontoMovimiento { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
