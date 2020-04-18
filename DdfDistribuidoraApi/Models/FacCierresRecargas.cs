using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_CierresRecargas")]
    public partial class FacCierresRecargas
    {
        [Key]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal NumeroRecarga { get; set; }
        public int Periodo { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
        [Required]
        [StringLength(20)]
        public string Login { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Monto { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(20)]
        public string UsuarioPaga { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaPaga { get; set; }
        [StringLength(17)]
        public string CodigoCuenta { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        public int? NumeroDoc { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Comision { get; set; }
    }
}
