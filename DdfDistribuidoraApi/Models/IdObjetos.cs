using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("ID_Objetos")]
    public partial class IdObjetos
    {
        public IdObjetos()
        {
            IdCamposGrid = new HashSet<IdCamposGrid>();
            IdObjetosIdiomas = new HashSet<IdObjetosIdiomas>();
        }

        [Key]
        public int CodigoSistema { get; set; }
        [Key]
        [StringLength(100)]
        public string NombreFormulario { get; set; }
        [Key]
        [StringLength(100)]
        public string NombreObjeto { get; set; }
        [Required]
        [StringLength(1)]
        public string EsGrid { get; set; }
        [StringLength(100)]
        public string ValorDefecto { get; set; }

        [ForeignKey("CodigoSistema,NombreFormulario")]
        [InverseProperty("IdObjetos")]
        public virtual IdFormularios IdFormularios { get; set; }
        [InverseProperty("IdObjetos")]
        public virtual ICollection<IdCamposGrid> IdCamposGrid { get; set; }
        [InverseProperty("IdObjetos")]
        public virtual ICollection<IdObjetosIdiomas> IdObjetosIdiomas { get; set; }
    }
}
