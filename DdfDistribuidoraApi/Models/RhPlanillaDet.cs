using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_PlanillaDet")]
    public partial class RhPlanillaDet
    {
        [Column("id_encabezado")]
        public int IdEncabezado { get; set; }
        [Column("clave")]
        [StringLength(50)]
        public string Clave { get; set; }
        [Column("numero_linea")]
        public int? NumeroLinea { get; set; }
        [Column("tipo_cod_producto")]
        [StringLength(2)]
        public string TipoCodProducto { get; set; }
        [Column("codigo_producto")]
        [StringLength(20)]
        public string CodigoProducto { get; set; }
        [Column("servicio")]
        public int? Servicio { get; set; }
        [Column("cantidad", TypeName = "decimal(16, 3)")]
        public decimal? Cantidad { get; set; }
        [Column("unidad_medida")]
        [StringLength(20)]
        public string UnidadMedida { get; set; }
        [Column("detalle")]
        [StringLength(160)]
        public string Detalle { get; set; }
        [Column("precio_unitario", TypeName = "decimal(18, 5)")]
        public decimal? PrecioUnitario { get; set; }
        [Column("monto_total", TypeName = "decimal(18, 5)")]
        public decimal? MontoTotal { get; set; }
        [Column("monto_descuento", TypeName = "decimal(18, 5)")]
        public decimal? MontoDescuento { get; set; }
        [Column("naturaleza_descuento")]
        [StringLength(80)]
        public string NaturalezaDescuento { get; set; }
        [Column("subtotal", TypeName = "decimal(18, 5)")]
        public decimal? Subtotal { get; set; }
        [Column("impuesto1_codigo")]
        [StringLength(2)]
        public string Impuesto1Codigo { get; set; }
        [Column("impuesto1_porcentaje", TypeName = "decimal(4, 2)")]
        public decimal? Impuesto1Porcentaje { get; set; }
        [Column("impuesto1_monto", TypeName = "decimal(18, 5)")]
        public decimal? Impuesto1Monto { get; set; }
        [Column("exoneracion1_tipo")]
        [StringLength(2)]
        public string Exoneracion1Tipo { get; set; }
        [Column("exoneracion1_numero_doc")]
        [StringLength(17)]
        public string Exoneracion1NumeroDoc { get; set; }
        [Column("exoneracion1_institucion")]
        [StringLength(100)]
        public string Exoneracion1Institucion { get; set; }
        [Column("exoneracion1_fecha_doc", TypeName = "datetime")]
        public DateTime? Exoneracion1FechaDoc { get; set; }
        [Column("exoneracion1_monto_imp", TypeName = "decimal(18, 5)")]
        public decimal? Exoneracion1MontoImp { get; set; }
        [Column("exoneracion1_porc_compra")]
        public int? Exoneracion1PorcCompra { get; set; }
        [Column("impuesto2_codigo")]
        [StringLength(2)]
        public string Impuesto2Codigo { get; set; }
        [Column("impuesto2_porcentaje", TypeName = "decimal(4, 2)")]
        public decimal? Impuesto2Porcentaje { get; set; }
        [Column("impuesto2_monto", TypeName = "decimal(18, 5)")]
        public decimal? Impuesto2Monto { get; set; }
        [Column("exoneracion2_tipo")]
        [StringLength(2)]
        public string Exoneracion2Tipo { get; set; }
        [Column("exoneracion2_numero_doc")]
        [StringLength(17)]
        public string Exoneracion2NumeroDoc { get; set; }
        [Column("exoneracion2_institucion")]
        [StringLength(100)]
        public string Exoneracion2Institucion { get; set; }
        [Column("exoneracion2_fecha_doc", TypeName = "datetime")]
        public DateTime? Exoneracion2FechaDoc { get; set; }
        [Column("exoneracion2_monto_imp", TypeName = "decimal(18, 5)")]
        public decimal? Exoneracion2MontoImp { get; set; }
        [Column("exoneracion2_porc_compra")]
        public int? Exoneracion2PorcCompra { get; set; }
        [Column("monto_total_linea", TypeName = "decimal(18, 5)")]
        public decimal? MontoTotalLinea { get; set; }
        [Column("exoneracion1_incluir")]
        public int? Exoneracion1Incluir { get; set; }
        [Column("exoneracion2_incluir")]
        public int? Exoneracion2Incluir { get; set; }
    }
}
