using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    public partial class CamposGrid
    {
        [Key]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Key]
        [StringLength(30)]
        public string MappingName { get; set; }
        public int Posicion { get; set; }
        [Required]
        [StringLength(30)]
        public string Alignment { get; set; }
        [Required]
        [StringLength(50)]
        public string HeaderText { get; set; }
        public int Width { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoCampo { get; set; }
        [Required]
        [StringLength(10)]
        public string Format { get; set; }
        [StringLength(1)]
        public string FalseValue { get; set; }
        [StringLength(1)]
        public string TrueValue { get; set; }
        [StringLength(1)]
        public string PermiteAgrupar { get; set; }
        [StringLength(1)]
        public string PermiteSumar { get; set; }

        [ForeignKey(nameof(Nombre))]
        [InverseProperty(nameof(ObjetosBd.CamposGrid))]
        public virtual ObjetosBd NombreNavigation { get; set; }
    }
}
