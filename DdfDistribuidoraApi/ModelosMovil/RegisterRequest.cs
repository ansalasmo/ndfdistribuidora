using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DdfDistribuidoraApi.ModelosMovil
{
    public class RegisterRequest
    {
        public string Nombre { get; set; } 
        //En el app se trata con apellidos
        public string Apellidos { get; set; }  
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int CodigoProvincia { get; set; }
        public string NombreProvincia{ get; set; }
        public int CodigoCanton { get; set; }
        public string NombreCanton { get; set; }
        public int CodigoDistrito { get; set; }
        public char TipoVehiculo { get; set; }
        public string Placa { get; set; }
        public string Password { get; set; }
        public int? CodigoLocal { get; set; }
        public char? Estado  { get; set; }
    }
}
