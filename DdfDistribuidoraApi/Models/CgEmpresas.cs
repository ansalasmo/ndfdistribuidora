using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_Empresas")]
    public partial class CgEmpresas
    {
        [Key]
        public int CodigoEmpresa { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        public int Periodo { get; set; }
        public int SubPeriodo { get; set; }
        [StringLength(20)]
        public string CuentaCierre { get; set; }
        public short Niveles { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
    }
}
