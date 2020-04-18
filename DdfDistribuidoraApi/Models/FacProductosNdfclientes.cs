using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_ProductosNDFClientes")]
    public partial class FacProductosNdfclientes
    {
        [Key]
        public int CodigoLocal { get; set; }
        [Key]
        public int CodigoProducto { get; set; }
        [Key]
        [Column("CodigoProductoNDF")]
        public int CodigoProductoNdf { get; set; }
    }
}
