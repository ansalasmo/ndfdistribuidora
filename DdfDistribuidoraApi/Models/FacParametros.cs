using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_Parametros")]
    public partial class FacParametros
    {
        [Key]
        [Column("IDComercio")]
        public int Idcomercio { get; set; }
        [Required]
        [StringLength(250)]
        public string NombreComercio { get; set; }
        [Required]
        [StringLength(20)]
        public string Cedula { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PorcentajeCashback { get; set; }
        [Required]
        [StringLength(1)]
        public string TipoCedula { get; set; }
        [Required]
        [StringLength(20)]
        public string Telefonos { get; set; }
        [Required]
        [StringLength(100)]
        public string Direccion { get; set; }
        [Required]
        [StringLength(100)]
        public string FacturaResumida { get; set; }
        [StringLength(1)]
        public string ImpresionCocina { get; set; }
        [StringLength(100)]
        public string NombreTributacion { get; set; }
        [StringLength(1)]
        public string Costos { get; set; }
        [StringLength(1)]
        public string PagoHuella { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ComisionTarjeta { get; set; }
        [Column("ComisionPE", TypeName = "decimal(18, 2)")]
        public decimal? ComisionPe { get; set; }
        [Column("IDPadre")]
        [StringLength(50)]
        public string Idpadre { get; set; }
        public int? Nivel { get; set; }
        [StringLength(1)]
        public string SeparacionPedidos { get; set; }
        [StringLength(1)]
        public string ControlMeseros { get; set; }
        [StringLength(1)]
        public string RespaldoNube { get; set; }
        [StringLength(1)]
        public string RedImpresoras { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TipoCambio { get; set; }
        [StringLength(8)]
        public string ControlSillas { get; set; }
        [StringLength(1)]
        public string ControlM { get; set; }
        [StringLength(1)]
        public string Simbolo { get; set; }
        [StringLength(255)]
        public string Direccion2 { get; set; }
        [StringLength(100)]
        public string CorreoEmpresa { get; set; }
        [StringLength(100)]
        public string CorreoPass { get; set; }
        [StringLength(100)]
        public string CorreoEnviar { get; set; }
        [StringLength(100)]
        public string ImprimirDetalle { get; set; }
        [StringLength(1)]
        public string MiPueblo { get; set; }
        [StringLength(1)]
        public string UsarAlertaPrevia { get; set; }
        [Column("IV", TypeName = "decimal(18, 2)")]
        public decimal? Iv { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Servicio { get; set; }
        [StringLength(1)]
        public string CopiaFactura { get; set; }
        [StringLength(1)]
        public string CopiaComanda { get; set; }
        [StringLength(3)]
        public string NumeroLocal { get; set; }
        [StringLength(2)]
        public string Provincia { get; set; }
        [StringLength(2)]
        public string Canton { get; set; }
        [StringLength(2)]
        public string Distrito { get; set; }
        [Column("UsuarioNABY")]
        [StringLength(100)]
        public string UsuarioNaby { get; set; }
        [Column("PasswordNABY")]
        [StringLength(100)]
        public string PasswordNaby { get; set; }
        [StringLength(1)]
        public string AmbienteHacienda { get; set; }
        [StringLength(15)]
        public string ArchivoFirma { get; set; }
        [StringLength(4)]
        public string Pin { get; set; }
        public byte[] Logo { get; set; }
        [StringLength(3)]
        public string TipoImagen { get; set; }
        [StringLength(100)]
        public string CorreoRecepcion { get; set; }
        [StringLength(100)]
        public string PassCorreoRecepcion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ControlApp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaInventarios { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaInicioCorreo { get; set; }
        [StringLength(6)]
        public string ActividadComercial { get; set; }
    }
}
