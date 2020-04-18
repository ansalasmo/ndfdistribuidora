using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DdfDistribuidoraApi.Models
{
    public partial class NdfDistribuidoraContext : DbContext
    {
         

        public NdfDistribuidoraContext(DbContextOptions<NdfDistribuidoraContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdBloqueos> AdBloqueos { get; set; }
        public virtual DbSet<AdCantones> AdCantones { get; set; }
        public virtual DbSet<AdClientesHuellas> AdClientesHuellas { get; set; }
        public virtual DbSet<AdComercios> AdComercios { get; set; }
        public virtual DbSet<AdPaises> AdPaises { get; set; }
        public virtual DbSet<AdProvincias> AdProvincias { get; set; }
        public virtual DbSet<AfDetalles> AfDetalles { get; set; }
        public virtual DbSet<AfEncabezado> AfEncabezado { get; set; }
        public virtual DbSet<BinCorreoAdministracion> BinCorreoAdministracion { get; set; }
        public virtual DbSet<BinLocalIngresosSalidas> BinLocalIngresosSalidas { get; set; }
        public virtual DbSet<BinPersonaFotos> BinPersonaFotos { get; set; }
        public virtual DbSet<BinPersonas> BinPersonas { get; set; }
        public virtual DbSet<BinPersonasEnLocal> BinPersonasEnLocal { get; set; }
        public virtual DbSet<BinPersonasIngresosSalidas> BinPersonasIngresosSalidas { get; set; }
        public virtual DbSet<CamposGrid> CamposGrid { get; set; }
        public virtual DbSet<CgAreas> CgAreas { get; set; }
        public virtual DbSet<CgAsientos> CgAsientos { get; set; }
        public virtual DbSet<CgAsientosDetalle> CgAsientosDetalle { get; set; }
        public virtual DbSet<CgBitacora> CgBitacora { get; set; }
        public virtual DbSet<CgCierresAnuales> CgCierresAnuales { get; set; }
        public virtual DbSet<CgConceptos> CgConceptos { get; set; }
        public virtual DbSet<CgCuentas> CgCuentas { get; set; }
        public virtual DbSet<CgCuentasEmpresas> CgCuentasEmpresas { get; set; }
        public virtual DbSet<CgCuentasReportes> CgCuentasReportes { get; set; }
        public virtual DbSet<CgDetalleGrupo> CgDetalleGrupo { get; set; }
        public virtual DbSet<CgEmpresas> CgEmpresas { get; set; }
        public virtual DbSet<CgFormulas> CgFormulas { get; set; }
        public virtual DbSet<CgGrupo1> CgGrupo1 { get; set; }
        public virtual DbSet<CgGrupo2> CgGrupo2 { get; set; }
        public virtual DbSet<CgGrupo3> CgGrupo3 { get; set; }
        public virtual DbSet<CgGrupo4> CgGrupo4 { get; set; }
        public virtual DbSet<CgHistoricoIngresosGastos> CgHistoricoIngresosGastos { get; set; }
        public virtual DbSet<CgHistoricoSaldos> CgHistoricoSaldos { get; set; }
        public virtual DbSet<CgPeriodos> CgPeriodos { get; set; }
        public virtual DbSet<CgReportes> CgReportes { get; set; }
        public virtual DbSet<CgResponsables> CgResponsables { get; set; }
        public virtual DbSet<CgResponsablesConceptos> CgResponsablesConceptos { get; set; }
        public virtual DbSet<CgSistemas> CgSistemas { get; set; }
        public virtual DbSet<CgSubPeriodos> CgSubPeriodos { get; set; }
        public virtual DbSet<CgTiposDocumento> CgTiposDocumento { get; set; }
        public virtual DbSet<ComFacturas> ComFacturas { get; set; }
        public virtual DbSet<ComFacturasDet> ComFacturasDet { get; set; }
        public virtual DbSet<ComPedidos> ComPedidos { get; set; }
        public virtual DbSet<ComPedidosDet> ComPedidosDet { get; set; }
        public virtual DbSet<CtCitas> CtCitas { get; set; }
        public virtual DbSet<CtCitasAcciones> CtCitasAcciones { get; set; }
        public virtual DbSet<CtClientes> CtClientes { get; set; }
        public virtual DbSet<CtConceptos> CtConceptos { get; set; }
        public virtual DbSet<CtDiasReservados> CtDiasReservados { get; set; }
        public virtual DbSet<CtHorarios> CtHorarios { get; set; }
        public virtual DbSet<CtObjetosText> CtObjetosText { get; set; }
        public virtual DbSet<CtTiposAcciones> CtTiposAcciones { get; set; }
        public virtual DbSet<CtTiposZonas> CtTiposZonas { get; set; }
        public virtual DbSet<CtZonas> CtZonas { get; set; }
        public virtual DbSet<CtZonasHorarios> CtZonasHorarios { get; set; }
        public virtual DbSet<CxcCierresR> CxcCierresR { get; set; }
        public virtual DbSet<CxcClientes> CxcClientes { get; set; }
        public virtual DbSet<CxcContraPartidas> CxcContraPartidas { get; set; }
        public virtual DbSet<CxcCuentas> CxcCuentas { get; set; }
        public virtual DbSet<CxcCuentasR> CxcCuentasR { get; set; }
        public virtual DbSet<CxcCuentasRdet> CxcCuentasRdet { get; set; }
        public virtual DbSet<CxcEmpresas> CxcEmpresas { get; set; }
        public virtual DbSet<CxcRecibos> CxcRecibos { get; set; }
        public virtual DbSet<CxcTipos> CxcTipos { get; set; }
        public virtual DbSet<CxcTiposContraPartidas> CxcTiposContraPartidas { get; set; }
        public virtual DbSet<CxcTiposRecibos> CxcTiposRecibos { get; set; }
        public virtual DbSet<Encabezado> Encabezado { get; set; }
        public virtual DbSet<EncabezadoCompra> EncabezadoCompra { get; set; }
        public virtual DbSet<EncabezadoGasto> EncabezadoGasto { get; set; }
        public virtual DbSet<EncabezadoTiquete> EncabezadoTiquete { get; set; }
        public virtual DbSet<Encabezadocredito> Encabezadocredito { get; set; }
        public virtual DbSet<FacActividadesComerciales> FacActividadesComerciales { get; set; }
        public virtual DbSet<FacAplicaImpuestos> FacAplicaImpuestos { get; set; }
        public virtual DbSet<FacCajasIniciales> FacCajasIniciales { get; set; }
        public virtual DbSet<FacCajasIniciales2> FacCajasIniciales2 { get; set; }
        public virtual DbSet<FacCajasInicialesClientes> FacCajasInicialesClientes { get; set; }
        public virtual DbSet<FacCargaProductos> FacCargaProductos { get; set; }
        public virtual DbSet<FacCargaProductosTemp> FacCargaProductosTemp { get; set; }
        public virtual DbSet<FacCierres> FacCierres { get; set; }
        public virtual DbSet<FacCierres2> FacCierres2 { get; set; }
        public virtual DbSet<FacCierresLocales> FacCierresLocales { get; set; }
        public virtual DbSet<FacCierresRecargas> FacCierresRecargas { get; set; }
        public virtual DbSet<FacClasificaciones> FacClasificaciones { get; set; }
        public virtual DbSet<FacClasificacionesClientes> FacClasificacionesClientes { get; set; }
        public virtual DbSet<FacClientes> FacClientes { get; set; }
        public virtual DbSet<FacComandasDet> FacComandasDet { get; set; }
        public virtual DbSet<FacComandasEnc> FacComandasEnc { get; set; }
        public virtual DbSet<FacConceptosRetiros> FacConceptosRetiros { get; set; }
        public virtual DbSet<FacConceptosRetirosClientes> FacConceptosRetirosClientes { get; set; }
        public virtual DbSet<FacControlObjetos> FacControlObjetos { get; set; }
        public virtual DbSet<FacDetalleCliente> FacDetalleCliente { get; set; }
        public virtual DbSet<FacEmpleados> FacEmpleados { get; set; }
        public virtual DbSet<FacEmpleadosClientes> FacEmpleadosClientes { get; set; }
        public virtual DbSet<FacFacturas> FacFacturas { get; set; }
        public virtual DbSet<FacFacturas2> FacFacturas2 { get; set; }
        public virtual DbSet<FacFacturasClientes> FacFacturasClientes { get; set; }
        public virtual DbSet<FacFacturasDet> FacFacturasDet { get; set; }
        public virtual DbSet<FacFacturasDet2> FacFacturasDet2 { get; set; }
        public virtual DbSet<FacFacturasDetClientes> FacFacturasDetClientes { get; set; }
        public virtual DbSet<FacFacturasDetComponentes> FacFacturasDetComponentes { get; set; }
        public virtual DbSet<FacFacturasDetComponentesClientes> FacFacturasDetComponentesClientes { get; set; }
        public virtual DbSet<FacHistorialPrecios> FacHistorialPrecios { get; set; }
        public virtual DbSet<FacImpresoras> FacImpresoras { get; set; }
        public virtual DbSet<FacImpuestos> FacImpuestos { get; set; }
        public virtual DbSet<FacIngredientes> FacIngredientes { get; set; }
        public virtual DbSet<FacIngredientesClientes> FacIngredientesClientes { get; set; }
        public virtual DbSet<FacIngresosCaja> FacIngresosCaja { get; set; }
        public virtual DbSet<FacIngresosCajaClientes> FacIngresosCajaClientes { get; set; }
        public virtual DbSet<FacJornadas> FacJornadas { get; set; }
        public virtual DbSet<FacLocales> FacLocales { get; set; }
        public virtual DbSet<FacLocalesPuntos> FacLocalesPuntos { get; set; }
        public virtual DbSet<FacLocalesUsuarios> FacLocalesUsuarios { get; set; }
        public virtual DbSet<FacMapa> FacMapa { get; set; }
        public virtual DbSet<FacMesas> FacMesas { get; set; }
        public virtual DbSet<FacMisComercios> FacMisComercios { get; set; }
        public virtual DbSet<FacPagosNube> FacPagosNube { get; set; }
        public virtual DbSet<FacPaises> FacPaises { get; set; }
        public virtual DbSet<FacParametros> FacParametros { get; set; }
        public virtual DbSet<FacPedidos> FacPedidos { get; set; }
        public virtual DbSet<FacPedidosAcciones> FacPedidosAcciones { get; set; }
        public virtual DbSet<FacPedidosAccionesCriticasCl> FacPedidosAccionesCriticasCl { get; set; }
        public virtual DbSet<FacPedidosApp> FacPedidosApp { get; set; }
        public virtual DbSet<FacPedidosComponentes> FacPedidosComponentes { get; set; }
        public virtual DbSet<FacPedidosDet> FacPedidosDet { get; set; }
        public virtual DbSet<FacPedidosDetApp> FacPedidosDetApp { get; set; }
        public virtual DbSet<FacPedidosExtras> FacPedidosExtras { get; set; }
        public virtual DbSet<FacPedidosExtrasApp> FacPedidosExtrasApp { get; set; }
        public virtual DbSet<FacProductos> FacProductos { get; set; }
        public virtual DbSet<FacProductosClientes> FacProductosClientes { get; set; }
        public virtual DbSet<FacProductosNdfclientes> FacProductosNdfclientes { get; set; }
        public virtual DbSet<FacProductosProveedor> FacProductosProveedor { get; set; }
        public virtual DbSet<FacPromociones> FacPromociones { get; set; }
        public virtual DbSet<FacPromocionesClientes> FacPromocionesClientes { get; set; }
        public virtual DbSet<FacRetirosCaja> FacRetirosCaja { get; set; }
        public virtual DbSet<FacRetirosCaja2> FacRetirosCaja2 { get; set; }
        public virtual DbSet<FacRetirosCajaClientes> FacRetirosCajaClientes { get; set; }
        public virtual DbSet<FacSeparacionPedidos> FacSeparacionPedidos { get; set; }
        public virtual DbSet<FacSeparacionPedidos2> FacSeparacionPedidos2 { get; set; }
        public virtual DbSet<FacSubClasificaciones> FacSubClasificaciones { get; set; }
        public virtual DbSet<FacSubClasificacionesClientes> FacSubClasificacionesClientes { get; set; }
        public virtual DbSet<FacTarifas> FacTarifas { get; set; }
        public virtual DbSet<FacTiposHabitaciones> FacTiposHabitaciones { get; set; }
        public virtual DbSet<FacUnidades> FacUnidades { get; set; }
        public virtual DbSet<FacUnidadesClientes> FacUnidadesClientes { get; set; }
        public virtual DbSet<FeCorreos> FeCorreos { get; set; }
        public virtual DbSet<GrValoresConsultar> GrValoresConsultar { get; set; }
        public virtual DbSet<IdCamposGrid> IdCamposGrid { get; set; }
        public virtual DbSet<IdFormularios> IdFormularios { get; set; }
        public virtual DbSet<IdHeaderGrid> IdHeaderGrid { get; set; }
        public virtual DbSet<IdIdiomas> IdIdiomas { get; set; }
        public virtual DbSet<IdObjetos> IdObjetos { get; set; }
        public virtual DbSet<IdObjetosIdiomas> IdObjetosIdiomas { get; set; }
        public virtual DbSet<InBodegas> InBodegas { get; set; }
        public virtual DbSet<InCierresDet> InCierresDet { get; set; }
        public virtual DbSet<InCierresInventario> InCierresInventario { get; set; }
        public virtual DbSet<InCierresR> InCierresR { get; set; }
        public virtual DbSet<InComponentes> InComponentes { get; set; }
        public virtual DbSet<InComponentesClientes> InComponentesClientes { get; set; }
        public virtual DbSet<InConceptos> InConceptos { get; set; }
        public virtual DbSet<InExistencias> InExistencias { get; set; }
        public virtual DbSet<InHistoricoCostoProducto> InHistoricoCostoProducto { get; set; }
        public virtual DbSet<InMovimientos> InMovimientos { get; set; }
        public virtual DbSet<InMovimientosDet> InMovimientosDet { get; set; }
        public virtual DbSet<InPedidosDetInv> InPedidosDetInv { get; set; }
        public virtual DbSet<InPedidosInv> InPedidosInv { get; set; }
        public virtual DbSet<InTiposMovimientos> InTiposMovimientos { get; set; }
        public virtual DbSet<LineaCompra> LineaCompra { get; set; }
        public virtual DbSet<LineaNaby> LineaNaby { get; set; }
        public virtual DbSet<LineaTiquete> LineaTiquete { get; set; }
        public virtual DbSet<Lineacredito> Lineacredito { get; set; }
        public virtual DbSet<MctCambioSemanal> MctCambioSemanal { get; set; }
        public virtual DbSet<MctCambiosHorarios> MctCambiosHorarios { get; set; }
        public virtual DbSet<MctCargaMarcas> MctCargaMarcas { get; set; }
        public virtual DbSet<MctCargaMarcasIm> MctCargaMarcasIm { get; set; }
        public virtual DbSet<MctCierresMes> MctCierresMes { get; set; }
        public virtual DbSet<MctCierresMesDet> MctCierresMesDet { get; set; }
        public virtual DbSet<MctDiasImprevistos> MctDiasImprevistos { get; set; }
        public virtual DbSet<MctEmpleadosCambiados> MctEmpleadosCambiados { get; set; }
        public virtual DbSet<MctEmpleadosMarcasEspeciales> MctEmpleadosMarcasEspeciales { get; set; }
        public virtual DbSet<MctHorarios> MctHorarios { get; set; }
        public virtual DbSet<MctHorariosHistorico> MctHorariosHistorico { get; set; }
        public virtual DbSet<MctHuellasEmpleados> MctHuellasEmpleados { get; set; }
        public virtual DbSet<MctJustificaciones> MctJustificaciones { get; set; }
        public virtual DbSet<MctMinutosGracia> MctMinutosGracia { get; set; }
        public virtual DbSet<MctPermisosCambiosHorario> MctPermisosCambiosHorario { get; set; }
        public virtual DbSet<MctTemporalMarcas> MctTemporalMarcas { get; set; }
        public virtual DbSet<MctTiposJustificaciones> MctTiposJustificaciones { get; set; }
        public virtual DbSet<ObjetosBd> ObjetosBd { get; set; }
        public virtual DbSet<OrtPlanes> OrtPlanes { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<RepCargarCombos> RepCargarCombos { get; set; }
        public virtual DbSet<RepCheckConstraint> RepCheckConstraint { get; set; }
        public virtual DbSet<RepParametrosObjetosDb> RepParametrosObjetosDb { get; set; }
        public virtual DbSet<RepUsuarioColumnasFiltro> RepUsuarioColumnasFiltro { get; set; }
        public virtual DbSet<RepUsuariosReportes> RepUsuariosReportes { get; set; }
        public virtual DbSet<RhAcciones> RhAcciones { get; set; }
        public virtual DbSet<RhCantones> RhCantones { get; set; }
        public virtual DbSet<RhDepartamentos> RhDepartamentos { get; set; }
        public virtual DbSet<RhDistritos> RhDistritos { get; set; }
        public virtual DbSet<RhEmpleados> RhEmpleados { get; set; }
        public virtual DbSet<RhEmpleadosMov> RhEmpleadosMov { get; set; }
        public virtual DbSet<RhExpedienteEmpleado> RhExpedienteEmpleado { get; set; }
        public virtual DbSet<RhFeriados> RhFeriados { get; set; }
        public virtual DbSet<RhMovSaldos> RhMovSaldos { get; set; }
        public virtual DbSet<RhMovimientos> RhMovimientos { get; set; }
        public virtual DbSet<RhMovimientosExtra> RhMovimientosExtra { get; set; }
        public virtual DbSet<RhOcupacionesCcss> RhOcupacionesCcss { get; set; }
        public virtual DbSet<RhOcupacionesIns> RhOcupacionesIns { get; set; }
        public virtual DbSet<RhParametros> RhParametros { get; set; }
        public virtual DbSet<RhPlanilla> RhPlanilla { get; set; }
        public virtual DbSet<RhPlanillaDet> RhPlanillaDet { get; set; }
        public virtual DbSet<RhPlanillaEnc> RhPlanillaEnc { get; set; }
        public virtual DbSet<RhProfesiones> RhProfesiones { get; set; }
        public virtual DbSet<RhProgramas> RhProgramas { get; set; }
        public virtual DbSet<RhProvincias> RhProvincias { get; set; }
        public virtual DbSet<RhPuestosSalariales> RhPuestosSalariales { get; set; }
        public virtual DbSet<RhTiposAcciones> RhTiposAcciones { get; set; }
        public virtual DbSet<RhTiposDocumentos> RhTiposDocumentos { get; set; }
        public virtual DbSet<RhUnidades> RhUnidades { get; set; }
        public virtual DbSet<SgBitacora> SgBitacora { get; set; }
        public virtual DbSet<SgMenuSistemas> SgMenuSistemas { get; set; }
        public virtual DbSet<SgOpcionesMenu> SgOpcionesMenu { get; set; }
        public virtual DbSet<SgOpcionesUsuario> SgOpcionesUsuario { get; set; }
        public virtual DbSet<SgSistemas> SgSistemas { get; set; }
        public virtual DbSet<SgUsuarios> SgUsuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=uunzxpu9iw.database.windows.net;Initial Catalog=ndfdistribuidora;Persist Security Info=False;User ID=ciosa;Password=Lpky0864;MultipleActiveResultSets=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdBloqueos>(entity =>
            {
                entity.HasKey(e => e.NumeroBloqueo)
                    .HasName("PK_AD_BLOQUEOS");

                entity.Property(e => e.NumeroBloqueo).ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCancela).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<AdCantones>(entity =>
            {
                entity.HasKey(e => new { e.CodigoPais, e.CodigoProvincia, e.CodigoCanton })
                    .HasName("PK_AD_CANTONES");

                entity.Property(e => e.Identificador)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreCanton).IsUnicode(false);
            });

            modelBuilder.Entity<AdClientesHuellas>(entity =>
            {
                entity.HasKey(e => new { e.Idcliente, e.Mano, e.Dedo })
                    .HasName("PK_FAC_CLIENTESHUELLAS");

                entity.Property(e => e.Idcliente).IsUnicode(false);

                entity.Property(e => e.Mano)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<AdComercios>(entity =>
            {
                entity.HasKey(e => e.Idcomercio)
                    .HasName("PK_AD_COMERCIOS");

                entity.Property(e => e.Idcomercio).ValueGeneratedNever();

                entity.Property(e => e.AplicaCashBack)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicacionWeb)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BaseDatos).IsUnicode(false);

                entity.Property(e => e.Bloqueado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CedulaAgente).IsUnicode(false);

                entity.Property(e => e.CedulaPropietario).IsUnicode(false);

                entity.Property(e => e.ControlExpress)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Correo).IsUnicode(false);

                entity.Property(e => e.CuentaCliente)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idpadre).IsUnicode(false);

                entity.Property(e => e.NombreComercio).IsUnicode(false);

                entity.Property(e => e.NombrePropietario).IsUnicode(false);

                entity.Property(e => e.Telefonos).IsUnicode(false);
            });

            modelBuilder.Entity<AdPaises>(entity =>
            {
                entity.HasKey(e => e.CodigoPais)
                    .HasName("PK_AD_PAISES");

                entity.Property(e => e.CodigoPais).ValueGeneratedNever();

                entity.Property(e => e.NombrePais).IsUnicode(false);
            });

            modelBuilder.Entity<AdProvincias>(entity =>
            {
                entity.HasKey(e => new { e.CodigoPais, e.CodigoProvincia })
                    .HasName("PK_AD_PROVINCIAS2");

                entity.Property(e => e.NombreProvincia).IsUnicode(false);
            });

            modelBuilder.Entity<AfDetalles>(entity =>
            {
                entity.HasKey(e => new { e.NumeroFactura, e.Linea })
                    .HasName("PK_AF_DETALLES");

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MotivoError).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<AfEncabezado>(entity =>
            {
                entity.HasKey(e => e.NumeroFactura)
                    .HasName("PK_AF_ENC");

                entity.Property(e => e.Area)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMiPueblo).IsUnicode(false);

                entity.Property(e => e.Documento).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idcliente).IsUnicode(false);

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.MotivoAnulacion).IsUnicode(false);

                entity.Property(e => e.MotivoError).IsUnicode(false);

                entity.Property(e => e.MotivoRegalia).IsUnicode(false);

                entity.Property(e => e.NombreCliente).IsUnicode(false);

                entity.Property(e => e.NumeroCertificado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Reportada)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula).IsUnicode(false);

                entity.Property(e => e.UsuarioAtiende).IsUnicode(false);

                entity.Property(e => e.UsuarioCierra).IsUnicode(false);
            });

            modelBuilder.Entity<BinCorreoAdministracion>(entity =>
            {
                entity.HasKey(e => e.IdCorreo)
                    .HasName("PK_Correos_Administracion");

                entity.Property(e => e.Contrasenia).IsUnicode(false);

                entity.Property(e => e.Correo).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);
            });

            modelBuilder.Entity<BinLocalIngresosSalidas>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.Correo, e.Id })
                    .HasName("PK_BIN_LOCALIEPERSONAS");

                entity.Property(e => e.Correo).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<BinPersonaFotos>(entity =>
            {
                entity.Property(e => e.Correo).IsUnicode(false);

                entity.Property(e => e.IdEspecial).IsUnicode(false);
            });

            modelBuilder.Entity<BinPersonas>(entity =>
            {
                entity.Property(e => e.Correo).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.Genero).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.TokenAcceso).IsUnicode(false);
            });

            modelBuilder.Entity<BinPersonasEnLocal>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.Correo })
                    .HasName("PK_BIN_PERSONASENLOCAL");

                entity.Property(e => e.Correo).IsUnicode(false);
            });

            modelBuilder.Entity<BinPersonasIngresosSalidas>(entity =>
            {
                entity.HasKey(e => new { e.Correo, e.CodigoLocal, e.Id })
                    .HasName("PK_BIN_PERSONASIELOCAL");

                entity.Property(e => e.Correo).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CamposGrid>(entity =>
            {
                entity.HasKey(e => new { e.Nombre, e.MappingName })
                    .HasName("PK_CAMPOSGRID");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.MappingName).IsUnicode(false);

                entity.Property(e => e.Alignment).IsUnicode(false);

                entity.Property(e => e.FalseValue)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Format).IsUnicode(false);

                entity.Property(e => e.HeaderText).IsUnicode(false);

                entity.Property(e => e.PermiteAgrupar)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteSumar)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCampo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TrueValue)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.NombreNavigation)
                    .WithMany(p => p.CamposGrid)
                    .HasForeignKey(d => d.Nombre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CAMPOSGR_REFERENCE_OBJETOSB");
            });

            modelBuilder.Entity<CgAreas>(entity =>
            {
                entity.HasKey(e => e.CodigoArea)
                    .HasName("CG_AreasPK")
                    .IsClustered(false);

                entity.Property(e => e.CodigoArea)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CgAsientos>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Numero })
                    .HasName("PK_CG_ASIENTOS");

                entity.Property(e => e.AjustadoPr)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoConcepto)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoSistema)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MotivoAnulacion).IsUnicode(false);

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula).IsUnicode(false);

                entity.Property(e => e.UsuarioAsignado).IsUnicode(false);

                entity.Property(e => e.UsuarioDesMayoriza).IsUnicode(false);

                entity.Property(e => e.UsuarioFinaliza).IsUnicode(false);

                entity.Property(e => e.UsuarioMayoriza).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CgAsientosDetalle>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Numero, e.Linea })
                    .HasName("PK_CG_ASIENTOSDET");

                entity.Property(e => e.CodigoDocumento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cuenta)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaBanco)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Documento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CgBitacora>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DescripcionEvento).IsUnicode(false);

                entity.Property(e => e.DireccionIp).IsUnicode(false);

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.Referencia1).IsUnicode(false);

                entity.Property(e => e.Referencia2).IsUnicode(false);

                entity.Property(e => e.Referencia3).IsUnicode(false);

                entity.Property(e => e.ReferenciaTecnica).IsUnicode(false);
            });

            modelBuilder.Entity<CgCierresAnuales>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cuenta).IsUnicode(false);

                entity.Property(e => e.TipoCierre)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CgConceptos>(entity =>
            {
                entity.HasKey(e => new { e.CodigoSistema, e.CodigoConcepto })
                    .HasName("CG_ConceptosPK")
                    .IsClustered(false);

                entity.Property(e => e.CodigoSistema)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoConcepto)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoArea)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoAsiento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CgCuentas>(entity =>
            {
                entity.HasKey(e => e.Cuenta)
                    .HasName("CG_CuentasPK")
                    .IsClustered(false);

                entity.Property(e => e.Cuenta).IsUnicode(false);

                entity.Property(e => e.AceptaMov)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaBloqueada)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaContaNac).IsUnicode(false);

                entity.Property(e => e.CuentaNueva).IsUnicode(false);

                entity.Property(e => e.CuentaOrden)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaPadre)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Depreciacion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Interna)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.OrdenBalance)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCuenta)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoSaldo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CgCuentasEmpresas>(entity =>
            {
                entity.HasKey(e => new { e.CodigoEmpresa, e.Cuenta })
                    .HasName("CG_Cuentas_8515310862")
                    .IsClustered(false);

                entity.Property(e => e.Cuenta)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CgCuentasReportes>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cuenta).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CgDetalleGrupo>(entity =>
            {
                entity.HasKey(e => new { e.CodigoReporte, e.GrupoUno, e.GrupoDos, e.GrupoTres, e.GrupoCuatro, e.Cuenta })
                    .HasName("CG_DetalleGrupoPK")
                    .IsClustered(false);

                entity.Property(e => e.Cuenta).IsUnicode(false);

                entity.Property(e => e.Formula)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Negativo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreDetalle).IsUnicode(false);

                entity.Property(e => e.NotaDetalle)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrimeraColumna)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CgEmpresas>(entity =>
            {
                entity.HasKey(e => e.CodigoEmpresa)
                    .HasName("CG_Empresa_10435317702")
                    .IsClustered(false);

                entity.Property(e => e.CodigoEmpresa).ValueGeneratedNever();

                entity.Property(e => e.CuentaCierre)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CgFormulas>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cuenta)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaFormula)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NegativoSub)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CgGrupo1>(entity =>
            {
                entity.HasKey(e => new { e.CodigoReporte, e.GrupoUno })
                    .HasName("CG_Grupo1_11075319982")
                    .IsClustered(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.MostrarDescripcion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MostrarEncabezadoUno)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MostrarPieUno)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Nota1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PieUno).IsUnicode(false);
            });

            modelBuilder.Entity<CgGrupo2>(entity =>
            {
                entity.HasKey(e => new { e.CodigoReporte, e.GrupoUno, e.GrupoDos })
                    .HasName("CG_Grupo2_11395321122")
                    .IsClustered(false);

                entity.Property(e => e.LineaDosA).IsUnicode(false);

                entity.Property(e => e.LineaDosB).IsUnicode(false);

                entity.Property(e => e.MostrarEncabezadoDos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MostrarLineaDosA)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MostrarLineaDosB)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MostrarPieDos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreDos).IsUnicode(false);

                entity.Property(e => e.Nota2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PieDos).IsUnicode(false);
            });

            modelBuilder.Entity<CgGrupo3>(entity =>
            {
                entity.HasKey(e => new { e.CodigoReporte, e.GrupoUno, e.GrupoDos, e.GrupoTres })
                    .HasName("CG_Grupo3_11715322262")
                    .IsClustered(false);

                entity.Property(e => e.LineaTresA).IsUnicode(false);

                entity.Property(e => e.LineaTresB).IsUnicode(false);

                entity.Property(e => e.MostrarEncabezadoTres)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MostrarLineaTresA)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MostrarLineaTresB)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MostrarPieTres)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreTres).IsUnicode(false);

                entity.Property(e => e.Nota3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PieTres).IsUnicode(false);
            });

            modelBuilder.Entity<CgGrupo4>(entity =>
            {
                entity.HasKey(e => new { e.CodigoReporte, e.GrupoUno, e.GrupoDos, e.GrupoTres, e.GrupoCuatro })
                    .HasName("CG_Grupo4_12035323402")
                    .IsClustered(false);

                entity.Property(e => e.LineaCuatroA).IsUnicode(false);

                entity.Property(e => e.LineaCuatroB).IsUnicode(false);

                entity.Property(e => e.MostrarEncabezadoCuatro)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MostrarLineaCuatroA)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MostrarLineaCuatroB)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MostrarPieCuatro)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreCuatro).IsUnicode(false);

                entity.Property(e => e.Nota4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PieCuatro).IsUnicode(false);
            });

            modelBuilder.Entity<CgHistoricoIngresosGastos>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.SubPeriodo, e.CodigoEmpresa, e.Cuenta })
                    .HasName("CG_HistoricoIGPK")
                    .IsClustered(false);

                entity.Property(e => e.Cuenta).IsUnicode(false);

                entity.Property(e => e.AceptaMov)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaBloqueada)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaOrden)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaPadre)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.TipoCuenta)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoSaldo)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CgHistoricoSaldos>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.SubPeriodo, e.CodigoEmpresa, e.Cuenta })
                    .HasName("CG_HistoricoSaldosPK")
                    .IsClustered(false);

                entity.Property(e => e.Cuenta).IsUnicode(false);

                entity.Property(e => e.AceptaMov)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaBloqueada)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaOrden)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaPadre)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.TipoCuenta)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoSaldo)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CgPeriodos>(entity =>
            {
                entity.HasKey(e => e.Periodo)
                    .HasName("CG_Periodo_12675325682")
                    .IsClustered(false);

                entity.Property(e => e.Periodo).ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoPeriodo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CgReportes>(entity =>
            {
                entity.HasKey(e => e.CodigoReporte)
                    .HasName("CG_Reporte_12995326822")
                    .IsClustered(false);

                entity.Property(e => e.CodigoReporte).ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreArchivo).IsUnicode(false);

                entity.Property(e => e.NombreReporte).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CgResponsables>(entity =>
            {
                entity.HasKey(e => e.Login)
                    .HasName("CG_Respons_13315327962")
                    .IsClustered(false);

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CgResponsablesConceptos>(entity =>
            {
                entity.HasKey(e => new { e.Login, e.CodigoSistema, e.CodigoConcepto })
                    .HasName("PK_CG_Responsables")
                    .IsClustered(false);

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.CodigoSistema)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoConcepto)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AccesoAbc)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AccesoLectura)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AccesoMayoriza)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CgSistemas>(entity =>
            {
                entity.HasKey(e => e.CodigoSistema)
                    .HasName("CG_Sistemas_CodigoSistema")
                    .IsClustered(false);

                entity.Property(e => e.CodigoSistema)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CgSubPeriodos>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.SubPeriodo })
                    .HasName("CG_SubPeri_14595332522")
                    .IsClustered(false);

                entity.Property(e => e.Abreviatura).IsUnicode(false);

                entity.Property(e => e.CuentaCierre)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.UsuarioCierre).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CgTiposDocumento>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descripcion).IsUnicode(false);
            });

            modelBuilder.Entity<ComFacturas>(entity =>
            {
                entity.HasKey(e => e.NumeroFactura)
                    .HasName("PK_COM_FACTURAS");

                entity.Property(e => e.Area)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CedulaEnvia).IsUnicode(false);

                entity.Property(e => e.ClaveElectronica).IsUnicode(false);

                entity.Property(e => e.ClaveElectronicaCred)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMiPueblo).IsUnicode(false);

                entity.Property(e => e.ConsecutivoElectronico).IsUnicode(false);

                entity.Property(e => e.ConsecutivoElectronicoCred)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CorreoEnvia).IsUnicode(false);

                entity.Property(e => e.CorreoRecibe).IsUnicode(false);

                entity.Property(e => e.Documento).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idcliente).IsUnicode(false);

                entity.Property(e => e.Identificacion).IsUnicode(false);

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.MotivoAnulacion).IsUnicode(false);

                entity.Property(e => e.MotivoError).IsUnicode(false);

                entity.Property(e => e.MotivoRegalia).IsUnicode(false);

                entity.Property(e => e.NombreCliente).IsUnicode(false);

                entity.Property(e => e.NombreEnvia).IsUnicode(false);

                entity.Property(e => e.NumeroCertificado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Reportada)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoEnvia).IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula).IsUnicode(false);

                entity.Property(e => e.UsuarioAtiende).IsUnicode(false);

                entity.Property(e => e.UsuarioCierra).IsUnicode(false);

                entity.Property(e => e.UsuarioEntrega).IsUnicode(false);
            });

            modelBuilder.Entity<ComFacturasDet>(entity =>
            {
                entity.HasKey(e => new { e.NumeroFactura, e.Linea })
                    .HasName("PK_COM_FACTURASDET");

                entity.Property(e => e.CodigoImpuesto)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoTarifa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoDevolucion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MotivoError).IsUnicode(false);

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.UsuarioAprueba).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<ComPedidos>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.NumeroPedido })
                    .HasName("PK_COM_PEDIDOS");

                entity.Property(e => e.AplicarImpuestos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Area)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clave)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMiPueblo).IsUnicode(false);

                entity.Property(e => e.ComandaImpresa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DebeLlamar)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FacturasCorreo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Genero)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idcliente).IsUnicode(false);

                entity.Property(e => e.IdentificadorApp).IsUnicode(false);

                entity.Property(e => e.MotivoCancela).IsUnicode(false);

                entity.Property(e => e.NombreCliente).IsUnicode(false);

                entity.Property(e => e.PreviaImpresa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RapidoIncluido)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCancela).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<ComPedidosDet>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.NumeroPedido, e.Linea })
                    .HasName("PK_COM_PEDIDOSDET");

                entity.Property(e => e.Alerta)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiPuebloCanje)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Rapido)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RapidoIncluido)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioEnvia).IsUnicode(false);

                entity.Property(e => e.UsuarioPrepara).IsUnicode(false);

                entity.Property(e => e.UsuarioPreparando).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.Property(e => e.UsuarioSirve).IsUnicode(false);
            });

            modelBuilder.Entity<CtCitas>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.NumeroCita })
                    .HasName("PK_CT_CITAS");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Placa).IsUnicode(false);

                entity.Property(e => e.Tarifa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.CodigoClienteNavigation)
                    .WithMany(p => p.CtCitas)
                    .HasForeignKey(d => d.CodigoCliente)
                    .HasConstraintName("FK_CT_CITAS_REF_CT_CLIEN");
            });

            modelBuilder.Entity<CtCitasAcciones>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.NumeroCita, e.CodigoAccion })
                    .HasName("PK_CT_CITASACCIONES");

                entity.Property(e => e.Documento).IsUnicode(false);

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.CodigoAccionNavigation)
                    .WithMany(p => p.CtCitasAcciones)
                    .HasForeignKey(d => d.CodigoAccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CT_CITAS_REFERENCE_CT_TIPOS");

                entity.HasOne(d => d.CtCitas)
                    .WithMany(p => p.CtCitasAcciones)
                    .HasForeignKey(d => new { d.Periodo, d.Mes, d.Dia, d.NumeroCita })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CT_CITAS_REFERENCE_CT_CITAS");
            });

            modelBuilder.Entity<CtClientes>(entity =>
            {
                entity.HasKey(e => e.CodigoCliente)
                    .HasName("PK_CT_CLIENTES");

                entity.Property(e => e.CodigoCliente).ValueGeneratedNever();

                entity.Property(e => e.CodigoPais)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Idcliente).IsUnicode(false);

                entity.Property(e => e.Identificacion).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Placa).IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.Property(e => e.TelefonoCasa).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CtConceptos>(entity =>
            {
                entity.Property(e => e.CodigoConcepto).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CtDiasReservados>(entity =>
            {
                entity.HasKey(e => new { e.CodigoZona, e.Periodo, e.Mes, e.Dia, e.CodigoHorario })
                    .HasName("PK_CT_DIASRESERVADOS");

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.CodigoZonaNavigation)
                    .WithMany(p => p.CtDiasReservados)
                    .HasForeignKey(d => d.CodigoZona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CT_DIASR_REFERENCE_CT_ZONAS");
            });

            modelBuilder.Entity<CtHorarios>(entity =>
            {
                entity.HasKey(e => e.CodigoHorario)
                    .HasName("PK_CT_HORARIOS");

                entity.Property(e => e.CodigoHorario).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CtObjetosText>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NombreFormulario).IsUnicode(false);

                entity.Property(e => e.NombreObjeto).IsUnicode(false);

                entity.Property(e => e.ValorText).IsUnicode(false);
            });

            modelBuilder.Entity<CtTiposAcciones>(entity =>
            {
                entity.HasKey(e => e.CodigoAccion)
                    .HasName("PK_CT_TIPOSACCIONES");

                entity.Property(e => e.CodigoAccion).ValueGeneratedNever();

                entity.Property(e => e.AccionPor)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.TipoAccion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CtTiposZonas>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoZona)
                    .HasName("PK_CT_TIPOSZONAS");

                entity.Property(e => e.CodigoTipoZona).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CtZonas>(entity =>
            {
                entity.HasKey(e => e.CodigoZona)
                    .HasName("PK_CT_ZONAS");

                entity.Property(e => e.CodigoZona).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CtZonasHorarios>(entity =>
            {
                entity.HasKey(e => new { e.CodigoZona, e.DiaSemana, e.CodigoHorario })
                    .HasName("PK_CT_ZONASHORARIOS");

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CxcCierresR>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.Login })
                    .HasName("PK_CXC_CIERRESR");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CxcClientes>(entity =>
            {
                entity.HasKey(e => e.CedulaCliente)
                    .HasName("pk_cxc_clientes");

                entity.Property(e => e.CedulaCliente).IsUnicode(false);

                entity.Property(e => e.CedulaEmpresa).IsUnicode(false);

                entity.Property(e => e.CodigoActividad).IsUnicode(false);

                entity.Property(e => e.Correo).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.NombreCliente).IsUnicode(false);

                entity.Property(e => e.NombreInstitucion).IsUnicode(false);

                entity.Property(e => e.NumeroDocumento).IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.Property(e => e.TipoCliente)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDocumentoExoneracion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPersona)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistro).IsUnicode(false);

                entity.HasOne(d => d.CedulaEmpresaNavigation)
                    .WithMany(p => p.CxcClientes)
                    .HasForeignKey(d => d.CedulaEmpresa)
                    .HasConstraintName("fk_cxc_clie_reference_cxc_empr");
            });

            modelBuilder.Entity<CxcContraPartidas>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Numero, e.Linea })
                    .HasName("pk_cxc_contrapartidas");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistro).IsUnicode(false);

                entity.HasOne(d => d.CodigoContraPartidaNavigation)
                    .WithMany(p => p.CxcContraPartidas)
                    .HasForeignKey(d => d.CodigoContraPartida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cxc_cont_reference_cxc_tipo");
            });

            modelBuilder.Entity<CxcCuentas>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Numero })
                    .HasName("pk_cxc_cuentas");

                entity.Property(e => e.ActividadComercial).IsUnicode(false);

                entity.Property(e => e.CedulaCliente).IsUnicode(false);

                entity.Property(e => e.CodigoImpuesto)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoTarifa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CorreoEnviado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaBalance).IsUnicode(false);

                entity.Property(e => e.DeduciblePlanilla)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Documento).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsSimplificado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.Referencia).IsUnicode(false);

                entity.Property(e => e.TipoRegistro)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula).IsUnicode(false);

                entity.Property(e => e.UsuarioAprueba).IsUnicode(false);

                entity.Property(e => e.UsuarioCancela).IsUnicode(false);

                entity.Property(e => e.UsuarioEnvia).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistro).IsUnicode(false);

                entity.HasOne(d => d.CedulaClienteNavigation)
                    .WithMany(p => p.CxcCuentas)
                    .HasForeignKey(d => d.CedulaCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cxc_cuen_reference_cxc_clie");

                entity.HasOne(d => d.CodigoTipoNavigation)
                    .WithMany(p => p.CxcCuentas)
                    .HasForeignKey(d => d.CodigoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cxc_cuen_reference_cxc_tipo");
            });

            modelBuilder.Entity<CxcCuentasR>(entity =>
            {
                entity.HasKey(e => e.NumeroFactura)
                    .HasName("PK_CXC_CUENTASR");

                entity.Property(e => e.Area)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Documento).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idcliente).IsUnicode(false);

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.MotivoAnulacion).IsUnicode(false);

                entity.Property(e => e.MotivoError).IsUnicode(false);

                entity.Property(e => e.MotivoRegalia).IsUnicode(false);

                entity.Property(e => e.NombreCliente).IsUnicode(false);

                entity.Property(e => e.NumeroCertificado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Reportada)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula).IsUnicode(false);

                entity.Property(e => e.UsuarioAtiende).IsUnicode(false);

                entity.Property(e => e.UsuarioCierra).IsUnicode(false);
            });

            modelBuilder.Entity<CxcCuentasRdet>(entity =>
            {
                entity.HasKey(e => new { e.NumeroFactura, e.Linea })
                    .HasName("PK_CXC_CUENTASRDET");

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MotivoError).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CxcEmpresas>(entity =>
            {
                entity.HasKey(e => e.CedulaEmpresa)
                    .HasName("pk_cxc_empresas");

                entity.Property(e => e.CedulaEmpresa).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistro).IsUnicode(false);
            });

            modelBuilder.Entity<CxcRecibos>(entity =>
            {
                entity.HasKey(e => new { e.PeriodoRecibo, e.NumeroRecibo })
                    .HasName("pk_cxc_recibos");

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Observacion2).IsUnicode(false);

                entity.Property(e => e.TipoRegistro)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.CodigoTipoReciboNavigation)
                    .WithMany(p => p.CxcRecibos)
                    .HasForeignKey(d => d.CodigoTipoRecibo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cxc_reci_reference_cxc_tipo");

                entity.HasOne(d => d.CxcCuentas)
                    .WithMany(p => p.CxcRecibos)
                    .HasForeignKey(d => new { d.Periodo, d.Numero })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cxc_reci_reference_cxc_cuen");
            });

            modelBuilder.Entity<CxcTipos>(entity =>
            {
                entity.HasKey(e => e.CodigoTipo)
                    .HasName("pk_cxc_tipos");

                entity.Property(e => e.CodigoTipo).ValueGeneratedNever();

                entity.Property(e => e.CuentaContable)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaContableLp).IsUnicode(false);

                entity.Property(e => e.EsSalario)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Impuestos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.RequiereAprobacion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistro).IsUnicode(false);
            });

            modelBuilder.Entity<CxcTiposContraPartidas>(entity =>
            {
                entity.HasKey(e => e.CodigoContraPartida)
                    .HasName("pk_cxc_tiposcontrapartidas");

                entity.Property(e => e.CodigoContraPartida).ValueGeneratedNever();

                entity.Property(e => e.Cuenta).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Impuestos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<CxcTiposRecibos>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoRecibo)
                    .HasName("pk_cxc_tiposrecibos");

                entity.Property(e => e.CodigoTipoRecibo).ValueGeneratedNever();

                entity.Property(e => e.Cuenta).IsUnicode(false);

                entity.Property(e => e.GeneraAsiento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistro).IsUnicode(false);
            });

            modelBuilder.Entity<Encabezado>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActividadComercial)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clave).IsUnicode(false);

                entity.Property(e => e.CondicionVenta).IsUnicode(false);

                entity.Property(e => e.ConsecutivoCompleto).IsUnicode(false);

                entity.Property(e => e.ConsecutivoIncompleto).IsUnicode(false);

                entity.Property(e => e.ConsecutivoOrigen).IsUnicode(false);

                entity.Property(e => e.CorreosAdicionales).IsUnicode(false);

                entity.Property(e => e.CorreosAdicionales1).IsUnicode(false);

                entity.Property(e => e.EmailAdicional).IsUnicode(false);

                entity.Property(e => e.EmisorCanton).IsUnicode(false);

                entity.Property(e => e.EmisorDireccion).IsUnicode(false);

                entity.Property(e => e.EmisorDistrito).IsUnicode(false);

                entity.Property(e => e.EmisorEmail).IsUnicode(false);

                entity.Property(e => e.EmisorFax).IsUnicode(false);

                entity.Property(e => e.EmisorIdentificacion).IsUnicode(false);

                entity.Property(e => e.EmisorNomComercial).IsUnicode(false);

                entity.Property(e => e.EmisorNombre).IsUnicode(false);

                entity.Property(e => e.EmisorProvincia).IsUnicode(false);

                entity.Property(e => e.EmisorTelefono).IsUnicode(false);

                entity.Property(e => e.EmisorTipo).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoEnvio).IsUnicode(false);

                entity.Property(e => e.EstadoHacienda).IsUnicode(false);

                entity.Property(e => e.MedioPago1).IsUnicode(false);

                entity.Property(e => e.MedioPago2).IsUnicode(false);

                entity.Property(e => e.MedioPago3).IsUnicode(false);

                entity.Property(e => e.MedioPago4).IsUnicode(false);

                entity.Property(e => e.MensajeEnvio).IsUnicode(false);

                entity.Property(e => e.MensajeHacienda).IsUnicode(false);

                entity.Property(e => e.Moneda).IsUnicode(false);

                entity.Property(e => e.Otros).IsUnicode(false);

                entity.Property(e => e.Pasaporte).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.ReceptorCanton).IsUnicode(false);

                entity.Property(e => e.ReceptorDireccion).IsUnicode(false);

                entity.Property(e => e.ReceptorDistrito).IsUnicode(false);

                entity.Property(e => e.ReceptorEmail).IsUnicode(false);

                entity.Property(e => e.ReceptorFax).IsUnicode(false);

                entity.Property(e => e.ReceptorIdentificacion).IsUnicode(false);

                entity.Property(e => e.ReceptorNombre).IsUnicode(false);

                entity.Property(e => e.ReceptorProvincia).IsUnicode(false);

                entity.Property(e => e.ReceptorTelefono).IsUnicode(false);

                entity.Property(e => e.ReceptorTipo).IsUnicode(false);

                entity.Property(e => e.RefClave).IsUnicode(false);

                entity.Property(e => e.RefCodigo).IsUnicode(false);

                entity.Property(e => e.RefRazon).IsUnicode(false);

                entity.Property(e => e.RefTipoDoc).IsUnicode(false);

                entity.Property(e => e.TipoDocumento).IsUnicode(false);

                entity.Property(e => e.Usuario).IsUnicode(false);

                entity.Property(e => e.Xml).IsUnicode(false);
            });

            modelBuilder.Entity<EncabezadoCompra>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActividadComercial)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clave).IsUnicode(false);

                entity.Property(e => e.CondicionVenta).IsUnicode(false);

                entity.Property(e => e.ConsecutivoCompleto).IsUnicode(false);

                entity.Property(e => e.ConsecutivoIncompleto).IsUnicode(false);

                entity.Property(e => e.ConsecutivoOrigen).IsUnicode(false);

                entity.Property(e => e.CorreosAdicionales).IsUnicode(false);

                entity.Property(e => e.CorreosAdicionales1).IsUnicode(false);

                entity.Property(e => e.EmailAdicional).IsUnicode(false);

                entity.Property(e => e.EmisorCanton).IsUnicode(false);

                entity.Property(e => e.EmisorDireccion).IsUnicode(false);

                entity.Property(e => e.EmisorDistrito).IsUnicode(false);

                entity.Property(e => e.EmisorEmail).IsUnicode(false);

                entity.Property(e => e.EmisorFax).IsUnicode(false);

                entity.Property(e => e.EmisorIdentificacion).IsUnicode(false);

                entity.Property(e => e.EmisorNomComercial).IsUnicode(false);

                entity.Property(e => e.EmisorNombre).IsUnicode(false);

                entity.Property(e => e.EmisorProvincia).IsUnicode(false);

                entity.Property(e => e.EmisorTelefono).IsUnicode(false);

                entity.Property(e => e.EmisorTipo).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoEnvio).IsUnicode(false);

                entity.Property(e => e.EstadoHacienda).IsUnicode(false);

                entity.Property(e => e.MedioPago1).IsUnicode(false);

                entity.Property(e => e.MedioPago2).IsUnicode(false);

                entity.Property(e => e.MedioPago3).IsUnicode(false);

                entity.Property(e => e.MedioPago4).IsUnicode(false);

                entity.Property(e => e.MensajeEnvio).IsUnicode(false);

                entity.Property(e => e.MensajeHacienda).IsUnicode(false);

                entity.Property(e => e.Moneda).IsUnicode(false);

                entity.Property(e => e.Otros).IsUnicode(false);

                entity.Property(e => e.Pasaporte).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.ReceptorCanton).IsUnicode(false);

                entity.Property(e => e.ReceptorDireccion).IsUnicode(false);

                entity.Property(e => e.ReceptorDistrito).IsUnicode(false);

                entity.Property(e => e.ReceptorEmail).IsUnicode(false);

                entity.Property(e => e.ReceptorFax).IsUnicode(false);

                entity.Property(e => e.ReceptorIdentificacion).IsUnicode(false);

                entity.Property(e => e.ReceptorNombre).IsUnicode(false);

                entity.Property(e => e.ReceptorProvincia).IsUnicode(false);

                entity.Property(e => e.ReceptorTelefono).IsUnicode(false);

                entity.Property(e => e.ReceptorTipo).IsUnicode(false);

                entity.Property(e => e.RefClave).IsUnicode(false);

                entity.Property(e => e.RefCodigo).IsUnicode(false);

                entity.Property(e => e.RefRazon).IsUnicode(false);

                entity.Property(e => e.RefTipoDoc).IsUnicode(false);

                entity.Property(e => e.TipoDocumento).IsUnicode(false);

                entity.Property(e => e.Usuario).IsUnicode(false);

                entity.Property(e => e.Xml).IsUnicode(false);
            });

            modelBuilder.Entity<EncabezadoGasto>(entity =>
            {
                entity.HasKey(e => e.IdGasto)
                    .HasName("PK__Encabeza__C630244D27AF4D82");

                entity.Property(e => e.ActividadComercial)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clave).IsUnicode(false);

                entity.Property(e => e.EmisorTipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mensaje)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MensajeEnvio).IsUnicode(false);

                entity.Property(e => e.MensajeHacienda).IsUnicode(false);

                entity.Property(e => e.NumeroCedulaEmisor).IsUnicode(false);

                entity.Property(e => e.NumeroCedulaReceptor).IsUnicode(false);

                entity.Property(e => e.NumeroConsecutivoReceptor).IsUnicode(false);

                entity.Property(e => e.ReceptorTipo)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EncabezadoTiquete>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActividadComercial)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clave).IsUnicode(false);

                entity.Property(e => e.CondicionVenta).IsUnicode(false);

                entity.Property(e => e.ConsecutivoCompleto).IsUnicode(false);

                entity.Property(e => e.ConsecutivoIncompleto).IsUnicode(false);

                entity.Property(e => e.ConsecutivoOrigen).IsUnicode(false);

                entity.Property(e => e.CorreosAdicionales).IsUnicode(false);

                entity.Property(e => e.CorreosAdicionales1).IsUnicode(false);

                entity.Property(e => e.EmailAdicional).IsUnicode(false);

                entity.Property(e => e.EmisorCanton).IsUnicode(false);

                entity.Property(e => e.EmisorDireccion).IsUnicode(false);

                entity.Property(e => e.EmisorDistrito).IsUnicode(false);

                entity.Property(e => e.EmisorEmail).IsUnicode(false);

                entity.Property(e => e.EmisorFax).IsUnicode(false);

                entity.Property(e => e.EmisorIdentificacion).IsUnicode(false);

                entity.Property(e => e.EmisorNomComercial).IsUnicode(false);

                entity.Property(e => e.EmisorNombre).IsUnicode(false);

                entity.Property(e => e.EmisorProvincia).IsUnicode(false);

                entity.Property(e => e.EmisorTelefono).IsUnicode(false);

                entity.Property(e => e.EmisorTipo).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoEnvio).IsUnicode(false);

                entity.Property(e => e.EstadoHacienda).IsUnicode(false);

                entity.Property(e => e.MedioPago1).IsUnicode(false);

                entity.Property(e => e.MedioPago2).IsUnicode(false);

                entity.Property(e => e.MedioPago3).IsUnicode(false);

                entity.Property(e => e.MedioPago4).IsUnicode(false);

                entity.Property(e => e.MensajeEnvio).IsUnicode(false);

                entity.Property(e => e.MensajeHacienda).IsUnicode(false);

                entity.Property(e => e.Moneda).IsUnicode(false);

                entity.Property(e => e.Otros).IsUnicode(false);

                entity.Property(e => e.Pasaporte).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.ReceptorCanton).IsUnicode(false);

                entity.Property(e => e.ReceptorDireccion).IsUnicode(false);

                entity.Property(e => e.ReceptorDistrito).IsUnicode(false);

                entity.Property(e => e.ReceptorEmail).IsUnicode(false);

                entity.Property(e => e.ReceptorFax).IsUnicode(false);

                entity.Property(e => e.ReceptorIdentificacion).IsUnicode(false);

                entity.Property(e => e.ReceptorNombre).IsUnicode(false);

                entity.Property(e => e.ReceptorProvincia).IsUnicode(false);

                entity.Property(e => e.ReceptorTelefono).IsUnicode(false);

                entity.Property(e => e.ReceptorTipo).IsUnicode(false);

                entity.Property(e => e.RefClave).IsUnicode(false);

                entity.Property(e => e.RefCodigo).IsUnicode(false);

                entity.Property(e => e.RefRazon).IsUnicode(false);

                entity.Property(e => e.RefTipoDoc).IsUnicode(false);

                entity.Property(e => e.TipoDocumento).IsUnicode(false);

                entity.Property(e => e.Usuario).IsUnicode(false);

                entity.Property(e => e.Xml).IsUnicode(false);
            });

            modelBuilder.Entity<Encabezadocredito>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActividadComercial)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clave).IsUnicode(false);

                entity.Property(e => e.CondicionVenta).IsUnicode(false);

                entity.Property(e => e.ConsecutivoCompleto).IsUnicode(false);

                entity.Property(e => e.ConsecutivoIncompleto).IsUnicode(false);

                entity.Property(e => e.ConsecutivoOrigen).IsUnicode(false);

                entity.Property(e => e.CorreosAdicionales).IsUnicode(false);

                entity.Property(e => e.CorreosAdicionales1).IsUnicode(false);

                entity.Property(e => e.EmailAdicional).IsUnicode(false);

                entity.Property(e => e.EmisorCanton).IsUnicode(false);

                entity.Property(e => e.EmisorDireccion).IsUnicode(false);

                entity.Property(e => e.EmisorDistrito).IsUnicode(false);

                entity.Property(e => e.EmisorEmail).IsUnicode(false);

                entity.Property(e => e.EmisorFax).IsUnicode(false);

                entity.Property(e => e.EmisorIdentificacion).IsUnicode(false);

                entity.Property(e => e.EmisorNomComercial).IsUnicode(false);

                entity.Property(e => e.EmisorNombre).IsUnicode(false);

                entity.Property(e => e.EmisorProvincia).IsUnicode(false);

                entity.Property(e => e.EmisorTelefono).IsUnicode(false);

                entity.Property(e => e.EmisorTipo).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoEnvio).IsUnicode(false);

                entity.Property(e => e.EstadoHacienda).IsUnicode(false);

                entity.Property(e => e.MedioPago1).IsUnicode(false);

                entity.Property(e => e.MedioPago2).IsUnicode(false);

                entity.Property(e => e.MedioPago3).IsUnicode(false);

                entity.Property(e => e.MedioPago4).IsUnicode(false);

                entity.Property(e => e.MensajeEnvio).IsUnicode(false);

                entity.Property(e => e.MensajeHacienda).IsUnicode(false);

                entity.Property(e => e.Moneda).IsUnicode(false);

                entity.Property(e => e.Otros).IsUnicode(false);

                entity.Property(e => e.Pasaporte).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.ReceptorCanton).IsUnicode(false);

                entity.Property(e => e.ReceptorDireccion).IsUnicode(false);

                entity.Property(e => e.ReceptorDistrito).IsUnicode(false);

                entity.Property(e => e.ReceptorEmail).IsUnicode(false);

                entity.Property(e => e.ReceptorFax).IsUnicode(false);

                entity.Property(e => e.ReceptorIdentificacion).IsUnicode(false);

                entity.Property(e => e.ReceptorNombre).IsUnicode(false);

                entity.Property(e => e.ReceptorProvincia).IsUnicode(false);

                entity.Property(e => e.ReceptorTelefono).IsUnicode(false);

                entity.Property(e => e.ReceptorTipo).IsUnicode(false);

                entity.Property(e => e.RefClave).IsUnicode(false);

                entity.Property(e => e.RefCodigo).IsUnicode(false);

                entity.Property(e => e.RefRazon).IsUnicode(false);

                entity.Property(e => e.RefTipoDoc).IsUnicode(false);

                entity.Property(e => e.TipoDocumento).IsUnicode(false);

                entity.Property(e => e.Usuario).IsUnicode(false);

                entity.Property(e => e.Xml).IsUnicode(false);
            });

            modelBuilder.Entity<FacActividadesComerciales>(entity =>
            {
                entity.HasKey(e => e.CodigoActividad)
                    .HasName("PK_FAC_Actividades");

                entity.Property(e => e.CodigoActividad)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Actividad).IsUnicode(false);
            });

            modelBuilder.Entity<FacAplicaImpuestos>(entity =>
            {
                entity.HasKey(e => e.Tipo)
                    .HasName("PK_FAC_APLICAIMPUESTOS");

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioModifica).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacCajasIniciales>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.Login })
                    .HasName("PK_FAC_CAJASINICIALES");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.LoginNavigation)
                    .WithMany(p => p.FacCajasIniciales)
                    .HasForeignKey(d => d.Login)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_CAJA_REFERENCE_FAC_EMPL");
            });

            modelBuilder.Entity<FacCajasIniciales2>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.Login, e.Consecutivo })
                    .HasName("PK_FAC_CAJASINICIALES2");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.LoginNavigation)
                    .WithMany(p => p.FacCajasIniciales2)
                    .HasForeignKey(d => d.Login)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_CAJA_REF2_FAC_EMPL");
            });

            modelBuilder.Entity<FacCajasInicialesClientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.Periodo, e.Mes, e.Dia, e.Login })
                    .HasName("PK_FAC_CAJASINICIALESCL");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacCargaProductos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_FAC_CARGAPRODUCTOS");

                entity.Property(e => e.Codigo).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.NombreGenerico).IsUnicode(false);
            });

            modelBuilder.Entity<FacCargaProductosTemp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AplicarComision)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoBarras).IsUnicode(false);

                entity.Property(e => e.NombreClasificacion).IsUnicode(false);

                entity.Property(e => e.NombreProducto).IsUnicode(false);

                entity.Property(e => e.NombreSubClasificacion).IsUnicode(false);

                entity.Property(e => e.RequierePreparacion)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FacCierres>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.Login })
                    .HasName("PK_FAC_CIERRES");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.FacCajasIniciales)
                    .WithOne(p => p.FacCierres)
                    .HasForeignKey<FacCierres>(d => new { d.Periodo, d.Mes, d.Dia, d.Login })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_CIER_REFERENCE_FAC_CAJA");
            });

            modelBuilder.Entity<FacCierres2>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.Login, e.Consecutivo })
                    .HasName("PK_FAC_CIERRES2");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.FacCajasIniciales2)
                    .WithOne(p => p.FacCierres2)
                    .HasForeignKey<FacCierres2>(d => new { d.Periodo, d.Mes, d.Dia, d.Login, d.Consecutivo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_CIER_REF2_FAC_CAJA");
            });

            modelBuilder.Entity<FacCierresLocales>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.Periodo, e.Mes, e.Dia, e.Login })
                    .HasName("PK_FAC_CIERRESCL");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacCierresRecargas>(entity =>
            {
                entity.HasKey(e => e.NumeroRecarga)
                    .HasName("PK_FAC_RECARGAS");

                entity.Property(e => e.CodigoCuenta)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.UsuarioPaga).IsUnicode(false);
            });

            modelBuilder.Entity<FacClasificaciones>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoClasificacion)
                    .HasName("PK_FAC_CLASIFICACIONES");

                entity.Property(e => e.CodigoTipoClasificacion).ValueGeneratedNever();

                entity.Property(e => e.Cuenta).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreClasificacion).IsUnicode(false);

                entity.Property(e => e.ProductosRapidos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Promociones)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recargas)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ventas)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FacClasificacionesClientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.CodigoTipoClasificacion })
                    .HasName("PK_FAC_CLASIFICACIONESClientes");

                entity.Property(e => e.Cuenta).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreClasificacion).IsUnicode(false);

                entity.Property(e => e.ProductosRapidos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Promociones)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recargas)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ventas)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FacClientes>(entity =>
            {
                entity.HasKey(e => e.Telefono)
                    .HasName("PK_FAC_CLIENTES");

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Idcliente).IsUnicode(false);

                entity.Property(e => e.NombreCliente).IsUnicode(false);
            });

            modelBuilder.Entity<FacComandasDet>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.NumeroPedido, e.Consecutivo, e.ConsecutivoDet })
                    .HasName("PK_FAC_COMANDASDET");

                entity.Property(e => e.Linea).IsUnicode(false);

                entity.HasOne(d => d.FacComandasEnc)
                    .WithMany(p => p.FacComandasDet)
                    .HasForeignKey(d => new { d.Periodo, d.Mes, d.Dia, d.NumeroPedido, d.Consecutivo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_COMA_REFERENCE_FAC_COMA");
            });

            modelBuilder.Entity<FacComandasEnc>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.NumeroPedido, e.Consecutivo })
                    .HasName("PK_FAC_COMANDASENC");

                entity.Property(e => e.Cocina)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Impresa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreCliente).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacConceptosRetiros>(entity =>
            {
                entity.Property(e => e.CodigoConcepto).ValueGeneratedNever();

                entity.Property(e => e.Cuenta).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.EsPlanilla)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacConceptosRetirosClientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.CodigoConcepto })
                    .HasName("PK_FAC_ConceptosRetirosCl");

                entity.Property(e => e.Cuenta).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.EsPlanilla)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacControlObjetos>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Area)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idobjeto)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<FacEmpleados>(entity =>
            {
                entity.HasKey(e => e.Login)
                    .HasName("PK_FAC_EMPLEADOS");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.AplicarDescuentos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsCajero)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.UsuarioInactiva).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacEmpleadosClientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.Login })
                    .HasName("PK_FAC_EMPLEADOSCLIENTES");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.AplicarDescuentos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsCajero)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.UsuarioInactiva).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacFacturas>(entity =>
            {
                entity.HasKey(e => e.NumeroFactura)
                    .HasName("PK_FAC_FACTURAS");

                entity.Property(e => e.Area)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CedulaEnvia).IsUnicode(false);

                entity.Property(e => e.ClaveElectronica).IsUnicode(false);

                entity.Property(e => e.ClaveElectronicaCred).IsUnicode(false);

                entity.Property(e => e.CodigoMiPueblo).IsUnicode(false);

                entity.Property(e => e.ConsecutivoElectronico).IsUnicode(false);

                entity.Property(e => e.ConsecutivoElectronicoCred).IsUnicode(false);

                entity.Property(e => e.CorreoEnvia).IsUnicode(false);

                entity.Property(e => e.CorreoRecibe).IsUnicode(false);

                entity.Property(e => e.Documento).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idcliente).IsUnicode(false);

                entity.Property(e => e.Identificacion).IsUnicode(false);

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.MotivoAnulacion).IsUnicode(false);

                entity.Property(e => e.MotivoError).IsUnicode(false);

                entity.Property(e => e.MotivoRegalia).IsUnicode(false);

                entity.Property(e => e.NombreCliente).IsUnicode(false);

                entity.Property(e => e.NombreEnvia).IsUnicode(false);

                entity.Property(e => e.NumeroCertificado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Reportada)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoEnvia).IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula).IsUnicode(false);

                entity.Property(e => e.UsuarioAtiende).IsUnicode(false);

                entity.Property(e => e.UsuarioCierra).IsUnicode(false);

                entity.Property(e => e.UsuarioEntrega).IsUnicode(false);

                entity.HasOne(d => d.FacCajasIniciales)
                    .WithMany(p => p.FacFacturas)
                    .HasForeignKey(d => new { d.Periodo, d.Mes, d.Dia, d.Login })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FACT_REFERENCE_FAC_CAJA");
            });

            modelBuilder.Entity<FacFacturas2>(entity =>
            {
                entity.HasKey(e => e.NumeroFactura)
                    .HasName("PK_FAC_FACTURAS2");

                entity.Property(e => e.Area)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CedulaEnvia).IsUnicode(false);

                entity.Property(e => e.ClaveElectronica).IsUnicode(false);

                entity.Property(e => e.CodigoMiPueblo).IsUnicode(false);

                entity.Property(e => e.ConsecutivoElectronico).IsUnicode(false);

                entity.Property(e => e.CorreoEnvia).IsUnicode(false);

                entity.Property(e => e.CorreoRecibe).IsUnicode(false);

                entity.Property(e => e.Documento).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idcliente).IsUnicode(false);

                entity.Property(e => e.Identificacion).IsUnicode(false);

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.MotivoAnulacion).IsUnicode(false);

                entity.Property(e => e.MotivoError).IsUnicode(false);

                entity.Property(e => e.MotivoRegalia).IsUnicode(false);

                entity.Property(e => e.NombreCliente).IsUnicode(false);

                entity.Property(e => e.NombreEnvia).IsUnicode(false);

                entity.Property(e => e.NumeroCertificado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Reportada)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoEnvia).IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula).IsUnicode(false);

                entity.Property(e => e.UsuarioAtiende).IsUnicode(false);

                entity.Property(e => e.UsuarioCierra).IsUnicode(false);

                entity.Property(e => e.UsuarioEntrega).IsUnicode(false);
            });

            modelBuilder.Entity<FacFacturasClientes>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.CodigoLocal, e.FechaRegistra, e.NumeroFactura })
                    .HasName("INDEX_FAC_FACTURASCLIENTES")
                    .IsClustered();

                entity.Property(e => e.Area)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CedulaEnvia).IsUnicode(false);

                entity.Property(e => e.ClaveElectronica).IsUnicode(false);

                entity.Property(e => e.ClaveElectronicaCred).IsUnicode(false);

                entity.Property(e => e.CodigoMiPueblo).IsUnicode(false);

                entity.Property(e => e.ConsecutivoElectronico).IsUnicode(false);

                entity.Property(e => e.ConsecutivoElectronicoCred).IsUnicode(false);

                entity.Property(e => e.CorreoEnvia).IsUnicode(false);

                entity.Property(e => e.CorreoRecibe).IsUnicode(false);

                entity.Property(e => e.Documento).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idcliente).IsUnicode(false);

                entity.Property(e => e.Identificacion).IsUnicode(false);

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.MotivoAnulacion).IsUnicode(false);

                entity.Property(e => e.MotivoError).IsUnicode(false);

                entity.Property(e => e.MotivoRegalia).IsUnicode(false);

                entity.Property(e => e.NombreCliente).IsUnicode(false);

                entity.Property(e => e.NombreEnvia).IsUnicode(false);

                entity.Property(e => e.NumeroCertificado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Reportada)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoEnvia).IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula).IsUnicode(false);

                entity.Property(e => e.UsuarioAtiende).IsUnicode(false);

                entity.Property(e => e.UsuarioCierra).IsUnicode(false);

                entity.Property(e => e.UsuarioEntrega).IsUnicode(false);
            });

            modelBuilder.Entity<FacFacturasDet>(entity =>
            {
                entity.HasKey(e => new { e.NumeroFactura, e.Linea })
                    .HasName("PK_FAC_FACTURASDET");

                entity.Property(e => e.CodigoImpuesto)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoTarifa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoDevolucion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MotivoError).IsUnicode(false);

                entity.Property(e => e.UsuarioAprueba).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.CodigoProductoNavigation)
                    .WithMany(p => p.FacFacturasDet)
                    .HasForeignKey(d => d.CodigoProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FACT_REFERENCE_FAC_PROD");

                entity.HasOne(d => d.NumeroFacturaNavigation)
                    .WithMany(p => p.FacFacturasDet)
                    .HasForeignKey(d => d.NumeroFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FACT_REFERENCE_FAC_FACT");
            });

            modelBuilder.Entity<FacFacturasDet2>(entity =>
            {
                entity.HasKey(e => new { e.NumeroFactura, e.Linea })
                    .HasName("PK_FAC_FACTURASDET2");

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoDevolucion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MotivoError).IsUnicode(false);

                entity.Property(e => e.UsuarioAprueba).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacFacturasDetClientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.NumeroFactura, e.Linea })
                    .HasName("PK_FAC_FACTURASDETClientes");

                entity.Property(e => e.CodigoImpuesto)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoTarifa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoDevolucion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MotivoError).IsUnicode(false);

                entity.Property(e => e.UsuarioAprueba).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacFacturasDetComponentes>(entity =>
            {
                entity.HasKey(e => new { e.NumeroFactura, e.Linea, e.CodigoProducto, e.Id })
                    .HasName("PK_FAC_FACTURASDETCOMP");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MotivoError).IsUnicode(false);
            });

            modelBuilder.Entity<FacFacturasDetComponentesClientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.NumeroFactura, e.Linea, e.CodigoProducto, e.Id })
                    .HasName("PK_FAC_FACTURASDETCOMPClientes");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MotivoError).IsUnicode(false);
            });

            modelBuilder.Entity<FacHistorialPrecios>(entity =>
            {
                entity.HasKey(e => new { e.CodigoProducto, e.NumeroCambio })
                    .HasName("PK_FAC_HISTORIALPRECIOS");

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacImpresoras>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.Area, e.Cocina, e.NombrePc, e.Nombre, e.Estado })
                    .HasName("PK_FAC_IMPRESORAS");

                entity.Property(e => e.Area)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cocina)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombrePc).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FacImpuestos>(entity =>
            {
                entity.Property(e => e.CodigoImpuesto)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cuenta).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacIngredientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoProducto, e.CodigoIngrediente })
                    .HasName("pk_fac_ingredientes");

                entity.Property(e => e.TipoIngrediente)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacIngredientesClientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.CodigoProducto, e.CodigoIngrediente })
                    .HasName("pk_fac_ingredientesClientes");

                entity.Property(e => e.TipoIngrediente)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacIngresosCaja>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.Login, e.NumeroIngreso })
                    .HasName("pk_fac_ingresoscaja");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.Motivo).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacIngresosCajaClientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.Periodo, e.Mes, e.Dia, e.Login, e.NumeroIngreso })
                    .HasName("pk_fac_ingresoscajacl");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.Motivo).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacJornadas>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.CodigoLocal, e.Area, e.Login })
                    .HasName("PK_FAC_JORNADAS");

                entity.Property(e => e.Area)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAprueba).IsUnicode(false);

                entity.Property(e => e.UsuarioCierra).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.CodigoLocalNavigation)
                    .WithMany(p => p.FacJornadas)
                    .HasForeignKey(d => d.CodigoLocal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_JORN_REFERENCE_FAC_LOCA");

                entity.HasOne(d => d.LoginNavigation)
                    .WithMany(p => p.FacJornadas)
                    .HasForeignKey(d => d.Login)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_JORN_REFERENCE_FAC_EMPL");
            });

            modelBuilder.Entity<FacLocales>(entity =>
            {
                entity.HasKey(e => e.CodigoLocal)
                    .HasName("PK_FAC_LOCALES");

                entity.Property(e => e.CodigoLocal).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.SincronizarDatos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacLocalesPuntos>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cuadro)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FacLocalesUsuarios>(entity =>
            {
                entity.HasKey(e => new { e.Cedula, e.CodigoLocal })
                    .HasName("PK_FAC_LOCALESUSUARIOS");

                entity.Property(e => e.Cedula).IsUnicode(false);
            });

            modelBuilder.Entity<FacMapa>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.Area, e.TipoObjeto, e.Numero })
                    .HasName("PK_FAC_MAPA");

                entity.Property(e => e.Area)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoObjeto)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AreaNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.TipoArea)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.CodigoLocalNavigation)
                    .WithMany(p => p.FacMapa)
                    .HasForeignKey(d => d.CodigoLocal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_MAPA_REFERENCE_FAC_LOCA");
            });

            modelBuilder.Entity<FacMesas>(entity =>
            {
                entity.HasKey(e => e.NumeroMesa)
                    .HasName("PK_FAC_MESAS");

                entity.Property(e => e.NumeroMesa).ValueGeneratedNever();

                entity.Property(e => e.Ubicacion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacMisComercios>(entity =>
            {
                entity.HasKey(e => e.Idcomercio)
                    .HasName("PK_FAC_MISCOMERCIOS");

                entity.Property(e => e.Idcomercio).ValueGeneratedNever();

                entity.Property(e => e.BaseDatos).IsUnicode(false);

                entity.Property(e => e.NombreComercio).IsUnicode(false);
            });

            modelBuilder.Entity<FacPagosNube>(entity =>
            {
                entity.Property(e => e.NumeroPago).ValueGeneratedNever();

                entity.Property(e => e.CodigoCuenta)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacPaises>(entity =>
            {
                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<FacParametros>(entity =>
            {
                entity.HasKey(e => e.Idcomercio)
                    .HasName("PK_FAC_PARAMETROS");

                entity.Property(e => e.Idcomercio).ValueGeneratedNever();

                entity.Property(e => e.ActividadComercial)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AmbienteHacienda)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ArchivoFirma).IsUnicode(false);

                entity.Property(e => e.Canton)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cedula).IsUnicode(false);

                entity.Property(e => e.ControlM)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ControlMeseros)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ControlSillas).IsUnicode(false);

                entity.Property(e => e.CopiaComanda)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CopiaFactura)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CorreoEmpresa).IsUnicode(false);

                entity.Property(e => e.CorreoEnviar).IsUnicode(false);

                entity.Property(e => e.CorreoPass).IsUnicode(false);

                entity.Property(e => e.CorreoRecepcion).IsUnicode(false);

                entity.Property(e => e.Costos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Direccion2).IsUnicode(false);

                entity.Property(e => e.Distrito)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FacturaResumida).IsUnicode(false);

                entity.Property(e => e.Idpadre).IsUnicode(false);

                entity.Property(e => e.ImpresionCocina)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImprimirDetalle).IsUnicode(false);

                entity.Property(e => e.MiPueblo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreComercio).IsUnicode(false);

                entity.Property(e => e.NombreTributacion).IsUnicode(false);

                entity.Property(e => e.NumeroLocal)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PagoHuella)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PassCorreoRecepcion).IsUnicode(false);

                entity.Property(e => e.PasswordNaby).IsUnicode(false);

                entity.Property(e => e.Pin)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Provincia)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RedImpresoras)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RespaldoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SeparacionPedidos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Simbolo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefonos).IsUnicode(false);

                entity.Property(e => e.TipoCedula)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoImagen)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsarAlertaPrevia)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioNaby).IsUnicode(false);
            });

            modelBuilder.Entity<FacPedidos>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.NumeroPedido })
                    .HasName("PK_FAC_PEDIDOS");

                entity.Property(e => e.AplicarImpuestos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Area)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clave)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMiPueblo).IsUnicode(false);

                entity.Property(e => e.ComandaImpresa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DebeLlamar)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FacturasCorreo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Genero)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idcliente).IsUnicode(false);

                entity.Property(e => e.IdentificadorApp).IsUnicode(false);

                entity.Property(e => e.MotivoCancela).IsUnicode(false);

                entity.Property(e => e.NombreCliente).IsUnicode(false);

                entity.Property(e => e.PreviaImpresa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RapidoIncluido)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UbicacioUrl).IsUnicode(false);

                entity.Property(e => e.UbicacionUrl).IsUnicode(false);

                entity.Property(e => e.UsuarioCancela).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacPedidosAcciones>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.NumeroPedido, e.Linea })
                    .HasName("PK_FAC_PEDIDOSACCIONES");

                entity.Property(e => e.Accion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacPedidosAccionesCriticasCl>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.Periodo, e.Mes, e.Dia, e.NumeroPedido, e.Linea })
                    .HasName("PK_FAC_PEDIDOSACCIONESCRITCL");

                entity.Property(e => e.Accion).IsUnicode(false);

                entity.Property(e => e.EnviadoNdf)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Otros).IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioEjecuta).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacPedidosApp>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.NumeroPedido })
                    .HasName("PK_FAC_PEDIDOSAPP");

                entity.Property(e => e.Area)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clave)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMiPueblo).IsUnicode(false);

                entity.Property(e => e.ComandaImpresa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DebeLlamar)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FacturasCorreo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Genero)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idcliente).IsUnicode(false);

                entity.Property(e => e.IdentificadorApp).IsUnicode(false);

                entity.Property(e => e.MotivoCancela).IsUnicode(false);

                entity.Property(e => e.NombreCliente).IsUnicode(false);

                entity.Property(e => e.PedidoReferencia).IsUnicode(false);

                entity.Property(e => e.PreviaImpresa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RapidoIncluido)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCancela).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacPedidosComponentes>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.NumeroPedido, e.Linea, e.CodigoProducto })
                    .HasName("PK_FAC_PEDIDOSCOMPONENTES");

                entity.Property(e => e.Alerta)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacPedidosDet>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.NumeroPedido, e.Linea })
                    .HasName("PK_FAC_PEDIDOSDET");

                entity.Property(e => e.Alerta)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiPuebloCanje)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Rapido)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RapidoIncluido)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioEnvia).IsUnicode(false);

                entity.Property(e => e.UsuarioPrepara).IsUnicode(false);

                entity.Property(e => e.UsuarioPreparando).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.Property(e => e.UsuarioSirve).IsUnicode(false);

                entity.HasOne(d => d.FacPedidos)
                    .WithMany(p => p.FacPedidosDet)
                    .HasForeignKey(d => new { d.Periodo, d.Mes, d.Dia, d.NumeroPedido })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_PEDI_REFERENCE_FAC_PEDI");
            });

            modelBuilder.Entity<FacPedidosDetApp>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.NumeroPedido, e.Linea })
                    .HasName("PK_FAC_PEDIDOSDETAPP");

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiPuebloCanje)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Rapido)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RapidoIncluido)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioEnvia).IsUnicode(false);

                entity.Property(e => e.UsuarioPrepara).IsUnicode(false);

                entity.Property(e => e.UsuarioPreparando).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.Property(e => e.UsuarioSirve).IsUnicode(false);
            });

            modelBuilder.Entity<FacPedidosExtras>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Dia, e.NumeroPedido, e.Mes, e.Linea, e.CodigoProducto })
                    .HasName("pk_fac_pedidosextras");

                entity.Property(e => e.Accion)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FacPedidosExtrasApp>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Dia, e.NumeroPedido, e.Mes, e.Linea, e.CodigoProducto })
                    .HasName("pk_fac_pedidosextrasapp");

                entity.Property(e => e.Accion)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FacProductos>(entity =>
            {
                entity.HasKey(e => e.CodigoProducto)
                    .HasName("PK_FAC_PRODUCTOS");

                entity.Property(e => e.CodigoProducto).ValueGeneratedNever();

                entity.Property(e => e.AplicaServicio)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicarCashBack)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicarComision)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoBarras).IsUnicode(false);

                entity.Property(e => e.CodigoBusqueda).IsUnicode(false);

                entity.Property(e => e.CodigoTarifa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Compuesto)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsExtra)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Exento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Favoritos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idcliente).IsUnicode(false);

                entity.Property(e => e.Inventarios)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Moneda)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.NombreGenerico).IsUnicode(false);

                entity.Property(e => e.PermiteSeparacion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Prefijo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RequierePreparacion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoImagen)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.Property(e => e.UtilizarPeso)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FacProductosClientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.CodigoProducto })
                    .HasName("PK_FAC_PRODUCTOSClientes");

                entity.Property(e => e.AplicaServicio)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicarCashBack)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicarComision)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoBarras).IsUnicode(false);

                entity.Property(e => e.CodigoBusqueda).IsUnicode(false);

                entity.Property(e => e.CodigoTarifa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Compuesto)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsExtra)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Exento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Favoritos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idcliente).IsUnicode(false);

                entity.Property(e => e.Inventarios)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Moneda)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.NombreGenerico).IsUnicode(false);

                entity.Property(e => e.PermiteSeparacion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Prefijo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RequierePreparacion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoImagen)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.Property(e => e.UtilizarPeso)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FacProductosNdfclientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.CodigoProducto, e.CodigoProductoNdf })
                    .HasName("PK_FAC_PRODUCTOSNDFClientes");
            });

            modelBuilder.Entity<FacProductosProveedor>(entity =>
            {
                entity.HasKey(e => new { e.CedulaCliente, e.CodigoProducto })
                    .HasName("PK_FAC_PRODUCTOSPROV");

                entity.Property(e => e.CedulaCliente).IsUnicode(false);

                entity.Property(e => e.CodigoProductoProveedor).IsUnicode(false);
            });

            modelBuilder.Entity<FacPromociones>(entity =>
            {
                entity.HasKey(e => e.NumeroPromocion)
                    .HasName("PK_FAC_PROMOCIONES");

                entity.Property(e => e.NumeroPromocion).ValueGeneratedNever();

                entity.Property(e => e.AplicarDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicarPuntos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Domingo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Jueves)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lunes)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Martes)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Miercoles)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RestringeHoras)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sabado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPromocion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.Property(e => e.Viernes)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FacPromocionesClientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.NumeroPromocion })
                    .HasName("PK_FAC_PROMOCIONESClientes");

                entity.Property(e => e.AplicarDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicarPuntos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Domingo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Jueves)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lunes)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Martes)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Miercoles)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RestringeHoras)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sabado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPromocion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.Property(e => e.Viernes)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FacRetirosCaja>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.Login, e.NumeroRetiro })
                    .HasName("PK_FAC_RETIROSCAJA");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Motivo).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.FacCajasIniciales)
                    .WithMany(p => p.FacRetirosCaja)
                    .HasForeignKey(d => new { d.Periodo, d.Mes, d.Dia, d.Login })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_RETI_REFERENCE_FAC_CAJA");
            });

            modelBuilder.Entity<FacRetirosCaja2>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes, e.Dia, e.Login, e.Consecutivo, e.NumeroRetiro })
                    .HasName("PK_FAC_RETIROSCAJA2");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.Motivo).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.FacCajasIniciales2)
                    .WithMany(p => p.FacRetirosCaja2)
                    .HasForeignKey(d => new { d.Periodo, d.Mes, d.Dia, d.Login, d.Consecutivo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_RETI_REF2_FAC_CAJA");
            });

            modelBuilder.Entity<FacRetirosCajaClientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.Periodo, e.Mes, e.Dia, e.Login, e.NumeroRetiro })
                    .HasName("PK_FAC_RETIROSCAJACL");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Motivo).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacSeparacionPedidos>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Dia, e.Mes, e.NumeroPedido, e.Consecutivo })
                    .HasName("PK_FAC_SEPARACIONPEDIDOS");

                entity.Property(e => e.Clave)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMiPueblo).IsUnicode(false);

                entity.Property(e => e.EsExtra)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idcliente).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.TipoDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacSeparacionPedidos2>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Dia, e.Mes, e.NumeroPedido, e.Consecutivo, e.Nconsecutivo })
                    .HasName("PK_FAC_SEPARACIONPEDIDOS2");

                entity.Property(e => e.EsExtra)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacSubClasificaciones>(entity =>
            {
                entity.HasKey(e => new { e.CodigoTipoClasificacion, e.CodigoSubClasificacion })
                    .HasName("PK_FAC_SUBCLASIFICACIONES");

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Guarniciones)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreSubClasificacion).IsUnicode(false);

                entity.Property(e => e.ProductosRapidos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Promociones)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoExtra)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ventas)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodigoTipoClasificacionNavigation)
                    .WithMany(p => p.FacSubClasificaciones)
                    .HasForeignKey(d => d.CodigoTipoClasificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_SUBC_REFERENCE_FAC_CLAS");
            });

            modelBuilder.Entity<FacSubClasificacionesClientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.CodigoTipoClasificacion, e.CodigoSubClasificacion })
                    .HasName("PK_FAC_SUBCLASIFICACIONESClientes");

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Guarniciones)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreSubClasificacion).IsUnicode(false);

                entity.Property(e => e.ProductosRapidos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Promociones)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoExtra)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ventas)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FacTarifas>(entity =>
            {
                entity.HasKey(e => e.CodigoTarifa)
                    .HasName("PK_CodigoTarifa");

                entity.Property(e => e.CodigoTarifa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);
            });

            modelBuilder.Entity<FacTiposHabitaciones>(entity =>
            {
                entity.HasKey(e => e.TipoHabitacion)
                    .HasName("PK_FAC_TiposHab");

                entity.Property(e => e.TipoHabitacion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<FacUnidades>(entity =>
            {
                entity.HasKey(e => e.CodigoUnidad)
                    .HasName("PK_FAC_UNIDADES");

                entity.Property(e => e.CodigoUnidad).ValueGeneratedNever();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Siglas).IsUnicode(false);
            });

            modelBuilder.Entity<FacUnidadesClientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.CodigoUnidad })
                    .HasName("PK_FAC_UNIDADESClientes");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Siglas).IsUnicode(false);
            });

            modelBuilder.Entity<FeCorreos>(entity =>
            {
                entity.HasKey(e => e.Idcorreo)
                    .HasName("PK__FE_Corre__CDD24E1306E313A1");

                entity.Property(e => e.Idcorreo).IsUnicode(false);

                entity.Property(e => e.CorreoEmisor).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreArchivoPdf).IsUnicode(false);

                entity.Property(e => e.NombreArchivoXml1).IsUnicode(false);

                entity.Property(e => e.NombreArchivoXml2).IsUnicode(false);

                entity.Property(e => e.RecibidoDe).IsUnicode(false);

                entity.Property(e => e.Titulo).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<GrValoresConsultar>(entity =>
            {
                entity.HasKey(e => new { e.Usuario, e.Codigo })
                    .HasName("PK_GR_VALORESCONSULTAR");

                entity.Property(e => e.Usuario).IsUnicode(false);
            });

            modelBuilder.Entity<IdCamposGrid>(entity =>
            {
                entity.HasKey(e => new { e.CodigoSistema, e.NombreFormulario, e.NombreObjeto, e.MappingName })
                    .HasName("PK_ID_CAMPOSGRID");

                entity.Property(e => e.NombreFormulario).IsUnicode(false);

                entity.Property(e => e.NombreObjeto).IsUnicode(false);

                entity.Property(e => e.MappingName).IsUnicode(false);

                entity.Property(e => e.Alignment).IsUnicode(false);

                entity.Property(e => e.FalseValue)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Format).IsUnicode(false);

                entity.Property(e => e.TipoCampo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TrueValue)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdObjetos)
                    .WithMany(p => p.IdCamposGrid)
                    .HasForeignKey(d => new { d.CodigoSistema, d.NombreFormulario, d.NombreObjeto })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ID_CAMPO_REFERENCE_ID_OBJET");
            });

            modelBuilder.Entity<IdFormularios>(entity =>
            {
                entity.HasKey(e => new { e.CodigoSistema, e.NombreFormulario })
                    .HasName("PK_ID_FORMULARIOS");

                entity.Property(e => e.NombreFormulario).IsUnicode(false);

                entity.HasOne(d => d.CodigoSistemaNavigation)
                    .WithMany(p => p.IdFormularios)
                    .HasForeignKey(d => d.CodigoSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ID_FORMU_REFERENCE_SG_SISTE");
            });

            modelBuilder.Entity<IdHeaderGrid>(entity =>
            {
                entity.HasKey(e => new { e.CodigoSistema, e.NombreFormulario, e.NombreObjeto, e.MappingName, e.CodigoIdioma })
                    .HasName("PK_ID_HEADERGRID");

                entity.Property(e => e.NombreFormulario).IsUnicode(false);

                entity.Property(e => e.NombreObjeto).IsUnicode(false);

                entity.Property(e => e.MappingName).IsUnicode(false);

                entity.Property(e => e.CodigoIdioma)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valor).IsUnicode(false);

                entity.HasOne(d => d.CodigoIdiomaNavigation)
                    .WithMany(p => p.IdHeaderGrid)
                    .HasForeignKey(d => d.CodigoIdioma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ID_HEADE_REFERENCE_ID_IDIOM");

                entity.HasOne(d => d.IdCamposGrid)
                    .WithMany(p => p.IdHeaderGrid)
                    .HasForeignKey(d => new { d.CodigoSistema, d.NombreFormulario, d.NombreObjeto, d.MappingName })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ID_HEADE_REFERENCE_ID_CAMPO");
            });

            modelBuilder.Entity<IdIdiomas>(entity =>
            {
                entity.HasKey(e => e.CodigoIdioma)
                    .HasName("PK_ID_IDIOMAS");

                entity.Property(e => e.CodigoIdioma)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreIdioma).IsUnicode(false);
            });

            modelBuilder.Entity<IdObjetos>(entity =>
            {
                entity.HasKey(e => new { e.CodigoSistema, e.NombreFormulario, e.NombreObjeto })
                    .HasName("PK_ID_OBJETOS");

                entity.Property(e => e.NombreFormulario).IsUnicode(false);

                entity.Property(e => e.NombreObjeto).IsUnicode(false);

                entity.Property(e => e.EsGrid)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValorDefecto).IsUnicode(false);

                entity.HasOne(d => d.IdFormularios)
                    .WithMany(p => p.IdObjetos)
                    .HasForeignKey(d => new { d.CodigoSistema, d.NombreFormulario })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ID_OBJET_REFERENCE_ID_FORMU");
            });

            modelBuilder.Entity<IdObjetosIdiomas>(entity =>
            {
                entity.HasKey(e => new { e.CodigoSistema, e.NombreFormulario, e.NombreObjeto, e.CodigoIdioma })
                    .HasName("PK_ID_OBJETOSIDIOMAS");

                entity.Property(e => e.NombreFormulario).IsUnicode(false);

                entity.Property(e => e.NombreObjeto).IsUnicode(false);

                entity.Property(e => e.CodigoIdioma)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Valor).IsUnicode(false);

                entity.HasOne(d => d.CodigoIdiomaNavigation)
                    .WithMany(p => p.IdObjetosIdiomas)
                    .HasForeignKey(d => d.CodigoIdioma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ID_OBJET_REFERENCE_ID_IDIOM");

                entity.HasOne(d => d.IdObjetos)
                    .WithMany(p => p.IdObjetosIdiomas)
                    .HasForeignKey(d => new { d.CodigoSistema, d.NombreFormulario, d.NombreObjeto })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ID_OBJET_REFERENCE_ID_OBJET");
            });

            modelBuilder.Entity<InBodegas>(entity =>
            {
                entity.HasKey(e => e.CodigoBodega)
                    .HasName("pk_in_bodegas");

                entity.Property(e => e.CodigoBodega).ValueGeneratedNever();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.ParaVenta)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<InCierresDet>(entity =>
            {
                entity.HasKey(e => new { e.NumeroCierre, e.CodigoBodega, e.CodigoProducto })
                    .HasName("pk_in_cierresdet");
            });

            modelBuilder.Entity<InCierresInventario>(entity =>
            {
                entity.HasKey(e => e.NumeroCierre)
                    .HasName("pk_in_cierresinventario");

                entity.Property(e => e.AjusteAplicado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<InCierresR>(entity =>
            {
                entity.HasKey(e => new { e.Periodo, e.Mes })
                    .HasName("PK_IN_CIERRESR");

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<InComponentes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoProducto, e.CodigoComponente })
                    .HasName("pk_in_componentes");

                entity.Property(e => e.Cambiar)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoComponente)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<InComponentesClientes>(entity =>
            {
                entity.HasKey(e => new { e.CodigoLocal, e.CodigoProducto, e.CodigoComponente })
                    .HasName("pk_in_componentesClientes");

                entity.Property(e => e.Cambiar)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoComponente)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<InConceptos>(entity =>
            {
                entity.Property(e => e.CodigoConcepto).ValueGeneratedNever();

                entity.Property(e => e.Cuenta).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<InExistencias>(entity =>
            {
                entity.HasKey(e => new { e.CodigoBodega, e.CodigoProducto })
                    .HasName("pk_in_existencias");

                entity.Property(e => e.Cbexistencias)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<InHistoricoCostoProducto>(entity =>
            {
                entity.HasKey(e => new { e.CodigoProducto, e.Linea })
                    .HasName("pk_in_historicocostoproducto");

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<InMovimientos>(entity =>
            {
                entity.HasKey(e => e.NumeroMov)
                    .HasName("pk_in_movimientos");

                entity.Property(e => e.Cedula).IsUnicode(false);

                entity.Property(e => e.CedulaProveedor).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoRegistro)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula).IsUnicode(false);

                entity.Property(e => e.UsuarioAprueba).IsUnicode(false);

                entity.Property(e => e.UsuarioCierra).IsUnicode(false);

                entity.Property(e => e.UsuarioEnvia).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<InMovimientosDet>(entity =>
            {
                entity.HasKey(e => new { e.NumeroMov, e.Linea })
                    .HasName("pk_in_movimientosdet");

                entity.Property(e => e.Exento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDescuento)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<InPedidosDetInv>(entity =>
            {
                entity.HasKey(e => new { e.NumeroPedido, e.Linea })
                    .HasName("PK_IN_PEDIDOSDETINV");

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<InPedidosInv>(entity =>
            {
                entity.HasKey(e => e.NumeroPedido)
                    .HasName("PK_IN_PEDIDOSINV");

                entity.Property(e => e.NumeroPedido).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCancela).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<InTiposMovimientos>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoMov)
                    .HasName("pk_in_tiposmovimientos");

                entity.Property(e => e.CodigoTipoMov).ValueGeneratedNever();

                entity.Property(e => e.NombreTipoMov).IsUnicode(false);

                entity.Property(e => e.RequiereAprobacion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RequiereBodegas)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoAccion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<LineaCompra>(entity =>
            {
                entity.HasKey(e => new { e.IdEncabezado, e.NumeroLinea })
                    .HasName("PK__LineaCom__6907C991AC3A05CC");

                entity.Property(e => e.Clave).IsUnicode(false);

                entity.Property(e => e.CodigoProducto).IsUnicode(false);

                entity.Property(e => e.CodigoTarifa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Detalle).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Exoneracion1Institucion).IsUnicode(false);

                entity.Property(e => e.Exoneracion1NumeroDoc).IsUnicode(false);

                entity.Property(e => e.Exoneracion1Tipo).IsUnicode(false);

                entity.Property(e => e.Exoneracion2Institucion).IsUnicode(false);

                entity.Property(e => e.Exoneracion2NumeroDoc).IsUnicode(false);

                entity.Property(e => e.Exoneracion2Tipo).IsUnicode(false);

                entity.Property(e => e.Impuesto1Codigo).IsUnicode(false);

                entity.Property(e => e.Impuesto2Codigo).IsUnicode(false);

                entity.Property(e => e.NaturalezaDescuento).IsUnicode(false);

                entity.Property(e => e.TipoCodProducto).IsUnicode(false);

                entity.Property(e => e.UnidadMedida).IsUnicode(false);
            });

            modelBuilder.Entity<LineaNaby>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Clave).IsUnicode(false);

                entity.Property(e => e.CodigoProducto).IsUnicode(false);

                entity.Property(e => e.CodigoTarifa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Detalle).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Exoneracion1Institucion).IsUnicode(false);

                entity.Property(e => e.Exoneracion1NumeroDoc).IsUnicode(false);

                entity.Property(e => e.Exoneracion1Tipo).IsUnicode(false);

                entity.Property(e => e.Exoneracion2Institucion).IsUnicode(false);

                entity.Property(e => e.Exoneracion2NumeroDoc).IsUnicode(false);

                entity.Property(e => e.Exoneracion2Tipo).IsUnicode(false);

                entity.Property(e => e.Impuesto1Codigo).IsUnicode(false);

                entity.Property(e => e.Impuesto2Codigo).IsUnicode(false);

                entity.Property(e => e.NaturalezaDescuento).IsUnicode(false);

                entity.Property(e => e.TipoCodProducto).IsUnicode(false);

                entity.Property(e => e.UnidadMedida).IsUnicode(false);
            });

            modelBuilder.Entity<LineaTiquete>(entity =>
            {
                entity.HasKey(e => new { e.IdEncabezado, e.NumeroLinea })
                    .HasName("PK__LineaTiq__6907C991F846DA56");

                entity.Property(e => e.Clave).IsUnicode(false);

                entity.Property(e => e.CodigoProducto).IsUnicode(false);

                entity.Property(e => e.CodigoTarifa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Detalle).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Exoneracion1Institucion).IsUnicode(false);

                entity.Property(e => e.Exoneracion1NumeroDoc).IsUnicode(false);

                entity.Property(e => e.Exoneracion1Tipo).IsUnicode(false);

                entity.Property(e => e.Exoneracion2Institucion).IsUnicode(false);

                entity.Property(e => e.Exoneracion2NumeroDoc).IsUnicode(false);

                entity.Property(e => e.Exoneracion2Tipo).IsUnicode(false);

                entity.Property(e => e.Impuesto1Codigo).IsUnicode(false);

                entity.Property(e => e.Impuesto2Codigo).IsUnicode(false);

                entity.Property(e => e.NaturalezaDescuento).IsUnicode(false);

                entity.Property(e => e.TipoCodProducto).IsUnicode(false);

                entity.Property(e => e.UnidadMedida).IsUnicode(false);
            });

            modelBuilder.Entity<Lineacredito>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Clave).IsUnicode(false);

                entity.Property(e => e.CodigoProducto).IsUnicode(false);

                entity.Property(e => e.CodigoTarifa)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Detalle).IsUnicode(false);

                entity.Property(e => e.EnviadoNube)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Exoneracion1Institucion).IsUnicode(false);

                entity.Property(e => e.Exoneracion1NumeroDoc).IsUnicode(false);

                entity.Property(e => e.Exoneracion1Tipo).IsUnicode(false);

                entity.Property(e => e.Exoneracion2Institucion).IsUnicode(false);

                entity.Property(e => e.Exoneracion2NumeroDoc).IsUnicode(false);

                entity.Property(e => e.Exoneracion2Tipo).IsUnicode(false);

                entity.Property(e => e.Impuesto1Codigo).IsUnicode(false);

                entity.Property(e => e.Impuesto2Codigo).IsUnicode(false);

                entity.Property(e => e.NaturalezaDescuento).IsUnicode(false);

                entity.Property(e => e.TipoCodProducto).IsUnicode(false);

                entity.Property(e => e.UnidadMedida).IsUnicode(false);
            });

            modelBuilder.Entity<MctCambioSemanal>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctCambiosHorarios>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ApruebaFuncionario).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoAplica)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula).IsUnicode(false);

                entity.Property(e => e.UsuarioAprueba).IsUnicode(false);

                entity.Property(e => e.UsuarioEnvia).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctCargaMarcas>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Modificado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoAlmuerzo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoRegistro)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioModifica).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctCargaMarcasIm>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Modificado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoRegistro)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctCierresMes>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAprueba).IsUnicode(false);

                entity.Property(e => e.UsuarioIncluye).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctCierresMesDet>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctDiasImprevistos>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctEmpleadosCambiados>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.UsuarioModifica).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctEmpleadosMarcasEspeciales>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NombreEmpleado).IsUnicode(false);

                entity.Property(e => e.TipoMarca)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctHorarios>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.UsuarioModifica).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctHorariosHistorico>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctHuellasEmpleados>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Dedo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mano)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Principal)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctJustificaciones>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Justifica)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoUsuario)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula).IsUnicode(false);

                entity.Property(e => e.UsuarioAprueba).IsUnicode(false);

                entity.Property(e => e.UsuarioEnvia).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctMinutosGracia>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctPermisosCambiosHorario>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PermiteMismoDia)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctTemporalMarcas>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Dia).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.Modalidad)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Problema)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<MctTiposJustificaciones>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Rebaja)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<ObjetosBd>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("PK_OBJETOSBD");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.BaseDatos).IsUnicode(false);

                entity.Property(e => e.DescripcionUsuario).IsUnicode(false);

                entity.Property(e => e.NombreArchivo).IsUnicode(false);

                entity.Property(e => e.TipoObjeto)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrtPlanes>(entity =>
            {
                entity.HasKey(e => new { e.Login, e.NumeroPlan })
                    .HasName("PK_ORT_PLANES");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombrePlan).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.LoginNavigation)
                    .WithMany(p => p.OrtPlanes)
                    .HasForeignKey(d => d.Login)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORT_PLAN_REFERENCE_FAC_EMPL");
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.HasKey(e => e.CodigoPais)
                    .HasName("PK_PAISES");

                entity.Property(e => e.CodigoPais)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombrePais).IsUnicode(false);
            });

            modelBuilder.Entity<RepCargarCombos>(entity =>
            {
                entity.HasKey(e => new { e.Nombre, e.NombreObjetoNet, e.NombreCampo })
                    .HasName("PK_REP_CARGARCOMBOS");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.NombreObjetoNet).IsUnicode(false);

                entity.Property(e => e.NombreCampo).IsUnicode(false);

                entity.Property(e => e.NombreTabla).IsUnicode(false);

                entity.Property(e => e.TipoCampo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCarga)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDato)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.NombreNavigation)
                    .WithMany(p => p.RepCargarCombos)
                    .HasForeignKey(d => new { d.Nombre, d.NombreObjetoNet })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REP_CARG_REFERENCE_REP_PARA");
            });

            modelBuilder.Entity<RepCheckConstraint>(entity =>
            {
                entity.HasKey(e => new { e.Nombre, e.NombreObjetoNet, e.NombreCampo, e.Valor })
                    .HasName("PK_REP_CHECKCONSTRAINT");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.NombreObjetoNet).IsUnicode(false);

                entity.Property(e => e.NombreCampo).IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.HasOne(d => d.NombreNavigation)
                    .WithMany(p => p.RepCheckConstraint)
                    .HasForeignKey(d => new { d.Nombre, d.NombreObjetoNet, d.NombreCampo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REP_CHEC_REFERENCE_REP_CARG");
            });

            modelBuilder.Entity<RepParametrosObjetosDb>(entity =>
            {
                entity.HasKey(e => new { e.Nombre, e.NombreObjetoNet })
                    .HasName("PK_REP_PARAMETROSOBJETOSBD");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.NombreObjetoNet).IsUnicode(false);

                entity.Property(e => e.DescripcionLabel).IsUnicode(false);

                entity.Property(e => e.NombreBd).IsUnicode(false);

                entity.Property(e => e.ObjetoNet)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDato)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValorTodos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.NombreNavigation)
                    .WithMany(p => p.RepParametrosObjetosDb)
                    .HasForeignKey(d => d.Nombre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REP_PARA_REFERENCE_OBJETOSB");
            });

            modelBuilder.Entity<RepUsuarioColumnasFiltro>(entity =>
            {
                entity.HasKey(e => new { e.Login, e.NumeroColumna })
                    .HasName("PK_REP_USUARIOCOLUMNASFILTRO");

                entity.Property(e => e.Login).IsUnicode(false);
            });

            modelBuilder.Entity<RepUsuariosReportes>(entity =>
            {
                entity.HasKey(e => new { e.Login, e.Nombre })
                    .HasName("PK_REP_USUARIOSREPORTES");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.LoginNavigation)
                    .WithMany(p => p.RepUsuariosReportes)
                    .HasForeignKey(d => d.Login)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REP_USUA_REFERENCE_SG_USUAR");

                entity.HasOne(d => d.NombreNavigation)
                    .WithMany(p => p.RepUsuariosReportes)
                    .HasForeignKey(d => d.Nombre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REP_USUA_REFERENCE_OBJETOSB");
            });

            modelBuilder.Entity<RhAcciones>(entity =>
            {
                entity.HasKey(e => e.NumeroAccion)
                    .HasName("PK_RH_ACCIONES");

                entity.Property(e => e.AplicaFechaHasta)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Documento).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.TipoAccion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula).IsUnicode(false);

                entity.Property(e => e.UsuarioAprueba).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.CodigoEmpleadoNavigation)
                    .WithMany(p => p.RhAcciones)
                    .HasForeignKey(d => d.CodigoEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RH_ACCIO_RH_EMPLE");
            });

            modelBuilder.Entity<RhCantones>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<RhDepartamentos>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NombreDepartamento).IsUnicode(false);
            });

            modelBuilder.Entity<RhDistritos>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Distrito).IsUnicode(false);
            });

            modelBuilder.Entity<RhEmpleados>(entity =>
            {
                entity.HasKey(e => e.CodigoEmpleado)
                    .HasName("PK_RH_EMPLEADOS");

                entity.Property(e => e.CodigoEmpleado).ValueGeneratedNever();

                entity.Property(e => e.Apellido1).IsUnicode(false);

                entity.Property(e => e.Apellido2).IsUnicode(false);

                entity.Property(e => e.CedulaEmpleado).IsUnicode(false);

                entity.Property(e => e.ClaseJornada).IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Correo).IsUnicode(false);

                entity.Property(e => e.CorreoValidado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaCliente)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DedExclusiva)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.EstadoCivil)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoPuesto)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Extension).IsUnicode(false);

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.NivelAcademico)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.NombreEmpleado).IsUnicode(false);

                entity.Property(e => e.NumeroAsegurado).IsUnicode(false);

                entity.Property(e => e.Profesional)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RebajarCcss)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sexo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefonos).IsUnicode(false);

                entity.Property(e => e.TipoSalario)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<RhEmpleadosMov>(entity =>
            {
                entity.HasKey(e => new { e.CodigoEmpleado, e.CodigoMovimiento })
                    .HasName("PK_RH_EMPLEADOSMOV");

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<RhExpedienteEmpleado>(entity =>
            {
                entity.HasKey(e => new { e.PeriodoArchivo, e.ConsecutivoArchivo })
                    .HasName("pk_rh_expedienteempleado");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<RhFeriados>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<RhMovSaldos>(entity =>
            {
                entity.HasKey(e => e.Idoperacion)
                    .HasName("PK_Saldos");

                entity.Property(e => e.Idoperacion).ValueGeneratedNever();

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<RhMovimientos>(entity =>
            {
                entity.HasKey(e => e.CodigoMovimiento)
                    .HasName("PK_Movimientos");

                entity.Property(e => e.CodigoMovimiento).ValueGeneratedNever();

                entity.Property(e => e.AfectaTodos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicaAguinaldo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicaBp)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicaCcss)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicaDeducPorc)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicaEmbargo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicaImpuesto)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicaRiesgos)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicaSalarioEscolar)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cedula)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoArticulo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPresupuesto).IsUnicode(false);

                entity.Property(e => e.CuentaCliente)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaContable).IsUnicode(false);

                entity.Property(e => e.CuentaPasivo).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.IndicadorCs)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Momento)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreCuenta).IsUnicode(false);

                entity.Property(e => e.PlanPension)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Porcentual)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoComponente)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoMovimiento)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RhMovimientosExtra>(entity =>
            {
                entity.HasKey(e => new { e.CodigoEmpleado, e.CodigoMovimiento, e.Consecutivo })
                    .HasName("PK_RH_MOVIMIENTOSEXTRA");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.CodigoEmpleadoNavigation)
                    .WithMany(p => p.RhMovimientosExtra)
                    .HasForeignKey(d => d.CodigoEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RH_MOVIM_REFERENCE_RH_EMPLE");

                entity.HasOne(d => d.CodigoMovimientoNavigation)
                    .WithMany(p => p.RhMovimientosExtra)
                    .HasForeignKey(d => d.CodigoMovimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RH_MOVIM_REFERENCE_RH_MOVIM");
            });

            modelBuilder.Entity<RhOcupacionesCcss>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<RhOcupacionesIns>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<RhParametros>(entity =>
            {
                entity.HasKey(e => e.ConsecutivoParam)
                    .HasName("PK_RH_PARAMETROS");

                entity.Property(e => e.ConsecutivoParam).ValueGeneratedNever();

                entity.Property(e => e.Correo).IsUnicode(false);

                entity.Property(e => e.FormaExtras)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InicioHoraRoja)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LeyendaComprobante).IsUnicode(false);

                entity.Property(e => e.PassCorreo).IsUnicode(false);

                entity.Property(e => e.Redondear)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RhPlanilla>(entity =>
            {
                entity.HasKey(e => new { e.PeriodoPlanilla, e.CodigoEmpleado, e.NumeroPlanilla, e.CodigoMovimiento })
                    .HasName("PK_RH_PLANILLA");

                entity.Property(e => e.PagarExtras)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RebajarCcss)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoSalario)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.HasOne(d => d.CodigoEmpleadoNavigation)
                    .WithMany(p => p.RhPlanilla)
                    .HasForeignKey(d => d.CodigoEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RH_PLANI_REFERENCE_RH_EMPLE");

                entity.HasOne(d => d.CodigoMovimientoNavigation)
                    .WithMany(p => p.RhPlanilla)
                    .HasForeignKey(d => d.CodigoMovimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RH_PLANI_REFERENCE_RH_MOVIM");
            });

            modelBuilder.Entity<RhPlanillaDet>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Clave).IsUnicode(false);

                entity.Property(e => e.CodigoProducto).IsUnicode(false);

                entity.Property(e => e.Detalle).IsUnicode(false);

                entity.Property(e => e.Exoneracion1Institucion).IsUnicode(false);

                entity.Property(e => e.Exoneracion1NumeroDoc).IsUnicode(false);

                entity.Property(e => e.Exoneracion1Tipo).IsUnicode(false);

                entity.Property(e => e.Exoneracion2Institucion).IsUnicode(false);

                entity.Property(e => e.Exoneracion2NumeroDoc).IsUnicode(false);

                entity.Property(e => e.Exoneracion2Tipo).IsUnicode(false);

                entity.Property(e => e.Impuesto1Codigo).IsUnicode(false);

                entity.Property(e => e.Impuesto2Codigo).IsUnicode(false);

                entity.Property(e => e.NaturalezaDescuento).IsUnicode(false);

                entity.Property(e => e.TipoCodProducto).IsUnicode(false);

                entity.Property(e => e.UnidadMedida).IsUnicode(false);
            });

            modelBuilder.Entity<RhPlanillaEnc>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Clave).IsUnicode(false);

                entity.Property(e => e.CondicionVenta).IsUnicode(false);

                entity.Property(e => e.ConsecutivoCompleto).IsUnicode(false);

                entity.Property(e => e.ConsecutivoIncompleto).IsUnicode(false);

                entity.Property(e => e.ConsecutivoOrigen).IsUnicode(false);

                entity.Property(e => e.CorreosAdicionales).IsUnicode(false);

                entity.Property(e => e.CorreosAdicionales1).IsUnicode(false);

                entity.Property(e => e.EmailAdicional).IsUnicode(false);

                entity.Property(e => e.EmisorCanton).IsUnicode(false);

                entity.Property(e => e.EmisorDireccion).IsUnicode(false);

                entity.Property(e => e.EmisorDistrito).IsUnicode(false);

                entity.Property(e => e.EmisorEmail).IsUnicode(false);

                entity.Property(e => e.EmisorFax).IsUnicode(false);

                entity.Property(e => e.EmisorIdentificacion).IsUnicode(false);

                entity.Property(e => e.EmisorNomComercial).IsUnicode(false);

                entity.Property(e => e.EmisorNombre).IsUnicode(false);

                entity.Property(e => e.EmisorProvincia).IsUnicode(false);

                entity.Property(e => e.EmisorTelefono).IsUnicode(false);

                entity.Property(e => e.EmisorTipo).IsUnicode(false);

                entity.Property(e => e.EstadoEnvio).IsUnicode(false);

                entity.Property(e => e.EstadoHacienda).IsUnicode(false);

                entity.Property(e => e.MedioPago1).IsUnicode(false);

                entity.Property(e => e.MedioPago2).IsUnicode(false);

                entity.Property(e => e.MedioPago3).IsUnicode(false);

                entity.Property(e => e.MedioPago4).IsUnicode(false);

                entity.Property(e => e.MensajeEnvio).IsUnicode(false);

                entity.Property(e => e.MensajeHacienda).IsUnicode(false);

                entity.Property(e => e.Moneda).IsUnicode(false);

                entity.Property(e => e.Otros).IsUnicode(false);

                entity.Property(e => e.Pasaporte).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.ReceptorCanton).IsUnicode(false);

                entity.Property(e => e.ReceptorDireccion).IsUnicode(false);

                entity.Property(e => e.ReceptorDistrito).IsUnicode(false);

                entity.Property(e => e.ReceptorEmail).IsUnicode(false);

                entity.Property(e => e.ReceptorFax).IsUnicode(false);

                entity.Property(e => e.ReceptorIdentificacion).IsUnicode(false);

                entity.Property(e => e.ReceptorNombre).IsUnicode(false);

                entity.Property(e => e.ReceptorProvincia).IsUnicode(false);

                entity.Property(e => e.ReceptorTelefono).IsUnicode(false);

                entity.Property(e => e.ReceptorTipo).IsUnicode(false);

                entity.Property(e => e.RefClave).IsUnicode(false);

                entity.Property(e => e.RefCodigo).IsUnicode(false);

                entity.Property(e => e.RefRazon).IsUnicode(false);

                entity.Property(e => e.RefTipoDoc).IsUnicode(false);

                entity.Property(e => e.TipoDocumento).IsUnicode(false);

                entity.Property(e => e.Usuario).IsUnicode(false);

                entity.Property(e => e.Xml).IsUnicode(false);
            });

            modelBuilder.Entity<RhProfesiones>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NombreProfesion).IsUnicode(false);

                entity.Property(e => e.UsuarioModifica).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<RhProgramas>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<RhProvincias>(entity =>
            {
                entity.HasKey(e => new { e.CodigoPais, e.CodigoProvincia })
                    .HasName("PK_AD_PROVINCIAS");

                entity.Property(e => e.NombreProvincia).IsUnicode(false);
            });

            modelBuilder.Entity<RhPuestosSalariales>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<RhTiposAcciones>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AceptaFechaHasta)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicaAccionPlaza)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Automatica)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.JustificaMarca)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TextoAccion).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<RhTiposDocumentos>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Prefijo)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<RhUnidades>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NombreUnidad).IsUnicode(false);
            });

            modelBuilder.Entity<SgBitacora>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("pk_sg_bitacora");

                entity.Property(e => e.Enviado)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MotivoError).IsUnicode(false);

                entity.Property(e => e.UsuarioEnvia).IsUnicode(false);
            });

            modelBuilder.Entity<SgMenuSistemas>(entity =>
            {
                entity.HasKey(e => new { e.CodigoMenu, e.CodigoSistema })
                    .HasName("PK_SG_MENUSISTEMAS");

                entity.Property(e => e.DescripcionMenu).IsUnicode(false);

                entity.Property(e => e.EstadoMenu)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<SgOpcionesMenu>(entity =>
            {
                entity.HasKey(e => new { e.CodigoOpcion, e.CodigoMenu, e.CodigoSistema })
                    .HasName("PK_SG_OPCIONESMENU");

                entity.Property(e => e.DescripcionOpcion).IsUnicode(false);

                entity.Property(e => e.EstadoOpcion)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImagenOpcion).IsUnicode(false);

                entity.Property(e => e.SietePulgadas)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<SgOpcionesUsuario>(entity =>
            {
                entity.HasKey(e => new { e.CodigoOpcion, e.CodigoMenu, e.CodigoSistema, e.Cedula })
                    .HasName("PK_SG_OPCIONESUSUARIO");

                entity.Property(e => e.Cedula).IsUnicode(false);
            });

            modelBuilder.Entity<SgSistemas>(entity =>
            {
                entity.HasKey(e => e.CodigoSistema)
                    .HasName("PK_SG_SISTEMAS");

                entity.Property(e => e.CodigoSistema).ValueGeneratedNever();

                entity.Property(e => e.DescripcionSistema).IsUnicode(false);

                entity.Property(e => e.EsWeb)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoSistema)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);
            });

            modelBuilder.Entity<SgUsuarios>(entity =>
            {
                entity.HasKey(e => e.Cedula)
                    .HasName("PK_SG_USUARIOS");

                entity.Property(e => e.Cedula).IsUnicode(false);

                entity.Property(e => e.Cambiar)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoIdioma)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoUsuario)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModificarPrecios)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.PrimerApellido).IsUnicode(false);

                entity.Property(e => e.SegundoApellido).IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra).IsUnicode(false);

                entity.Property(e => e.Verifica).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
