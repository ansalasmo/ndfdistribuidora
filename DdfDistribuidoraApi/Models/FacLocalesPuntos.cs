using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_LocalesPuntos")]
    public partial class FacLocalesPuntos
    {
        public int CodigoLocal { get; set; }
        public int NumeroPunto { get; set; }
        [Required]
        [StringLength(2)]
        public string Cuadro { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Latitud { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Longitud { get; set; }
    }
}
