using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CXC_TiposContraPartidas")]
    public partial class CxcTiposContraPartidas
    {
        public CxcTiposContraPartidas()
        {
            CxcContraPartidas = new HashSet<CxcContraPartidas>();
        }

        [Key]
        public int CodigoContraPartida { get; set; }
        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(20)]
        public string Cuenta { get; set; }
        public int? CodigoMovimiento { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(1)]
        public string Impuestos { get; set; }

        [InverseProperty("CodigoContraPartidaNavigation")]
        public virtual ICollection<CxcContraPartidas> CxcContraPartidas { get; set; }
    }
}
