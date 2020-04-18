using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_Parametros")]
    public partial class RhParametros
    {
        [Key]
        public int ConsecutivoParam { get; set; }
        [Required]
        [StringLength(2)]
        public string InicioHoraRoja { get; set; }
        [Required]
        [StringLength(1)]
        public string Redondear { get; set; }
        [Column("ExtrasAPartirDe")]
        public int ExtrasApartirDe { get; set; }
        [Required]
        [StringLength(1)]
        public string FormaExtras { get; set; }
        [Required]
        [StringLength(255)]
        public string LeyendaComprobante { get; set; }
        [Required]
        [StringLength(50)]
        public string Correo { get; set; }
        [Required]
        [StringLength(50)]
        public string PassCorreo { get; set; }
        public int CodigoPais { get; set; }
        public int? HoraInicio { get; set; }
        public int? HoraFinal { get; set; }
        public int? MinutosRebajarAlmuerzo { get; set; }
    }
}
