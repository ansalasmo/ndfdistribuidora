using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    public partial class Paises
    {
        [Key]
        [StringLength(2)]
        public string CodigoPais { get; set; }
        [StringLength(100)]
        public string NombrePais { get; set; }
    }
}
