using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_Feriados")]
    public partial class RhFeriados
    {
        public int? CodigoFeriado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaFeriado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaAplica { get; set; }
        [StringLength(255)]
        public string Descripcion { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistra { get; set; }
    }
}
