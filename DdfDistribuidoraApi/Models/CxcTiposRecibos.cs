using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CXC_TiposRecibos")]
    public partial class CxcTiposRecibos
    {
        public CxcTiposRecibos()
        {
            CxcRecibos = new HashSet<CxcRecibos>();
        }

        [Key]
        public int CodigoTipoRecibo { get; set; }
        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(20)]
        public string Cuenta { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistro { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [StringLength(1)]
        public string GeneraAsiento { get; set; }

        [InverseProperty("CodigoTipoReciboNavigation")]
        public virtual ICollection<CxcRecibos> CxcRecibos { get; set; }
    }
}
