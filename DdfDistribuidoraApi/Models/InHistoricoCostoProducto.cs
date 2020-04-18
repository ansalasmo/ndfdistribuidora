using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("IN_HistoricoCostoProducto")]
    public partial class InHistoricoCostoProducto
    {
        [Key]
        public int CodigoProducto { get; set; }
        [Key]
        public int Linea { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal CostoViejo { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal CostoNuevo { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Cantidad { get; set; }
        public int? NumeroMov { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
