using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("ORT_Planes")]
    public partial class OrtPlanes
    {
        [Key]
        [Column("LOGIN")]
        [StringLength(20)]
        public string Login { get; set; }
        [Key]
        public int NumeroPlan { get; set; }
        [StringLength(100)]
        public string NombrePlan { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Estudio { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Colocacion { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Prima { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Mensualidad { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        public int? Meses { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistra { get; set; }

        [ForeignKey(nameof(Login))]
        [InverseProperty(nameof(FacEmpleados.OrtPlanes))]
        public virtual FacEmpleados LoginNavigation { get; set; }
    }
}
