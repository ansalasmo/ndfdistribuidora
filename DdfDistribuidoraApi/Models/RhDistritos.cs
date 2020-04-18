using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_Distritos")]
    public partial class RhDistritos
    {
        public int CodigoProvincia { get; set; }
        public int CodigoCanton { get; set; }
        public int CodigoDistrito { get; set; }
        [Required]
        [StringLength(150)]
        public string Distrito { get; set; }
        public int? CodigoPais { get; set; }
    }
}
