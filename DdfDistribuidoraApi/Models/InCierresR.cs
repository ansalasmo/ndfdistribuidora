using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("IN_CierresR")]
    public partial class InCierresR
    {
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Mes { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal EfectivoR { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal EfectivoA { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Utilidad { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Pagar { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
