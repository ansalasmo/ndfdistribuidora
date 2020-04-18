using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("AD_ClientesHuellas")]
    public partial class AdClientesHuellas
    {
        [Key]
        [Column("IDCliente")]
        [StringLength(50)]
        public string Idcliente { get; set; }
        [Key]
        [StringLength(1)]
        public string Mano { get; set; }
        [Key]
        public int Dedo { get; set; }
        [Required]
        public byte[] Imagen { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
