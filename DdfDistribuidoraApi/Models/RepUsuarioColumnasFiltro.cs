using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("REP_UsuarioColumnasFiltro")]
    public partial class RepUsuarioColumnasFiltro
    {
        [Key]
        [StringLength(20)]
        public string Login { get; set; }
        [Key]
        public int NumeroColumna { get; set; }
    }
}
