using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DdfDistribuidoraApi.Models
{
    public class PedidoExpress
    {
        public string Correo { get; set; }
        public string Comercio { get; set; }
        public string LatitudOrigen { get; set; }
        public string LongitudOrigen { get; set; }
        public string Cliente { get; set; } 
        public string LatitudDestino { get; set; }
        public string LongitudDestino { get; set; } 
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int Periodo { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
        public int NumeroPedido { get; set; }
        public decimal Distancia { get; set; }
        public decimal MontoExpress { get; set; }
        public char Estado { get; set; }
        public int CodigoLocal { get; set; }

        public int NumeroFactura { get; set; }
        
    }
}
