using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CT_Clientes")]
    public partial class CtClientes
    {
        public CtClientes()
        {
            CtCitas = new HashSet<CtCitas>();
        }

        [Key]
        public int CodigoCliente { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(20)]
        public string Telefono { get; set; }
        [Required]
        [Column("IDCliente")]
        [StringLength(50)]
        public string Idcliente { get; set; }
        [Required]
        [StringLength(255)]
        public string Direccion { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        public int CodigoTipoZona { get; set; }
        [StringLength(20)]
        public string TelefonoCasa { get; set; }
        [StringLength(2)]
        public string CodigoPais { get; set; }
        [StringLength(20)]
        public string Identificacion { get; set; }
        [StringLength(1)]
        public string Sexo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaNacimiento { get; set; }
        [StringLength(15)]
        public string Placa { get; set; }

        [InverseProperty("CodigoClienteNavigation")]
        public virtual ICollection<CtCitas> CtCitas { get; set; }
    }
}
