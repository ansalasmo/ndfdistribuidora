using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("BIN_PersonasEnLocal")]
    public partial class BinPersonasEnLocal
    {
        [Key]
        public int CodigoLocal { get; set; }
        [Key]
        [StringLength(100)]
        public string Correo { get; set; }
    }
}
