﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("MCT_CargaMarcas")]
    public partial class MctCargaMarcas
    {
        public int Periodo { get; set; }
        public int CodigoEmpleado { get; set; }
        public int Consecutivo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoRegistro { get; set; }
        [Required]
        [StringLength(1)]
        public string Modificado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaOriginal { get; set; }
        [Required]
        [StringLength(255)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        public int CodigoPrograma { get; set; }
        [Column("CodigoUE")]
        public int CodigoUe { get; set; }
        [StringLength(20)]
        public string UsuarioModifica { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [StringLength(1)]
        public string TipoAlmuerzo { get; set; }
        public int? PeriodoPlanilla { get; set; }
        public int? NumeroPlanilla { get; set; }
    }
}
