using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_SubPeriodos")]
    public partial class CgSubPeriodos
    {
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int SubPeriodo { get; set; }
        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FecDesde { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FecHasta { get; set; }
        [Required]
        [StringLength(3)]
        public string Abreviatura { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [StringLength(12)]
        public string CuentaCierre { get; set; }
        [StringLength(15)]
        public string UsuarioCierre { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaCierre { get; set; }
    }
}
