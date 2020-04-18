using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("SG_Usuarios")]
    public partial class SgUsuarios
    {
        public SgUsuarios()
        {
            RepUsuariosReportes = new HashSet<RepUsuariosReportes>();
        }

        [Key]
        [StringLength(20)]
        public string Cedula { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string PrimerApellido { get; set; }
        [Required]
        [StringLength(50)]
        public string SegundoApellido { get; set; }
        [Required]
        [StringLength(1)]
        public string EstadoUsuario { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(10)]
        public string Verifica { get; set; }
        [StringLength(1)]
        public string Cambiar { get; set; }
        [StringLength(1)]
        public string ModificarPrecios { get; set; }
        [StringLength(3)]
        public string CodigoIdioma { get; set; }

        [InverseProperty("LoginNavigation")]
        public virtual ICollection<RepUsuariosReportes> RepUsuariosReportes { get; set; }
    }
}
