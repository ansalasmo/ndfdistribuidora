using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("SG_Bitacora")]
    public partial class SgBitacora
    {
        [Key]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Numero { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string TextoSql { get; set; }
        [StringLength(1)]
        public string Enviado { get; set; }
        [StringLength(20)]
        public string UsuarioEnvia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaEnvia { get; set; }
        [StringLength(255)]
        public string MotivoError { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? NumeroFactura { get; set; }
    }
}
