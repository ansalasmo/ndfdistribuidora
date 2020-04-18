using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_ResponsablesConceptos")]
    public partial class CgResponsablesConceptos
    {
        [Key]
        [StringLength(15)]
        public string Login { get; set; }
        [Key]
        [StringLength(4)]
        public string CodigoSistema { get; set; }
        [Key]
        [StringLength(4)]
        public string CodigoConcepto { get; set; }
        [Required]
        [StringLength(1)]
        public string AccesoLectura { get; set; }
        [Required]
        [Column("AccesoABC")]
        [StringLength(1)]
        public string AccesoAbc { get; set; }
        [Required]
        [StringLength(1)]
        public string AccesoMayoriza { get; set; }
        [StringLength(15)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
    }
}
