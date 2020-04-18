using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("ObjetosBD")]
    public partial class ObjetosBd
    {
        public ObjetosBd()
        {
            CamposGrid = new HashSet<CamposGrid>();
            RepParametrosObjetosDb = new HashSet<RepParametrosObjetosDb>();
            RepUsuariosReportes = new HashSet<RepUsuariosReportes>();
        }

        [Key]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoObjeto { get; set; }
        [Required]
        [StringLength(100)]
        public string DescripcionUsuario { get; set; }
        public int? CodigoSistema { get; set; }
        [StringLength(30)]
        public string BaseDatos { get; set; }
        [StringLength(100)]
        public string NombreArchivo { get; set; }

        [InverseProperty("NombreNavigation")]
        public virtual ICollection<CamposGrid> CamposGrid { get; set; }
        [InverseProperty("NombreNavigation")]
        public virtual ICollection<RepParametrosObjetosDb> RepParametrosObjetosDb { get; set; }
        [InverseProperty("NombreNavigation")]
        public virtual ICollection<RepUsuariosReportes> RepUsuariosReportes { get; set; }
    }
}
