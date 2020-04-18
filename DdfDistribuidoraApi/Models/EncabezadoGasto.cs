using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    public partial class EncabezadoGasto
    {
        [Key]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal IdGasto { get; set; }
        [StringLength(50)]
        public string Clave { get; set; }
        [StringLength(12)]
        public string NumeroCedulaEmisor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaEmisionDoc { get; set; }
        [StringLength(1)]
        public string Mensaje { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? MontoTotalImpuesto { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? TotalFactura { get; set; }
        [StringLength(12)]
        public string NumeroCedulaReceptor { get; set; }
        [StringLength(20)]
        public string NumeroConsecutivoReceptor { get; set; }
        [StringLength(255)]
        public string MensajeEnvio { get; set; }
        [StringLength(255)]
        public string MensajeHacienda { get; set; }
        [StringLength(2)]
        public string EmisorTipo { get; set; }
        [StringLength(2)]
        public string ReceptorTipo { get; set; }
        public int? CantidadEnvios { get; set; }
        [StringLength(6)]
        public string ActividadComercial { get; set; }
        [StringLength(1)]
        public string EnviadoNube { get; set; }
    }
}
