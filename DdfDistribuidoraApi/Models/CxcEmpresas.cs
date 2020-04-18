using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CXC_Empresas")]
    public partial class CxcEmpresas
    {
        public CxcEmpresas()
        {
            CxcClientes = new HashSet<CxcClientes>();
        }

        [Key]
        [StringLength(20)]
        public string CedulaEmpresa { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistro { get; set; }

        [InverseProperty("CedulaEmpresaNavigation")]
        public virtual ICollection<CxcClientes> CxcClientes { get; set; }
    }
}
