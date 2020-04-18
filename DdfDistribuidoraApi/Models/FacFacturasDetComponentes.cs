using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_FacturasDetComponentes")]
    public partial class FacFacturasDetComponentes
    {
        [Key]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal NumeroFactura { get; set; }
        [Key]
        public int Linea { get; set; }
        [Key]
        public int CodigoProducto { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Cantidad { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MontoTotal { get; set; }
        [StringLength(1)]
        public string EnviadoNube { get; set; }
        [StringLength(255)]
        public string MotivoError { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? CostoUnitario { get; set; }
    }
}
