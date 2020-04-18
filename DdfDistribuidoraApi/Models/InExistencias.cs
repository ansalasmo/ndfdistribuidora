using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("IN_Existencias")]
    public partial class InExistencias
    {
        [Key]
        public int CodigoBodega { get; set; }
        [Key]
        public int CodigoProducto { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Saldo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Minimo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Maximo { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [Required]
        [Column("CBExistencias")]
        [StringLength(13)]
        public string Cbexistencias { get; set; }
    }
}
