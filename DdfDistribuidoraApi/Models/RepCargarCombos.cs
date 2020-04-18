using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("REP_CargarCombos")]
    public partial class RepCargarCombos
    {
        public RepCargarCombos()
        {
            RepCheckConstraint = new HashSet<RepCheckConstraint>();
        }

        [Key]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Key]
        [StringLength(30)]
        public string NombreObjetoNet { get; set; }
        [Key]
        [StringLength(30)]
        public string NombreCampo { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoCarga { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoCampo { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoDato { get; set; }
        [Required]
        [StringLength(30)]
        public string NombreTabla { get; set; }

        [ForeignKey("Nombre,NombreObjetoNet")]
        [InverseProperty(nameof(RepParametrosObjetosDb.RepCargarCombos))]
        public virtual RepParametrosObjetosDb NombreNavigation { get; set; }
        [InverseProperty("NombreNavigation")]
        public virtual ICollection<RepCheckConstraint> RepCheckConstraint { get; set; }
    }
}
