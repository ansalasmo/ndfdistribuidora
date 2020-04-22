using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DdfDistribuidoraApi.ModelosMovil
{
   
    public class RegisterRequest
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int CodigoProvincia { get; set; }
        public int CodigoCanton { get; set; }
        public int CodigoDistrito { get; set; }
        public char TipoVehiculo { get; set; }
        public string Placa { get; set; }
        public string Password { get; set; }
        public int? CodigoLocal { get; set; }
    }
}
