using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("BIN_PersonasIngresosSalidas")]
    public partial class BinPersonasIngresosSalidas
    {
        [Key]
        public int CodigoLocal { get; set; }
        [Key]
        [StringLength(100)]
        public string Correo { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }
    }
}
