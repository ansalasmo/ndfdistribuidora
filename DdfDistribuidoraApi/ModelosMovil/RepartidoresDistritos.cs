using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DdfDistribuidoraApi.ModelosMovil
{
    public class RepartidoresDistritos
    { 
        public string CorreoRepartidor { get; set; }
        public int CodigoProvincia { get; set; }
        public int CodigoCanton { get; set; }
        public string CodigoDistrito { get; set; }
    }
}
