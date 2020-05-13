using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DdfDistribuidoraApi.Helpers
{
    public interface IOSRMRouteService
    {
        Task<DirectionResponse> GetDirectionResponseAsync(string latitudOrigen, string longitudOrigen, string latitudDestino, string longitudDestino);
    }
}
