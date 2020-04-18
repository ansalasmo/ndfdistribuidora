using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_ConceptosRetirosClientes")]
    public partial class FacConceptosRetirosClientes
    {
        [Key]
        public int CodigoLocal { get; set; }
        [Key]
        public int CodigoConcepto { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(20)]
        public string Cuenta { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(1)]
        public string EsPlanilla { get; set; }
    }
}
