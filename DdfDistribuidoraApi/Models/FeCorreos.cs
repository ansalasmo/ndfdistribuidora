using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DdfDistribuidoraApi.Models
{
    [Table("FE_Correos")]
    public partial class FeCorreos
    {
        [Key]
        [Column("IDCorreo")]
        [StringLength(100)]
        public string Idcorreo { get; set; }
        [StringLength(255)]
        public string RecibidoDe { get; set; }
        [StringLength(255)]
        public string Titulo { get; set; }
        [StringLength(255)]
        public string CorreoEmisor { get; set; }
        [Column("NombreArchivoPDF")]
        [StringLength(255)]
        public string NombreArchivoPdf { get; set; }
        [Column("NombreArchivoXML1")]
        [StringLength(255)]
        public string NombreArchivoXml1 { get; set; }
        [Column("NombreArchivoXML2")]
        [StringLength(255)]
        public string NombreArchivoXml2 { get; set; }
        [Column("ArchivoPDF")]
        public byte[] ArchivoPdf { get; set; }
        [Column("ArchivoXML1")]
        public byte[] ArchivoXml1 { get; set; }
        [Column("ArchivoXML2")]
        public byte[] ArchivoXml2 { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(20)]
        public string UsuarioRegistra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistra { get; set; }
    }
}
