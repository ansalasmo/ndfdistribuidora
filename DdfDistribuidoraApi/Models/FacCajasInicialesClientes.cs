using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_CajasInicialesClientes")]
    public partial class FacCajasInicialesClientes
    {
        [Key]
        public int CodigoLocal { get; set; }
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Mes { get; set; }
        [Key]
        public int Dia { get; set; }
        [Key]
        [StringLength(20)]
        public string Login { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MontoCajaInicial { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
    }
}
