using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_ControlObjetos")]
    public partial class FacControlObjetos
    {
        [Column("IDObjeto")]
        [StringLength(10)]
        public string Idobjeto { get; set; }
        [Required]
        [StringLength(1)]
        public string Area { get; set; }
        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }
    }
}
