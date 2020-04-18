using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_ActividadesComerciales")]
    public partial class FacActividadesComerciales
    {
        [Key]
        [StringLength(6)]
        public string CodigoActividad { get; set; }
        [Required]
        [StringLength(255)]
        public string Actividad { get; set; }
    }
}
