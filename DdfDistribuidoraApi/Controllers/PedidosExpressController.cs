using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DdfDistribuidoraApi.ModelosMovil;
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
        [Route("GetPedidosPendiente")]
        [HttpPost]
        public ActionResult GetPedidosPendiente([FromBody] LoginRequest model)
        {          
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            List<PedidoExpress> listado = new List<PedidoExpress>();
            try
            {
                SqlCommand command = connection.CreateCommand(); 
                command.CommandType = CommandType.StoredProcedure; 
                connection.Open(); 
                command.CommandText = "FAC_TraerPedidosPendientes";
                command.Parameters.Add("@Correo", SqlDbType.VarChar, 100).Value = model.Correo;
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
                        NumeroPedido = Convert.ToInt32(reader["NumeroPedido"]),
                        Distancia = Convert.ToDecimal(reader["Distancia"]),
                        MontoExpress = Convert.ToDecimal(reader["MontoExpress"])
                    };
                    listado.Add(objetoPedido);
                }
            }
            catch (Exception e)
            {
                return BadRequest("No se pudo traer la lista de pedidos del local" + e.Message);
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
        [Route("SetPedidoAsignado")]
        [HttpGet]
        public ActionResult SetPedidoAsignado(DateTime? fecha, int periodo, int mes, int dia, int numeroPedido, string correoRepartidor)
        {
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            string respuesta = "";
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.CommandText = "Fac_ActualizarRepartidorPed";
                command.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
                command.Parameters.Add("@periodo", SqlDbType.Int).Value = periodo;
                command.Parameters.Add("@mes", SqlDbType.Int).Value = mes;
                command.Parameters.Add("@dia", SqlDbType.Int).Value = dia;
                command.Parameters.Add("@numeroPedido", SqlDbType.Int).Value = numeroPedido;
                command.Parameters.Add("@correoRepartidor", SqlDbType.VarChar, 100).Value = correoRepartidor;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    respuesta = Convert.ToString(reader["respuesta"]);
                }
            }
            catch (Exception e)
            {
                return BadRequest("Error inesperado antes de realizar el UPDATE, no se pudo actualizar el pedido" + e.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return Ok(respuesta);
        }
        [Route("GetCantones")]
        [HttpPost]  
        public ActionResult GetCantones([FromBody]Lugares model)
        { 
          return  Ok(context.RhCantones.Where(x => x.CodigoProvincia == model.IdProvincia).ToList());  
        }
         


        [Route("GetDistritos")]
        [HttpPost]
        public ActionResult GetDistritos([FromBody]Lugares model)
        {
            return Ok(context.RhDistritos.Where(x => x.CodigoCanton == model.IdCanton  && x.CodigoProvincia==model.IdProvincia).ToList());
        }


       



    }
}