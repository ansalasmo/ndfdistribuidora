using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DdfDistribuidoraApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DdfDistribuidoraApi.Controllers
{
    [Route("PedidosExpress")]
    [ApiController]
    public class PedidosExpressController : ControllerBase
    { 
        private readonly NdfDistribuidoraContext context;

        public PedidosExpressController(NdfDistribuidoraContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public ActionResult GetPedidosPendiente()
        {
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection(); // para obtener la conexion con la BD/
            List <PedidoExpress> listado = new List<PedidoExpress>(); 
            try
            {  
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.CommandText = "FAC_TraerPedidosPendientes"; 
                SqlDataReader reader = command.ExecuteReader(); 
                while (reader.Read())
                {
                    var objetoPedido = new PedidoExpress()
                    {
                        Comercio = Convert.ToString(reader["Comercio"]),
                        LatitudOrigen = Convert.ToString(reader["LatitudOrigen"]),
                        LongitudOrigen = Convert.ToString(reader["LongitudOrigen"]),
                        Cliente = Convert.ToString(reader["Cliente"]),
                        LatitudDestino = Convert.ToString(reader["LatitudDestino"]),
                        LongitudDestino = Convert.ToString(reader["LongitudDestino"]),
                        Telefono = Convert.ToString(reader["Telefono"]),
                        Direccion = Convert.ToString(reader["Direccion"]),
                        Periodo = Convert.ToInt32(reader["Periodo"]),
                        Mes = Convert.ToInt32(reader["Mes"]),
                        Dia = Convert.ToInt32(reader["Dia"]),
                        NumeroPedido = Convert.ToInt32(reader["NumeroPedido"])  
                    }; 
                    listado.Add(objetoPedido); 
                } 
            }
            catch (Exception e)
            {
                return BadRequest( "No se pudo traer la lista de pedidos del local" + e.Message );
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return Ok(listado);

        }

    }
}