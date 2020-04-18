using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_CajasIniciales2")]
    public partial class FacCajasIniciales2
    {
        public FacCajasIniciales2()
        {
            FacRetirosCaja2 = new HashSet<FacRetirosCaja2>();
        }

        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Mes { get; set; }
        [Key]
        public int Dia { get; set; }
        [Key]
        [StringLength(20)]
        public string Login { get; set; }
        [Key]
        public int Consecutivo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MontoCajaInicial { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }

        [ForeignKey(nameof(Login))]
        [InverseProperty(nameof(FacEmpleados.FacCajasIniciales2))]
        public virtual FacEmpleados LoginNavigation { get; set; }
        [InverseProperty("FacCajasIniciales2")]
        public virtual FacCierres2 FacCierres2 { get; set; }
        [InverseProperty("FacCajasIniciales2")]
        public virtual ICollection<FacRetirosCaja2> FacRetirosCaja2 { get; set; }
    }
}
