using DdfDistribuidoraApi.ModelosMovil;
using DdfDistribuidoraApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                        MontoExpress = Convert.ToDecimal(reader["MontoExpress"]),
                        Correo = model.Correo
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










        [Route("GetPedidosRepartidor")]
        [HttpPost]
        public ActionResult GetPedidosRepartidor([FromBody] LoginRequest model)
        {
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            List<PedidoExpress> listado = new List<PedidoExpress>();
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.CommandText = "FAC_TraerPedidosRepartidor";
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
                        MontoExpress = Convert.ToDecimal(reader["MontoExpress"]),
                        Correo = model.Correo,
                        Estado = Convert.ToChar(reader["Estado"]),
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








        [Route("SetEstadoFinal")]
        [HttpPost]
        public ActionResult SetEstadoFinal([FromBody] PedidoExpress model)
        {
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            Response obje = new Response(); 
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.CommandText = "FAC_EstablecerEstadoFinal"; 
                command.Parameters.Add("@periodo", SqlDbType.Int).Value = model.Periodo;
                command.Parameters.Add("@mes", SqlDbType.Int).Value = model.Mes;
                command.Parameters.Add("@dia", SqlDbType.Int).Value = model.Dia;
                command.Parameters.Add("@numeroPedido", SqlDbType.Int).Value = model.NumeroPedido;
                command.Parameters.Add("@correoRepartidor", SqlDbType.VarChar, 100).Value = model.Correo;
                command.Parameters.Add("@estado", SqlDbType.Char,1).Value = model.Estado;
                SqlDataReader reader = command.ExecuteReader(); 
                while (reader.Read())
                { 
                    obje.IsSuccess = Convert.ToBoolean(reader["Respuesta"]);
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
            return Ok(obje);
        }






        [Route("RegistrarPedidosUbicaciones")]
        [HttpPost]
        public ActionResult RegistrarPedidosUbicaciones([FromBody] PedidoExpress model)
        {
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            Response obje = new Response();
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.CommandText = "FAC_RegistrarPedidosUbicaciones";
                command.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value = model.Correo;
                command.Parameters.Add("@periodo", SqlDbType.Int).Value = model.Periodo;
                command.Parameters.Add("@mes", SqlDbType.Int).Value = model.Mes;
                command.Parameters.Add("@dia", SqlDbType.Int).Value = model.Dia;
                command.Parameters.Add("@numeroPedido", SqlDbType.Int).Value = model.NumeroPedido; 
                command.Parameters.Add("@latitud", SqlDbType.Decimal).Value = model.LatitudOrigen;
                command.Parameters.Add("@longitud", SqlDbType.Decimal).Value = model.LongitudOrigen;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    obje.IsSuccess = Convert.ToBoolean(reader["Respuesta"]);
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
            return Ok(obje);
        }




        [Route("SetPedidoAsignado")]
        [HttpPost]
        public ActionResult SetPedidoAsignado(PedidosSend model)
        {
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            Response respuesta = new Response();
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.CommandText = "Fac_ActualizarRepartidorPed";

               // model.Fecha = Convert.ToDateTime(model.Fecha.ToString().Replace("-",""));
               // command.Parameters.Add("@fecha", SqlDbType.DateTime).Value = model.Fecha;//Esta fecha se asigna en el sp
                command.Parameters.Add("@periodo", SqlDbType.Int).Value = model.Periodo;
                command.Parameters.Add("@mes", SqlDbType.Int).Value = model.Mes;
                command.Parameters.Add("@dia", SqlDbType.Int).Value = model.Dia;
                command.Parameters.Add("@numeroPedido", SqlDbType.Int).Value = model.NumeroPedido;
                command.Parameters.Add("@correoRepartidor", SqlDbType.VarChar, 100).Value = model.CorreoRepartidor;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    respuesta.IsSuccess = Convert.ToBoolean(reader["respuesta"]);
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








        [Route("VerificarEstadoPedido")]
        [HttpPost]
        public ActionResult VerificarEstadoPedido(LoginRequest model)
        {
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            Response respuesta = new Response();
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.CommandText = "FAC_VerificarEstadoPedido";
                 
                command.Parameters.Add("@correoRepartidor", SqlDbType.VarChar, 100).Value = model.Correo;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    respuesta.IsSuccess = Convert.ToBoolean(reader["respuesta"]);
                }
            }
            catch (Exception e)
            {
                return BadRequest("Error inesperado antes de realizar la consulta de la cuenta de pedidos asignados" + e.Message);
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


        [Route("GetTelefonoAyuda")]
        [HttpGet]
        public ActionResult GetTelefonoAyuda()
        {
            Response obje = new Response();
            obje.Message = context.FacParametros.Select(x => x.Telefonos).FirstOrDefault().ToString();


            return Ok(obje);
        }



    }
}