using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_PedidosExtras")]
    public partial class FacPedidosExtras
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
        [Required]
        [StringLength(1)]
        public string Accion { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cantidad { get; set; }
    }
}
