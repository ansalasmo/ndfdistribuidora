using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("ID_Formularios")]
    public partial class IdFormularios
    {
        public IdFormularios()
        {
            IdObjetos = new HashSet<IdObjetos>();
        }

        [Key]
        public int CodigoSistema { get; set; }
        [Key]
        [StringLength(100)]
        public string NombreFormulario { get; set; }

        [ForeignKey(nameof(CodigoSistema))]
        [InverseProperty(nameof(SgSistemas.IdFormularios))]
        public virtual SgSistemas CodigoSistemaNavigation { get; set; }
        [InverseProperty("IdFormularios")]
        public virtual ICollection<IdObjetos> IdObjetos { get; set; }
    }
}
