using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("ID_ObjetosIdiomas")]
    public partial class IdObjetosIdiomas
    {
        [Key]
        public int CodigoSistema { get; set; }
        [Key]
        [StringLength(100)]
        public string NombreFormulario { get; set; }
        [Key]
        [StringLength(100)]
        public string NombreObjeto { get; set; }
        [Key]
        [StringLength(3)]
        public string CodigoIdioma { get; set; }
        [Required]
        [StringLength(50)]
        public string Valor { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }

        [ForeignKey(nameof(CodigoIdioma))]
        [InverseProperty(nameof(IdIdiomas.IdObjetosIdiomas))]
        public virtual IdIdiomas CodigoIdiomaNavigation { get; set; }
        [ForeignKey("CodigoSistema,NombreFormulario,NombreObjeto")]
        [InverseProperty("IdObjetosIdiomas")]
        public virtual IdObjetos IdObjetos { get; set; }
    }
}
