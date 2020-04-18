using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_PedidosAccionesCriticasCL")]
    public partial class FacPedidosAccionesCriticasCl
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
        [Column(TypeName = "decimal(18, 2)")]
        public decimal NumeroPedido { get; set; }
        [Key]
        public int Linea { get; set; }
        [Required]
        [StringLength(255)]
        public string Accion { get; set; }
        [Required]
        [StringLength(255)]
        public string Otros { get; set; }
        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioEjecuta { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaEjecuta { get; set; }
        [Column("EnviadoNDF")]
        [StringLength(1)]
        public string EnviadoNdf { get; set; }
    }
}
