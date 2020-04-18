using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_Empleados")]
    public partial class FacEmpleados
    {
        public FacEmpleados()
        {
            FacCajasIniciales = new HashSet<FacCajasIniciales>();
            FacCajasIniciales2 = new HashSet<FacCajasIniciales2>();
            FacJornadas = new HashSet<FacJornadas>();
            OrtPlanes = new HashSet<OrtPlanes>();
        }

        [Key]
        [Column("LOGIN")]
        [StringLength(20)]
        public string Login { get; set; }
        [StringLength(1)]
        public string EsCajero { get; set; }
        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(20)]
        public string UsuarioInactiva { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaInactiva { get; set; }
        [StringLength(1)]
        public string AplicarDescuentos { get; set; }
        [StringLength(4)]
        public string Codigo { get; set; }

        [InverseProperty("LoginNavigation")]
        public virtual ICollection<FacCajasIniciales> FacCajasIniciales { get; set; }
        [InverseProperty("LoginNavigation")]
        public virtual ICollection<FacCajasIniciales2> FacCajasIniciales2 { get; set; }
        [InverseProperty("LoginNavigation")]
        public virtual ICollection<FacJornadas> FacJornadas { get; set; }
        [InverseProperty("LoginNavigation")]
        public virtual ICollection<OrtPlanes> OrtPlanes { get; set; }
    }
}
