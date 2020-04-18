using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_Acciones")]
    public partial class RhAcciones
    {
        [Key]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal NumeroAccion { get; set; }
        public int CodigoEmpleado { get; set; }
        [StringLength(1)]
        public string TipoAccion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaDesde { get; set; }
        [StringLength(1)]
        public string AplicaFechaHasta { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaHasta { get; set; }
        [StringLength(255)]
        public string Documento { get; set; }
        [StringLength(255)]
        public string Observaciones { get; set; }
        public int? Dias { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistra { get; set; }
        [StringLength(20)]
        public string UsuarioAprueba { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAprueba { get; set; }
        [StringLength(20)]
        public string UsuarioAnula { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAnula { get; set; }

        [ForeignKey(nameof(CodigoEmpleado))]
        [InverseProperty(nameof(RhEmpleados.RhAcciones))]
        public virtual RhEmpleados CodigoEmpleadoNavigation { get; set; }
    }
}
