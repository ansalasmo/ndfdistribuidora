using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_Asientos")]
    public partial class CgAsientos
    {
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Numero { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? SubPeriodo { get; set; }
        [StringLength(4)]
        public string CodigoSistema { get; set; }
        [StringLength(4)]
        public string CodigoConcepto { get; set; }
        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaContable { get; set; }
        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioAsignado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaAsignacion { get; set; }
        [StringLength(20)]
        public string UsuarioFinaliza { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaFinaliza { get; set; }
        [StringLength(20)]
        public string UsuarioMayoriza { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaMayoriza { get; set; }
        [StringLength(20)]
        public string UsuarioAnula { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAnula { get; set; }
        [StringLength(255)]
        public string MotivoAnulacion { get; set; }
        [StringLength(500)]
        public string Observacion { get; set; }
        [Column("AjustadoPR")]
        [StringLength(1)]
        public string AjustadoPr { get; set; }
        [StringLength(20)]
        public string UsuarioDesMayoriza { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaDesMayoriza { get; set; }
    }
}
