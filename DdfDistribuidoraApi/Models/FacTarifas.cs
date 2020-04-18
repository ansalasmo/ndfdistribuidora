using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_Tarifas")]
    public partial class FacTarifas
    {
        [Key]
        [StringLength(2)]
        public string CodigoTarifa { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Tarifa { get; set; }
    }
}
