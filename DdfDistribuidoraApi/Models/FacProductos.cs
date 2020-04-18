using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FAC_Productos")]
    public partial class FacProductos
    {
        public FacProductos()
        {
            FacFacturasDet = new HashSet<FacFacturasDet>();
        }

        [Key]
        public int CodigoProducto { get; set; }
        public int CodigoTipoClasificacion { get; set; }
        public int CodigoUnidad { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioVenta { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CostoUnitario { get; set; }
        [Required]
        [StringLength(1)]
        public string EsExtra { get; set; }
        [StringLength(2)]
        public string AplicarComision { get; set; }
        [Required]
        [StringLength(1)]
        public string AplicarCashBack { get; set; }
        [Required]
        [StringLength(1)]
        public string RequierePreparacion { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(100)]
        public string CodigoBarras { get; set; }
        [StringLength(1)]
        public string Favoritos { get; set; }
        public int? CodigoSubClasificacion { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Utilidad { get; set; }
        [StringLength(1)]
        public string UtilizarPeso { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? PesoLleno { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? PesoVacia { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? CantidadSeparacion { get; set; }
        [StringLength(1)]
        public string PermiteSeparacion { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(1)]
        public string Inventarios { get; set; }
        public byte[] Imagen { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? PrecioA { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? PrecioB { get; set; }
        [StringLength(1)]
        public string Exento { get; set; }
        [StringLength(255)]
        public string NombreGenerico { get; set; }
        [StringLength(100)]
        public string CodigoBusqueda { get; set; }
        public int? Acompanamientos { get; set; }
        [StringLength(1)]
        public string EnviadoNube { get; set; }
        public int? CantidadInicial { get; set; }
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("CPFlorida")]
        public int? Cpflorida { get; set; }
        [StringLength(1)]
        public string Compuesto { get; set; }
        public int? CodigoZona { get; set; }
        [StringLength(3)]
        public string Prefijo { get; set; }
        [StringLength(1)]
        public string Moneda { get; set; }
        [StringLength(3)]
        public string TipoImagen { get; set; }
        [StringLength(2)]
        public string CodigoTarifa { get; set; }
        [StringLength(1)]
        public string AplicaServicio { get; set; }
        [Column("IDCLiente")]
        [StringLength(50)]
        public string Idcliente { get; set; }

        [InverseProperty("CodigoProductoNavigation")]
        public virtual ICollection<FacFacturasDet> FacFacturasDet { get; set; }
    }
}
