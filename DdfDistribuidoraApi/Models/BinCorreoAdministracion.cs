using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("BIN_CorreoAdministracion")]
    public partial class BinCorreoAdministracion
    {
        [Key]
        [Column("id_correo")]
        public int IdCorreo { get; set; }
        [Required]
        [Column("correo")]
        [StringLength(50)]
        public string Correo { get; set; }
        [Required]
        [Column("contrasenia")]
        [StringLength(50)]
        public string Contrasenia { get; set; }
        [Required]
        [Column("estado")]
        [StringLength(30)]
        public string Estado { get; set; }
    }
}
