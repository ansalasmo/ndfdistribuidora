using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_AsientosDetalle")]
    public partial class CgAsientosDetalle
    {
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Numero { get; set; }
        [Key]
        public int Linea { get; set; }
        public int CodigoEmpresa { get; set; }
        [Required]
        [StringLength(20)]
        public string Cuenta { get; set; }
        public int? CodigoPrograma { get; set; }
        [Column("CodigoUE")]
        public int? CodigoUe { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(4)]
        public string CodigoDocumento { get; set; }
        [Required]
        [StringLength(40)]
        public string Documento { get; set; }
        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Column(TypeName = "money")]
        public decimal Monto { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [StringLength(17)]
        public string CuentaBanco { get; set; }
        [Column(TypeName = "money")]
        public decimal? TipoCambio { get; set; }
        public int? CodigoMoneda { get; set; }
        [Column(TypeName = "money")]
        public decimal? MontoEuros { get; set; }
    }
}
