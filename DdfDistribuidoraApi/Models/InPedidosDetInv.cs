using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("IN_PedidosDetInv")]
    public partial class InPedidosDetInv
    {
        [Key]
        public int NumeroPedido { get; set; }
        [Key]
        public int Linea { get; set; }
        public int CodigoProducto { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Cantidad { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(255)]
        public string Observacion { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? CantidadExitencias { get; set; }
        public int? CodigoComponente { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? CantidadComponente { get; set; }
    }
}
