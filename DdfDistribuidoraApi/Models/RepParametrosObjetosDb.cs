using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("REP_ParametrosObjetosDB")]
    public partial class RepParametrosObjetosDb
    {
        public RepParametrosObjetosDb()
        {
            RepCargarCombos = new HashSet<RepCargarCombos>();
        }

        [Key]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Key]
        [StringLength(30)]
        public string NombreObjetoNet { get; set; }
        public int Posicion { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoDato { get; set; }
        [Required]
        [StringLength(1)]
        public string ObjetoNet { get; set; }
        [Required]
        [StringLength(30)]
        public string DescripcionLabel { get; set; }
        [StringLength(1)]
        public string ValorTodos { get; set; }
        [Column("NombreBD")]
        [StringLength(30)]
        public string NombreBd { get; set; }

        [ForeignKey(nameof(Nombre))]
        [InverseProperty(nameof(ObjetosBd.RepParametrosObjetosDb))]
        public virtual ObjetosBd NombreNavigation { get; set; }
        [InverseProperty("NombreNavigation")]
        public virtual ICollection<RepCargarCombos> RepCargarCombos { get; set; }
    }
}
