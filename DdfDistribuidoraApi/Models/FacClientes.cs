using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_Clientes")]
    public partial class FacClientes
    {
        [Key]
        [StringLength(255)]
        public string Telefono { get; set; }
        [Column("IDCliente")]
        [StringLength(50)]
        public string Idcliente { get; set; }
        [StringLength(100)]
        public string NombreCliente { get; set; }
        [StringLength(255)]
        public string Direccion { get; set; }
    }
}
