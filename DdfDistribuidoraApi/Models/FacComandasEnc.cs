using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_ComandasEnc")]
    public partial class FacComandasEnc
    {
        public FacComandasEnc()
        {
            FacComandasDet = new HashSet<FacComandasDet>();
        }

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
        [Required]
        [StringLength(1)]
        public string Impresa { get; set; }
        [Required]
        [StringLength(1)]
        public string Cocina { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(255)]
        public string NombreCliente { get; set; }
        [StringLength(255)]
        public string Direccion { get; set; }
        [StringLength(20)]
        public string Telefono { get; set; }

        [InverseProperty("FacComandasEnc")]
        public virtual ICollection<FacComandasDet> FacComandasDet { get; set; }
    }
}
