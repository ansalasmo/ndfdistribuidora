using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CT_CitasAcciones")]
    public partial class CtCitasAcciones
    {
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Mes { get; set; }
        [Key]
        public int Dia { get; set; }
        [Key]
        public int NumeroCita { get; set; }
        [Key]
        public int CodigoAccion { get; set; }
        [StringLength(255)]
        public string Observacion { get; set; }
        [StringLength(255)]
        public string Documento { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistra { get; set; }

        [ForeignKey(nameof(CodigoAccion))]
        [InverseProperty(nameof(CtTiposAcciones.CtCitasAcciones))]
        public virtual CtTiposAcciones CodigoAccionNavigation { get; set; }
        [ForeignKey("Periodo,Mes,Dia,NumeroCita")]
        [InverseProperty("CtCitasAcciones")]
        public virtual CtCitas CtCitas { get; set; }
    }
}
