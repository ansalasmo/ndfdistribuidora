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
        public string MontoExpressString { get; set; }
        public char Estado { get; set; }
        public int CodigoLocal { get; set; }
        public decimal NumeroFactura { get; set; }
        public decimal MontoTotal { get; set; }
         // E = Efectivo, T = Tarjeta, D = Deposito, M = Ambos (Tarjeta y Efectivo)
        public char FormaPago { get; set; }
        public decimal Efectivo { get; set; }
        public string EfectivoString { get; set; }


        public string MontoTotalString { get; set; }

        public string TotalFinal { get; set; }
        

    }
}
