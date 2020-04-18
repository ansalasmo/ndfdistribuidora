using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_Impresoras")]
    public partial class FacImpresoras
    {
        [Key]
        public int CodigoLocal { get; set; }
        [Key]
        [StringLength(1)]
        public string Area { get; set; }
        [Key]
        [StringLength(1)]
        public string Cocina { get; set; }
        [Key]
        [Column("NombrePC")]
        [StringLength(50)]
        public string NombrePc { get; set; }
        [Key]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Key]
        [StringLength(1)]
        public string Estado { get; set; }
    }
}
