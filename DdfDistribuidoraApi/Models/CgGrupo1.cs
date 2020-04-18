using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("CG_Grupo1")]
    public partial class CgGrupo1
    {
        [Key]
        public int CodigoReporte { get; set; }
        [Key]
        public int GrupoUno { get; set; }
        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }
        [StringLength(255)]
        public string Descripcion { get; set; }
        [StringLength(1)]
        public string MostrarDescripcion { get; set; }
        [StringLength(255)]
        public string PieUno { get; set; }
        [StringLength(1)]
        public string MostrarEncabezadoUno { get; set; }
        [StringLength(1)]
        public string MostrarPieUno { get; set; }
        public int? CodigoEmpresa { get; set; }
        [StringLength(3)]
        public string Nota1 { get; set; }
    }
}
