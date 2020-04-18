using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("REP_UsuariosReportes")]
    public partial class RepUsuariosReportes
    {
        [Key]
        [StringLength(20)]
        public string Login { get; set; }
        [Key]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }

        [ForeignKey(nameof(Login))]
        [InverseProperty(nameof(SgUsuarios.RepUsuariosReportes))]
        public virtual SgUsuarios LoginNavigation { get; set; }
        [ForeignKey(nameof(Nombre))]
        [InverseProperty(nameof(ObjetosBd.RepUsuariosReportes))]
        public virtual ObjetosBd NombreNavigation { get; set; }
    }
}
