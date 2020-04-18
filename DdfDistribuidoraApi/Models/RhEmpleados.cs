using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("RH_Empleados")]
    public partial class RhEmpleados
    {
        public RhEmpleados()
        {
            RhAcciones = new HashSet<RhAcciones>();
            RhMovimientosExtra = new HashSet<RhMovimientosExtra>();
            RhPlanilla = new HashSet<RhPlanilla>();
        }

        [Key]
        public int CodigoEmpleado { get; set; }
        [Required]
        [StringLength(50)]
        public string NombreEmpleado { get; set; }
        [Required]
        [StringLength(15)]
        public string CedulaEmpleado { get; set; }
        [StringLength(20)]
        public string NumeroAsegurado { get; set; }
        public int CodigoPrograma { get; set; }
        public int CodigoDepartamento { get; set; }
        public int CodigoUnidad { get; set; }
        public int CodigoOcupacion { get; set; }
        [Required]
        [StringLength(3)]
        public string ClaseJornada { get; set; }
        public int CodigoProvincia { get; set; }
        public int CodigoCanton { get; set; }
        public int CodigoDistrito { get; set; }
        [Required]
        [StringLength(1)]
        public string EstadoPuesto { get; set; }
        [Required]
        [StringLength(1)]
        public string DedExclusiva { get; set; }
        public short NumeroHijos { get; set; }
        [Required]
        [StringLength(1)]
        public string EstadoCivil { get; set; }
        [Required]
        [StringLength(1)]
        public string Profesional { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FecIngreso { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecSalida { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FecNacimiento { get; set; }
        [Column("CodigoPuestoES")]
        public int CodigoPuestoEs { get; set; }
        public int? TipoIdentificacion { get; set; }
        [Required]
        [StringLength(20)]
        public string Apellido1 { get; set; }
        [Required]
        [StringLength(20)]
        public string Apellido2 { get; set; }
        [Required]
        [StringLength(60)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(30)]
        public string Login { get; set; }
        [StringLength(60)]
        public string Correo { get; set; }
        [Required]
        [StringLength(1)]
        public string CorreoValidado { get; set; }
        [StringLength(1)]
        public string NivelAcademico { get; set; }
        [StringLength(1)]
        public string Sexo { get; set; }
        [Required]
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaRegistra { get; set; }
        [StringLength(255)]
        public string Direccion { get; set; }
        [StringLength(50)]
        public string Telefonos { get; set; }
        [StringLength(50)]
        public string Extension { get; set; }
        [StringLength(17)]
        public string CuentaCliente { get; set; }
        public int? CodigoPuesto { get; set; }
        [Column("CodigoOcupacionINS")]
        public int CodigoOcupacionIns { get; set; }
        public int? CodigoProfesion { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Salario { get; set; }
        public int? HorasSemana { get; set; }
        [StringLength(1)]
        public string TipoSalario { get; set; }
        [StringLength(4)]
        public string Codigo { get; set; }
        [Column("RebajarCCSS")]
        [StringLength(1)]
        public string RebajarCcss { get; set; }
        [Column("ValorRebajarCCSS", TypeName = "decimal(18, 2)")]
        public decimal? ValorRebajarCcss { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? HoraExtra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaVacaciones { get; set; }
        public int? DiaLibres { get; set; }

        [InverseProperty("CodigoEmpleadoNavigation")]
        public virtual ICollection<RhAcciones> RhAcciones { get; set; }
        [InverseProperty("CodigoEmpleadoNavigation")]
        public virtual ICollection<RhMovimientosExtra> RhMovimientosExtra { get; set; }
        [InverseProperty("CodigoEmpleadoNavigation")]
        public virtual ICollection<RhPlanilla> RhPlanilla { get; set; }
    }
}
