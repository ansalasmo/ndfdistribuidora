using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("GR_ValoresConsultar")]
    public partial class GrValoresConsultar
    {
        [Key]
        [StringLength(20)]
        public string Usuario { get; set; }
        [Key]
        public int Codigo { get; set; }
    }
}
