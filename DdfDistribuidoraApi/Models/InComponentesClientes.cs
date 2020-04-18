using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("IN_ComponentesClientes")]
    public partial class InComponentesClientes
    {
        [Key]
        public int CodigoLocal { get; set; }
        [Key]
        public int CodigoProducto { get; set; }
        [Key]
        public int CodigoComponente { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Cantidad { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(1)]
        public string TipoComponente { get; set; }
        [StringLength(1)]
        public string Cambiar { get; set; }
    }
}
