using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_RetirosCajaClientes")]
    public partial class FacRetirosCajaClientes
    {
        [Key]
        public int CodigoLocal { get; set; }
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Mes { get; set; }
        [Key]
        public int Dia { get; set; }
        [Key]
        [StringLength(20)]
        public string Login { get; set; }
        [Key]
        public int NumeroRetiro { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Monto { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(255)]
        public string Motivo { get; set; }
        public int? CodigoConcepto { get; set; }
        public int? CodigoEmpleado { get; set; }
        public int? PeriodoPlanilla { get; set; }
        public int? NumeroPlanilla { get; set; }
        [StringLength(1)]
        public string EnviadoNube { get; set; }
    }
}
