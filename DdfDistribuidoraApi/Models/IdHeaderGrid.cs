using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("ID_HeaderGrid")]
    public partial class IdHeaderGrid
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
        [StringLength(30)]
        public string MappingName { get; set; }
        [Key]
        [StringLength(3)]
        public string CodigoIdioma { get; set; }
        [Required]
        [StringLength(50)]
        public string Valor { get; set; }

        [ForeignKey(nameof(CodigoIdioma))]
        [InverseProperty(nameof(IdIdiomas.IdHeaderGrid))]
        public virtual IdIdiomas CodigoIdiomaNavigation { get; set; }
        [ForeignKey("CodigoSistema,NombreFormulario,NombreObjeto,MappingName")]
        [InverseProperty("IdHeaderGrid")]
        public virtual IdCamposGrid IdCamposGrid { get; set; }
    }
}
