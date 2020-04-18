using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_IngredientesClientes")]
    public partial class FacIngredientesClientes
    {
        [Key]
        public int CodigoLocal { get; set; }
        [Key]
        public int CodigoProducto { get; set; }
        [Key]
        public int CodigoIngrediente { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoIngrediente { get; set; }
    }
}
