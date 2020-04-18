using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_HistorialPrecios")]
    public partial class FacHistorialPrecios
    {
        [Key]
        public int CodigoProducto { get; set; }
        [Key]
        public int NumeroCambio { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioAnterior { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal NuevoPrecio { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
