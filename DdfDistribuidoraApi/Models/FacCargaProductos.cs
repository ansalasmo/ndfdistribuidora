using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_CargaProductos")]
    public partial class FacCargaProductos
    {
        [Key]
        [StringLength(30)]
        public string Codigo { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(255)]
        public string NombreGenerico { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioAfiliado { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioIndustria { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioPublico { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Costo { get; set; }
    }
}
