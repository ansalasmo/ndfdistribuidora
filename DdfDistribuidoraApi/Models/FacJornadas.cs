using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_Jornadas")]
    public partial class FacJornadas
    {
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Mes { get; set; }
        [Key]
        public int Dia { get; set; }
        [Key]
        public int CodigoLocal { get; set; }
        [Key]
        [StringLength(1)]
        public string Area { get; set; }
        [Key]
        [StringLength(20)]
        public string Login { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CajaInicial { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(20)]
        public string UsuarioAprueba { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAprueba { get; set; }
        [StringLength(20)]
        public string UsuarioCierra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaCierra { get; set; }

        [ForeignKey(nameof(CodigoLocal))]
        [InverseProperty(nameof(FacLocales.FacJornadas))]
        public virtual FacLocales CodigoLocalNavigation { get; set; }
        [ForeignKey(nameof(Login))]
        [InverseProperty(nameof(FacEmpleados.FacJornadas))]
        public virtual FacEmpleados LoginNavigation { get; set; }
    }
}
