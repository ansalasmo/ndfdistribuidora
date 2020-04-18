using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CT_Citas")]
    public partial class CtCitas
    {
        public CtCitas()
        {
            CtCitasAcciones = new HashSet<CtCitasAcciones>();
        }

        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Mes { get; set; }
        [Key]
        public int Dia { get; set; }
        [Key]
        public int NumeroCita { get; set; }
        public int? CodigoCliente { get; set; }
        public int? CodigoZona { get; set; }
        public int? DiaSemana { get; set; }
        public int? CodigoHorario { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        public int? Dias { get; set; }
        public int? PeriodoRef { get; set; }
        public int? MesRef { get; set; }
        public int? DiaRef { get; set; }
        public int? NumeroCitaRef { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaDesde { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaHasta { get; set; }
        [StringLength(15)]
        public string Placa { get; set; }
        public int? Personas { get; set; }
        public int? CodigoConcepto { get; set; }
        public int? Llaves { get; set; }
        [StringLength(1)]
        public string Tarifa { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? NumeroFactura { get; set; }

        [ForeignKey(nameof(CodigoCliente))]
        [InverseProperty(nameof(CtClientes.CtCitas))]
        public virtual CtClientes CodigoClienteNavigation { get; set; }
        [InverseProperty("CtCitas")]
        public virtual ICollection<CtCitasAcciones> CtCitasAcciones { get; set; }
    }
}
