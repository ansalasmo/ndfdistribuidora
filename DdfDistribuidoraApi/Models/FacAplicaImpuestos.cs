using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_AplicaImpuestos")]
    public partial class FacAplicaImpuestos
    {
        [Key]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Column("IV", TypeName = "decimal(18, 2)")]
        public decimal Iv { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ImpS { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(20)]
        public string UsuarioModifica { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
    }
}
