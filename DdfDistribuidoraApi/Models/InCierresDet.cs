using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("IN_CierresDet")]
    public partial class InCierresDet
    {
        [Key]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal NumeroCierre { get; set; }
        [Key]
        public int CodigoBodega { get; set; }
        [Key]
        public int CodigoProducto { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SaldoFinal { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SaldoFisico { get; set; }
    }
}
