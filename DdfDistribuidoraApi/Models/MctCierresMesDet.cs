using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("MCT_CierresMesDet")]
    public partial class MctCierresMesDet
    {
        public int Periodo { get; set; }
        public int Mes { get; set; }
        public int CodigoEmpleado { get; set; }
        public int CodigoPrograma { get; set; }
        [Column("CodigoUE")]
        public int CodigoUe { get; set; }
        public int MinutosRebajar { get; set; }
        public int CantidadTardias { get; set; }
        public int CantidadAnticipadas { get; set; }
        public int CantidadSin { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
