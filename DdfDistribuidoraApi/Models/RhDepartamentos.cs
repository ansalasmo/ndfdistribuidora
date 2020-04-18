using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_Departamentos")]
    public partial class RhDepartamentos
    {
        public int CodigoPrograma { get; set; }
        public int CodigoDepartamento { get; set; }
        [Required]
        [StringLength(50)]
        public string NombreDepartamento { get; set; }
    }
}
