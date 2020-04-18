using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_Unidades")]
    public partial class RhUnidades
    {
        public int CodigoPrograma { get; set; }
        public int CodigoDepartamento { get; set; }
        public int CodigoUnidad { get; set; }
        [Required]
        [StringLength(50)]
        public string NombreUnidad { get; set; }
        [Column("CodigoUE")]
        public int? CodigoUe { get; set; }
    }
}
