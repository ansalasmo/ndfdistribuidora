using DdfDistribuidoraApi.Helpers;
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
        private readonly IMailHelper mailHelper;

        public PedidosExpressController(NdfDistribuidoraContext context, IMailHelper  mailHelper)
        {
            this.context = context;
            this.mailHelper = mailHelper;
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
                        Correo = model.Correo,
                        CodigoLocal= Convert.ToInt32(reader["CodigoLocal"]),
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
                        CodigoLocal = Convert.ToChar(reader["CodigoLocal"]),
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
                command.Parameters.Add("@numeroFactura", SqlDbType.Int).Value = model.NumeroFactura;
                command.Parameters.Add("@codigoLocal", SqlDbType.Int).Value = model.CodigoLocal;
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
                command.Parameters.Add("@CodigoLocal", SqlDbType.Int).Value = model.CodigoLocal;

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






        [Route("RecuperarContrasena")]
        [HttpPost]
        public ActionResult RecuperarContrasena([FromBody]LoginRequest model)
        {
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            Response respuesta = new Response();
            respuesta.IsSuccess = true;
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                connection.Open(); 
                command.CommandText = "Select Contrasena FROM FAC_Repartidores";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    respuesta.Message = Convert.ToString(reader["Contrasena"]);
                } 
                mailHelper.SendMail(model.Correo, "Email confirmation",
                         $"<table style = 'max-width: 600px; padding: 10px; margin:0 auto; border-collapse: collapse;'>" +
                         $"  <tr>" +
                         $"    <td style = 'background-color: #34495e; text-align: center; padding: 0'>" + 
                         $"  </td>" +
                         $"  </tr>" +
                         $"  <tr>" +
                         $"  <td style = 'padding: 0'>" + respuesta.Message +
                         $"  </td>"+ 
                         $"</tr>" +
                         $"<tr>" +
                         $" <td style = 'background-color: #ecf0f1'>" +
                         $"  <div style = 'color: #34495e; margin: 4% 10% 2%; text-align: justify;font-family: sans-serif'>" + 
                         $"  </div>" +
                         $" </td >" +
                         $"</tr>" +
                         $"</table>");
                return Ok(respuesta); 
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



        }
          
    }
}