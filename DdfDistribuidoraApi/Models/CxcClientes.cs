using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CXC_Clientes")]
    public partial class CxcClientes
    {
        public CxcClientes()
        {
            CxcCuentas = new HashSet<CxcCuentas>();
        }

        [Key]
        [StringLength(20)]
        public string CedulaCliente { get; set; }
        [StringLength(20)]
        public string CedulaEmpresa { get; set; }
        [Required]
        [StringLength(150)]
        public string NombreCliente { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoPersona { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoCliente { get; set; }
        [StringLength(100)]
        public string Correo { get; set; }
        public int? CodigoEmpleado { get; set; }
        [StringLength(255)]
        public string Observaciones { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaApertura { get; set; }
        [Column(TypeName = "money")]
        public decimal? LimiteCredito { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistro { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Column("CodigoSIF")]
        public int? CodigoSif { get; set; }
        public int? CodigoClienteAnt { get; set; }
        [StringLength(30)]
        public string Login { get; set; }
        [StringLength(20)]
        public string Telefono { get; set; }
        [StringLength(1)]
        public string EnviadoNube { get; set; }
        [StringLength(2)]
        public string TipoDocumentoExoneracion { get; set; }
        [StringLength(40)]
        public string NumeroDocumento { get; set; }
        [StringLength(160)]
        public string NombreInstitucion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaEmision { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? PorcentajeExoneracion { get; set; }
        [StringLength(6)]
        public string CodigoActividad { get; set; }

        [ForeignKey(nameof(CedulaEmpresa))]
        [InverseProperty(nameof(CxcEmpresas.CxcClientes))]
        public virtual CxcEmpresas CedulaEmpresaNavigation { get; set; }
        [InverseProperty("CedulaClienteNavigation")]
        public virtual ICollection<CxcCuentas> CxcCuentas { get; set; }
    }
}
