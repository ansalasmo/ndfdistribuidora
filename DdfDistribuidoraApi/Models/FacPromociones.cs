using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_Promociones")]
    public partial class FacPromociones
    {
        [Key]
        public int NumeroPromocion { get; set; }
        [Required]
        [StringLength(1)]
        public string AplicarDescuento { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Porcentaje { get; set; }
        public int CodigoProducto { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoPromocion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaDesde { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaHasta { get; set; }
        [Required]
        [StringLength(1)]
        public string Domingo { get; set; }
        [Required]
        [StringLength(1)]
        public string Lunes { get; set; }
        [Required]
        [StringLength(1)]
        public string Martes { get; set; }
        [Required]
        [StringLength(1)]
        public string Miercoles { get; set; }
        [Required]
        [StringLength(1)]
        public string Jueves { get; set; }
        [Required]
        [StringLength(1)]
        public string Viernes { get; set; }
        [Required]
        [StringLength(1)]
        public string Sabado { get; set; }
        [Required]
        [StringLength(1)]
        public string RestringeHoras { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HoraDesde { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HoraHasta { get; set; }
        [Required]
        [StringLength(1)]
        public string AplicarPuntos { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
    }
}
