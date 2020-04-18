using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_CajasIniciales")]
    public partial class FacCajasIniciales
    {
        public FacCajasIniciales()
        {
            FacFacturas = new HashSet<FacFacturas>();
            FacRetirosCaja = new HashSet<FacRetirosCaja>();
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
        [InverseProperty(nameof(FacEmpleados.FacCajasIniciales))]
        public virtual FacEmpleados LoginNavigation { get; set; }
        [InverseProperty("FacCajasIniciales")]
        public virtual FacCierres FacCierres { get; set; }
        [InverseProperty("FacCajasIniciales")]
        public virtual ICollection<FacFacturas> FacFacturas { get; set; }
        [InverseProperty("FacCajasIniciales")]
        public virtual ICollection<FacRetirosCaja> FacRetirosCaja { get; set; }
    }
}
