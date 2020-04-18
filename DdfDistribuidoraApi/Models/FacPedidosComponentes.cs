using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_PedidosComponentes")]
    public partial class FacPedidosComponentes
    {
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Mes { get; set; }
        [Key]
        public int Dia { get; set; }
        [Key]
        public int NumeroPedido { get; set; }
        [Key]
        public int Linea { get; set; }
        [Key]
        public int CodigoProducto { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cantidad { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(1)]
        public string Alerta { get; set; }
        public int? LineaComanda { get; set; }
    }
}
