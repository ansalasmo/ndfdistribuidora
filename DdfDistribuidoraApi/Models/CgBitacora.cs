using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_Bitacora")]
    public partial class CgBitacora
    {
        public int CodigoEvento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaEvento { get; set; }
        public short TipoEvento { get; set; }
        [Required]
        [StringLength(30)]
        public string Login { get; set; }
        [Required]
        [Column("DireccionIP")]
        [StringLength(20)]
        public string DireccionIp { get; set; }
        [Required]
        [StringLength(255)]
        public string DescripcionEvento { get; set; }
        [Required]
        [StringLength(255)]
        public string Referencia1 { get; set; }
        [StringLength(255)]
        public string Referencia2 { get; set; }
        [StringLength(255)]
        public string Referencia3 { get; set; }
        [Required]
        [StringLength(255)]
        public string ReferenciaTecnica { get; set; }
    }
}
