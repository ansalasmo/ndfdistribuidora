using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_DetalleCliente")]
    public partial class FacDetalleCliente
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Latitud { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Longitud { get; set; }
        [Column(TypeName = "image")]
        public byte[] Foto { get; set; }
    }
}
