using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("BIN_PersonaFotos")]
    public partial class BinPersonaFotos
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("foto", TypeName = "image")]
        public byte[] Foto { get; set; }
        [Required]
        [Column("correo")]
        [StringLength(100)]
        public string Correo { get; set; }
        [Required]
        [Column("id_especial")]
        [StringLength(50)]
        public string IdEspecial { get; set; }
    }
}
