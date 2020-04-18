using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("IN_CierresInventario")]
    public partial class InCierresInventario
    {
        [Key]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal NumeroCierre { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistra { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [StringLength(1)]
        public string AjusteAplicado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaCierre { get; set; }
        public int? NumeroMov { get; set; }
        [StringLength(1)]
        public string Tipo { get; set; }
    }
}
