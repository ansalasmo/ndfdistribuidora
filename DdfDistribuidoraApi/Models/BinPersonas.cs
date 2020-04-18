using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("BIN_Personas")]
    public partial class BinPersonas
    {
        [Key]
        [StringLength(100)]
        public string Correo { get; set; }
        [Required]
        [StringLength(255)]
        public string Password { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        [StringLength(15)]
        public string Genero { get; set; }
        [Required]
        [Column(TypeName = "image")]
        public byte[] Foto { get; set; }
        [Required]
        [Column("QR", TypeName = "image")]
        public byte[] Qr { get; set; }
        [Required]
        [StringLength(100)]
        public string TokenAcceso { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Column("Id_Pais")]
        public int IdPais { get; set; }
        [Required]
        [StringLength(15)]
        public string Estado { get; set; }
    }
}
