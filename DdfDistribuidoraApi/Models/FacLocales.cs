using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_Locales")]
    public partial class FacLocales
    {
        public FacLocales()
        {
            FacJornadas = new HashSet<FacJornadas>();
            FacMapa = new HashSet<FacMapa>();
        }

        [Key]
        public int CodigoLocal { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistra { get; set; }
        [StringLength(1)]
        public string SincronizarDatos { get; set; }
        [Column(TypeName = "decimal(18, 16)")]
        public decimal? Latitud { get; set; }
        [Column(TypeName = "decimal(18, 16)")]
        public decimal? Longitud { get; set; }

        [InverseProperty("CodigoLocalNavigation")]
        public virtual ICollection<FacJornadas> FacJornadas { get; set; }
        [InverseProperty("CodigoLocalNavigation")]
        public virtual ICollection<FacMapa> FacMapa { get; set; }
    }
}
