using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_Conceptos")]
    public partial class CgConceptos
    {
        [Key]
        [StringLength(4)]
        public string CodigoSistema { get; set; }
        [Key]
        [StringLength(4)]
        public string CodigoConcepto { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(4)]
        public string CodigoArea { get; set; }
        [Required]
        [StringLength(1)]
        public string EstadoAsiento { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
    }
}
