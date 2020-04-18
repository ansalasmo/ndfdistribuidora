using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("ID_Idiomas")]
    public partial class IdIdiomas
    {
        public IdIdiomas()
        {
            IdHeaderGrid = new HashSet<IdHeaderGrid>();
            IdObjetosIdiomas = new HashSet<IdObjetosIdiomas>();
        }

        [Key]
        [StringLength(3)]
        public string CodigoIdioma { get; set; }
        [Required]
        [StringLength(100)]
        public string NombreIdioma { get; set; }

        [InverseProperty("CodigoIdiomaNavigation")]
        public virtual ICollection<IdHeaderGrid> IdHeaderGrid { get; set; }
        [InverseProperty("CodigoIdiomaNavigation")]
        public virtual ICollection<IdObjetosIdiomas> IdObjetosIdiomas { get; set; }
    }
}
