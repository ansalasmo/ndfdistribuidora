using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("ID_CamposGrid")]
    public partial class IdCamposGrid
    {
        public IdCamposGrid()
        {
            IdHeaderGrid = new HashSet<IdHeaderGrid>();
        }

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
        public int Posicion { get; set; }
        [Required]
        [StringLength(30)]
        public string Alignment { get; set; }
        public int Width { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoCampo { get; set; }
        [Required]
        [StringLength(10)]
        public string Format { get; set; }
        [Required]
        [StringLength(1)]
        public string FalseValue { get; set; }
        [Required]
        [StringLength(1)]
        public string TrueValue { get; set; }

        [ForeignKey("CodigoSistema,NombreFormulario,NombreObjeto")]
        [InverseProperty("IdCamposGrid")]
        public virtual IdObjetos IdObjetos { get; set; }
        [InverseProperty("IdCamposGrid")]
        public virtual ICollection<IdHeaderGrid> IdHeaderGrid { get; set; }
    }
}
