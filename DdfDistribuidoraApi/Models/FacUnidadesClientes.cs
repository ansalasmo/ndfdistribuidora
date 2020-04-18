using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_UnidadesClientes")]
    public partial class FacUnidadesClientes
    {
        [Key]
        public int CodigoLocal { get; set; }
        [Key]
        public int CodigoUnidad { get; set; }
        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(5)]
        public string Siglas { get; set; }
    }
}
