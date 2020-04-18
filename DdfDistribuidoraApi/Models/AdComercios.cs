using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("AD_Comercios")]
    public partial class AdComercios
    {
        [Key]
        [Column("IDComercio")]
        public int Idcomercio { get; set; }
        [Required]
        [StringLength(250)]
        public string NombreComercio { get; set; }
        [Required]
        [StringLength(1)]
        public string AplicaCashBack { get; set; }
        public int CodigoPais { get; set; }
        public int CodigoProvincia { get; set; }
        public int CodigoCanton { get; set; }
        public int CodigoDistrito { get; set; }
        [Required]
        [StringLength(20)]
        public string CedulaAgente { get; set; }
        [Required]
        [StringLength(50)]
        public string Telefonos { get; set; }
        [Required]
        [StringLength(255)]
        public string NombrePropietario { get; set; }
        [Required]
        [StringLength(20)]
        public string CedulaPropietario { get; set; }
        [Required]
        [StringLength(100)]
        public string Correo { get; set; }
        [Required]
        [StringLength(17)]
        public string CuentaCliente { get; set; }
        [Required]
        [StringLength(255)]
        public string Direccion { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [StringLength(50)]
        public string BaseDatos { get; set; }
        public int? DiaCobro { get; set; }
        [StringLength(1)]
        public string ControlExpress { get; set; }
        [StringLength(1)]
        public string AplicacionWeb { get; set; }
        [Column("IDPadre")]
        [StringLength(50)]
        public string Idpadre { get; set; }
        public int? Nivel { get; set; }
        [StringLength(1)]
        public string Bloqueado { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Mensualidad { get; set; }
    }
}
