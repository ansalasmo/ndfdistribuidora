using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("IN_PedidosInv")]
    public partial class InPedidosInv
    {
        [Key]
        public int NumeroPedido { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? NumeroMov { get; set; }
        [StringLength(20)]
        public string UsuarioCancela { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaCancela { get; set; }
        [StringLength(1)]
        public string Tipo { get; set; }
        public int? CodigoBodega { get; set; }
    }
}
