using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_ComandasDet")]
    public partial class FacComandasDet
    {
        [Key]
        public int Periodo { get; set; }
        [Key]
        public int Mes { get; set; }
        [Key]
        public int Dia { get; set; }
        [Key]
        public int NumeroPedido { get; set; }
        [Key]
        public int Consecutivo { get; set; }
        [Key]
        public int ConsecutivoDet { get; set; }
        [Required]
        [StringLength(10)]
        public string Linea { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Descripcion { get; set; }

        [ForeignKey("Periodo,Mes,Dia,NumeroPedido,Consecutivo")]
        [InverseProperty("FacComandasDet")]
        public virtual FacComandasEnc FacComandasEnc { get; set; }
    }
}
