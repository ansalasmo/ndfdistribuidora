using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_SeparacionPedidos2")]
    public partial class FacSeparacionPedidos2
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
        public int Consecutivo { get; set; }
        [Key]
        [Column("NConsecutivo")]
        public int Nconsecutivo { get; set; }
        public int Linea { get; set; }
        public int CodigoProducto { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cantidad { get; set; }
        public int NumeroMesa { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? NumeroFactura { get; set; }
        [StringLength(1)]
        public string EsExtra { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? PrecioVenta { get; set; }
        public int? Cuenta { get; set; }
    }
}
