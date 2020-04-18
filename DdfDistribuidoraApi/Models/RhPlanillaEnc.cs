using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_PlanillaEnc")]
    public partial class RhPlanillaEnc
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("usuario")]
        [StringLength(100)]
        public string Usuario { get; set; }
        [Column("password")]
        [StringLength(100)]
        public string Password { get; set; }
        [Column("clave")]
        [StringLength(50)]
        public string Clave { get; set; }
        [Column("tipo_documento")]
        [StringLength(2)]
        public string TipoDocumento { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("consecutivo_origen")]
        [StringLength(10)]
        public string ConsecutivoOrigen { get; set; }
        [Column("consecutivo_incompleto")]
        [StringLength(8)]
        public string ConsecutivoIncompleto { get; set; }
        [Column("consecutivo_completo")]
        [StringLength(20)]
        public string ConsecutivoCompleto { get; set; }
        [Column("emisor_nombre")]
        [StringLength(80)]
        public string EmisorNombre { get; set; }
        [Column("emisor_nom_comercial")]
        [StringLength(80)]
        public string EmisorNomComercial { get; set; }
        [Column("emisor_tipo")]
        [StringLength(2)]
        public string EmisorTipo { get; set; }
        [Column("emisor_identificacion")]
        [StringLength(12)]
        public string EmisorIdentificacion { get; set; }
        [Column("emisor_provincia")]
        [StringLength(1)]
        public string EmisorProvincia { get; set; }
        [Column("emisor_canton")]
        [StringLength(2)]
        public string EmisorCanton { get; set; }
        [Column("emisor_distrito")]
        [StringLength(2)]
        public string EmisorDistrito { get; set; }
        [Column("emisor_direccion")]
        [StringLength(160)]
        public string EmisorDireccion { get; set; }
        [Column("emisor_telefono")]
        [StringLength(8)]
        public string EmisorTelefono { get; set; }
        [Column("emisor_fax")]
        [StringLength(8)]
        public string EmisorFax { get; set; }
        [Column("emisor_email")]
        [StringLength(100)]
        public string EmisorEmail { get; set; }
        [Column("receptor_nombre")]
        [StringLength(80)]
        public string ReceptorNombre { get; set; }
        [Column("receptor_tipo")]
        [StringLength(2)]
        public string ReceptorTipo { get; set; }
        [Column("receptor_identificacion")]
        [StringLength(12)]
        public string ReceptorIdentificacion { get; set; }
        [Column("pasaporte")]
        [StringLength(20)]
        public string Pasaporte { get; set; }
        [Column("receptor_provincia")]
        [StringLength(1)]
        public string ReceptorProvincia { get; set; }
        [Column("receptor_canton")]
        [StringLength(2)]
        public string ReceptorCanton { get; set; }
        [Column("receptor_distrito")]
        [StringLength(2)]
        public string ReceptorDistrito { get; set; }
        [Column("receptor_direccion")]
        [StringLength(160)]
        public string ReceptorDireccion { get; set; }
        [Column("receptor_telefono")]
        [StringLength(8)]
        public string ReceptorTelefono { get; set; }
        [Column("receptor_fax")]
        [StringLength(8)]
        public string ReceptorFax { get; set; }
        [Column("receptor_email")]
        [StringLength(100)]
        public string ReceptorEmail { get; set; }
        [Column("condicion_venta")]
        [StringLength(2)]
        public string CondicionVenta { get; set; }
        [Column("plazo_credito")]
        public int? PlazoCredito { get; set; }
        [Column("medio_pago1")]
        [StringLength(2)]
        public string MedioPago1 { get; set; }
        [Column("medio_pago2")]
        [StringLength(2)]
        public string MedioPago2 { get; set; }
        [Column("medio_pago3")]
        [StringLength(2)]
        public string MedioPago3 { get; set; }
        [Column("medio_pago4")]
        [StringLength(2)]
        public string MedioPago4 { get; set; }
        [Column("moneda")]
        [StringLength(3)]
        public string Moneda { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(18, 5)")]
        public decimal? TipoCambio { get; set; }
        [Column("ref_tipo_doc")]
        [StringLength(2)]
        public string RefTipoDoc { get; set; }
        [Column("ref_clave")]
        [StringLength(50)]
        public string RefClave { get; set; }
        [Column("ref_fecha", TypeName = "datetime")]
        public DateTime? RefFecha { get; set; }
        [Column("ref_codigo")]
        [StringLength(2)]
        public string RefCodigo { get; set; }
        [Column("ref_razon")]
        [StringLength(180)]
        public string RefRazon { get; set; }
        [StringLength(1000)]
        public string Otros { get; set; }
        [Column("xml")]
        public string Xml { get; set; }
        [Column("estado_envio")]
        [StringLength(1)]
        public string EstadoEnvio { get; set; }
        [Column("mensaje_envio")]
        [StringLength(500)]
        public string MensajeEnvio { get; set; }
        [Column("estado_hacienda")]
        [StringLength(1)]
        public string EstadoHacienda { get; set; }
        [Column("mensaje_hacienda")]
        [StringLength(500)]
        public string MensajeHacienda { get; set; }
        [Column("receptor_incluir")]
        public int? ReceptorIncluir { get; set; }
        [Column("ubicacion_incluir")]
        public int? UbicacionIncluir { get; set; }
        [Column("email_adicional")]
        [StringLength(100)]
        public string EmailAdicional { get; set; }
        [StringLength(100)]
        public string CorreosAdicionales { get; set; }
        [Column("correos_adicionales")]
        [StringLength(100)]
        public string CorreosAdicionales1 { get; set; }
        [Column("FacturaXML")]
        public byte[] FacturaXml { get; set; }
        [Column("FacturaPDF")]
        public byte[] FacturaPdf { get; set; }
        [Column("FacturaXMLHacienda")]
        public byte[] FacturaXmlhacienda { get; set; }
    }
}
