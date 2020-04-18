using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_Mapa")]
    public partial class FacMapa
    {
        [Key]
        public int CodigoLocal { get; set; }
        [Key]
        [StringLength(1)]
        public string Area { get; set; }
        [Key]
        [StringLength(1)]
        public string TipoObjeto { get; set; }
        [Key]
        public int Numero { get; set; }
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(1)]
        public string TipoArea { get; set; }
        public int? Cajas { get; set; }
        [StringLength(30)]
        public string Descripcion { get; set; }
        public int? TipoHabitacion { get; set; }
        public int? CodigoZona { get; set; }
        [StringLength(1)]
        public string AreaNube { get; set; }

        [ForeignKey(nameof(CodigoLocal))]
        [InverseProperty(nameof(FacLocales.FacMapa))]
        public virtual FacLocales CodigoLocalNavigation { get; set; }
    }
}
