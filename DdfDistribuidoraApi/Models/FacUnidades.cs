using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_Unidades")]
    public partial class FacUnidades
    {
        [Key]
        public int CodigoUnidad { get; set; }
        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(5)]
        public string Siglas { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? FactorConversion { get; set; }
    }
}
