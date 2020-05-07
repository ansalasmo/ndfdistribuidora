using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DdfDistribuidoraApi.ModelosMovil
{
    public class PedidosSend
    { 
        public DateTime Fecha { get; set; }
        public int Periodo { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
        public int NumeroPedido { get; set; }
        public string CorreoRepartidor { get; set; }
        public int CodigoLocal { get; set; }
    }
}
