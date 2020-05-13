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
using System.Threading.Tasks;

namespace DdfDistribuidoraApi.Controllers
{
    [Route("PedidosExpress")]
    [ApiController]
    public class PedidosExpressController : ControllerBase
    {



        private readonly NdfDistribuidoraContext context;
        private readonly IMailHelper mailHelper;
        private readonly IOSRMRouteService routeService;

        public PedidosExpressController(NdfDistribuidoraContext context, IMailHelper  mailHelper, IOSRMRouteService routeService)
        {
            this.context = context;
            this.mailHelper = mailHelper;
            this.routeService = routeService;
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
                        Estado = Convert.ToChar(reader["Estado"])
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
                    PedidoExpress objetoExpress = new PedidoExpress();

                    if (Convert.ToInt32(reader["MontoTotal"]) + Convert.ToInt32(reader["MontoExpress"]) == Convert.ToInt32(reader["MontoExpress"])){
                        objetoExpress.TotalFinal = "0";
                    } 
                    else {
                        objetoExpress.TotalFinal = Convert.ToString(Convert.ToInt32(reader["MontoTotal"]) + Convert.ToInt32(reader["MontoExpress"]));
                    } 
                    objetoExpress.Comercio = Convert.ToString(reader["Comercio"]);
                    objetoExpress.LatitudOrigen = Convert.ToString(reader["LatitudOrigen"]);
                    objetoExpress.LongitudOrigen = Convert.ToString(reader["LongitudOrigen"]);
                    objetoExpress.Cliente = Convert.ToString(reader["Cliente"]);
                    objetoExpress.LatitudDestino = Convert.ToString(reader["LatitudDestino"]);
                    objetoExpress.LongitudDestino = Convert.ToString(reader["LongitudDestino"]);
                    objetoExpress.Telefono = Convert.ToString(reader["Telefono"]);
                    objetoExpress.Direccion = Convert.ToString(reader["Direccion"]);
                    objetoExpress.Periodo = Convert.ToInt32(reader["Periodo"]);
                    objetoExpress.Mes = Convert.ToInt32(reader["Mes"]);
                    objetoExpress.Dia = Convert.ToInt32(reader["Dia"]);
                    objetoExpress.NumeroPedido = Convert.ToInt32(reader["NumeroPedido"]);
                    objetoExpress.Distancia = Convert.ToDecimal(reader["Distancia"]);
                    objetoExpress.MontoExpress = Convert.ToDecimal(reader["MontoExpress"]);
                    objetoExpress.Correo = model.Correo;
                    objetoExpress.Estado = Convert.ToChar(reader["Estado"]);
                    objetoExpress.CodigoLocal = Convert.ToChar(reader["CodigoLocal"]);
                    objetoExpress.FormaPago = Convert.ToChar(reader["FormaPago"]);
                    objetoExpress.MontoTotal = Convert.ToDecimal(reader["MontoTotal"]);
                    objetoExpress.MontoTotalString = Convert.ToString(reader["MontoTotal"]);
                    objetoExpress.TotalFinal = Convert.ToString(Convert.ToInt32(reader["MontoTotal"]) + Convert.ToInt32(reader["MontoExpress"]));


                    listado.Add(objetoExpress);
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




        [Route("GetPedidosRepartidorRetirados")]
        [HttpPost]
        public ActionResult GetPedidosRepartidorRetirados([FromBody] LoginRequest model)
        {
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            List<PedidoExpress> listado = new List<PedidoExpress>();
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.CommandText = "FAC_TraerPedidosRepartidorRetirados";
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
                        FormaPago = Convert.ToChar(reader["FormaPago"]),
                        MontoTotal = Convert.ToDecimal(reader["MontoTotal"]),
                        MontoTotalString  = Convert.ToString(reader["MontoTotal"]),
                        TotalFinal = Convert.ToString(Convert.ToInt32 (reader["MontoTotal"]) + Convert.ToInt32(reader["MontoExpress"]))
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
        public ActionResult SetEstadoFinal([FromBody] PedidoExpress model)//Metodo utilizado para cambiar el estado del pedido tanto al ser Retirado como entregado , 
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
                SqlParameter objeto = new SqlParameter
                {
                    ParameterName = "@numeroFactura",
                    SqlDbType = SqlDbType.Decimal,
                    Value = model.NumeroFactura,
                    Precision = 18,
                    Scale = 0
                };
                command.Parameters.Add(objeto);
                command.Parameters.Add("@codigoLocal", SqlDbType.Int).Value = model.CodigoLocal;

                command.Parameters.Add("@MontoTotal", SqlDbType.VarChar).Value = model.MontoTotalString;
                //SqlParameter objeto2 = new SqlParameter
                //{
                //    ParameterName = "@MontoTotal",
                //    SqlDbType = SqlDbType.Decimal,
                //    Value = model.MontoTotal,
                //    Precision = 18,
                //    Scale = 2
                //};
                //command.Parameters.Add(objeto2);

                command.Parameters.Add("@Efectivo", SqlDbType.VarChar).Value = model.EfectivoString;
                //SqlParameter objeto3 = new SqlParameter // Los siguientes parametros solo se enviar para establecer en E, sino se envian en 0 y ' '
                //{
                //    ParameterName = "@Efectivo",
                //    SqlDbType = SqlDbType.Decimal,
                //    Value = model.Efectivo,
                //    Precision = 18,
                //    Scale = 2
                //};
                //command.Parameters.Add(objeto3); 
                command.Parameters.Add("@FormaPago", SqlDbType.Char).Value = model.FormaPago;              
                command.Parameters.Add("@SLatitud", SqlDbType.VarChar, 34).Value = Convert.ToString(model.LatitudOrigen);//Estas latitudes realmente son la destino , se trata asi porqy ya estaba en el model del app 
                command.Parameters.Add("@SLongitud", SqlDbType.VarChar, 34).Value = Convert.ToString(model.LongitudOrigen); 
                command.Parameters.Add("@SDistancia", SqlDbType.VarChar, 34).Value = Convert.ToString(model.Distancia); 
                command.Parameters.Add("@SMontoExpress", SqlDbType.VarChar, 34).Value =  model.MontoExpressString;   
                
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

        [Route("ObtenerDistancia")]
        [HttpPost]
        public async Task<ActionResult> ObtenerDistancia([FromBody] DatosCoordenada model)
        {    
           
            DirectionResponse objeDirection =  await routeService.GetDirectionResponseAsync(model.LatitudOrigen, model.LongitudOrigen, model.LatitudDestino, model.LongitudDestino);
            if (objeDirection == null)
            {
                return BadRequest();
            }else
            {
                var route = objeDirection.Routes.ToList();
                var respuesta = Convert.ToString(Math.Round((double)route[0].Distance,2));
              

                            Response respuetaR = new Response
                            {
                                Message = respuesta.Replace(".",","),
                                IsSuccess = true

                            }; 

                return Ok(respuetaR);
            } 
        }





        [Route("CalcularCostoRecorrido")]
        [HttpPost]
        public ActionResult CalcularCostoRecorrido([FromBody] PedidoExpress model)
        {
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            Response obje = new Response();
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.CommandText = "FAC_DevolverEnvio";
                command.Parameters.Add("@CodigoLocal", SqlDbType.Int).Value = model.CodigoLocal;
                command.Parameters.Add("@Distancia", SqlDbType.Int).Value = model.Distancia;
                 
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    obje.Message = Convert.ToString(reader["MontoEnvio"]);
                }
            }
            catch (Exception e)
            {
                return BadRequest("No se pudo calcular el monto a pagar por el esa distancia" + e.Message);
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
                command.CommandText = "Select Contrasena FROM FAC_Repartidores WHERE  CorreoRepartidor = "+ "'"+model.Correo +"'";
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
                         $"<img width = '20%' heigth='20%' src= 'http://nubedefuego.azurewebsites.net/View/img/logos/ndfdorada.png'>" +
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