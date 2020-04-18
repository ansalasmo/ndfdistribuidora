using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CXC_ContraPartidas")]
    public partial class CxcContraPartidas
    {
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Numero { get; set; }
        [Key]
        public int Linea { get; set; }
        public int CodigoContraPartida { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Monto { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistro { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }

        [ForeignKey(nameof(CodigoContraPartida))]
        [InverseProperty(nameof(CxcTiposContraPartidas.CxcContraPartidas))]
        public virtual CxcTiposContraPartidas CodigoContraPartidaNavigation { get; set; }
    }
}
