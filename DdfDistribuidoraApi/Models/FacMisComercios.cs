using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_MisComercios")]
    public partial class FacMisComercios
    {
        [Key]
        [Column("IDComercio")]
        public int Idcomercio { get; set; }
        [Required]
        [StringLength(255)]
        public string NombreComercio { get; set; }
        [Required]
        [StringLength(20)]
        public string BaseDatos { get; set; }
    }
}
