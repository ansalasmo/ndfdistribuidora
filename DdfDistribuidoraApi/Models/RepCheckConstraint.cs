using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("REP_CheckConstraint")]
    public partial class RepCheckConstraint
    {
        [Key]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Key]
        [StringLength(30)]
        public string NombreObjetoNet { get; set; }
        [Key]
        [StringLength(30)]
        public string NombreCampo { get; set; }
        [Key]
        [StringLength(1)]
        public string Valor { get; set; }
        [Required]
        [StringLength(30)]
        public string Descripcion { get; set; }

        [ForeignKey("Nombre,NombreObjetoNet,NombreCampo")]
        [InverseProperty(nameof(RepCargarCombos.RepCheckConstraint))]
        public virtual RepCargarCombos NombreNavigation { get; set; }
    }
}
