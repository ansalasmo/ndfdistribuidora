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
    [Route("Startup")]
    [ApiController]
    public class StartupController : ControllerBase
    { 
        private readonly NdfDistribuidoraContext context; 
        public StartupController(NdfDistribuidoraContext context)
        {
            this.context = context;
        }  
        [Route("RegistrarRepartidor")]
        [HttpPost]
        public Object RegistrarRepartidor([FromBody]RegisterRequest model)
        {
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            Response respuesta = new Response();
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.CommandText = "Fac_RegistrarRepartidor";
                command.Parameters.Add("@NombreCompleto", SqlDbType.VarChar, 200).Value = model.Nombre +" "+ model.Apellidos;
                command.Parameters.Add("@Apellidos", SqlDbType.VarChar, 100).Value = model.Apellidos;
                command.Parameters.Add("@Correo", SqlDbType.VarChar, 100).Value = model.Correo;
                command.Parameters.Add("@Telefono", SqlDbType.VarChar, 20).Value = model.Telefono;
                command.Parameters.Add("@CodigoProvincia", SqlDbType.Int).Value = model.CodigoProvincia;
                command.Parameters.Add("@CodigoCanton", SqlDbType.Int, 100).Value = model.CodigoCanton;
                command.Parameters.Add("@TipoVehiculo", SqlDbType.Char, 1).Value = model.TipoVehiculo;
                command.Parameters.Add("@Placa", SqlDbType.VarChar, 15).Value = model.Placa;
                command.Parameters.Add("@Contrasena", SqlDbType.VarChar, 50).Value = model.Password; 
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    respuesta.Message = Convert.ToString(reader["mensaje"]);
                    respuesta.IsSuccess = Convert.ToBoolean(reader["isSuccess"]);
                }
            }
            catch (Exception e)
            {
                return BadRequest("Error inesperado antes de realizar el registro del nuevo Repartidor " + e.Message);
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


        [Route("ActualizarRepartidor")]
        [HttpPost]
        public Object ActualizarRepartidor([FromBody]RegisterRequest model)
        {
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            Response response = new Response();
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.CommandText = "FAC_ActualizarRepartidor";
                command.Parameters.Add("@NombreCompleto", SqlDbType.VarChar, 200).Value = model.Nombre + " " + model.Apellidos;
                command.Parameters.Add("@Apellidos", SqlDbType.VarChar, 100).Value = model.Apellidos;
                command.Parameters.Add("@Correo", SqlDbType.VarChar, 100).Value = model.Correo;
                command.Parameters.Add("@Telefono", SqlDbType.VarChar, 20).Value = model.Telefono;
                command.Parameters.Add("@CodigoProvincia", SqlDbType.Int).Value = model.CodigoProvincia;
                command.Parameters.Add("@CodigoCanton", SqlDbType.Int, 100).Value = model.CodigoCanton;
                command.Parameters.Add("@TipoVehiculo", SqlDbType.Char, 1).Value = model.TipoVehiculo;
                command.Parameters.Add("@Placa", SqlDbType.VarChar, 15).Value = model.Placa;
                command.Parameters.Add("@Contrasena", SqlDbType.VarChar, 50).Value = model.Password;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    RegisterRequest response2 = new RegisterRequest();
                    response2.Correo = model.Correo;
                    response2.Nombre = Convert.ToString(reader["Nombre"]);
                    response2.Apellidos = Convert.ToString(reader["Apellidos"]);
                    response2.Telefono = Convert.ToString(reader["Telefono"]);
                    response2.CodigoProvincia = Convert.ToInt32(reader["CodigoProvincia"]);
                    response2.NombreProvincia = Convert.ToString(reader["NombreProvincia"]); 
                    response2.CodigoCanton = Convert.ToInt32(reader["CodigoCanton"]);
                    response2.NombreCanton = Convert.ToString(reader["NombreCanton"]);
                    response2.TipoVehiculo = Convert.ToChar(reader["TipoVehiculo"]);
                    response2.Placa = Convert.ToString(reader["Placa"]);
                    response2.Estado = 'A';
                    if (response2.Nombre == " ")
                    {
                        response.IsSuccess = false;
                        return Ok(response);
                    }
                    else
                    {
                        return Ok(response2); 
                    } 
                }
            }
            catch (Exception e)
            {
                return BadRequest("Error inesperado antes de actualiza el registro del  Repartidor " + e.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return Ok(response);
        }









        [Route("SetRepartidoresDistritos")]
        [HttpPost]
        public ActionResult SetRepartidoresDistritos([FromBody]RepartidoresDistritos model)
        {
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            Response response = new Response();
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.CommandText = "FAC_RegistrarRepartidorDist";
                command.Parameters.Add("@Correo", SqlDbType.VarChar, 100).Value = model.CorreoRepartidor;
                command.Parameters.Add("@CodigoProvincia", SqlDbType.Int).Value = model.CodigoProvincia;
                command.Parameters.Add("@CodigoCanton", SqlDbType.Int).Value = model.CodigoCanton;
                command.Parameters.Add("@CodigoDistrito", SqlDbType.VarChar, 100).Value = model.CodigoDistrito; 
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    response.Message = Convert.ToString(reader["mensaje"]);
                    response.IsSuccess = Convert.ToBoolean(reader["isSuccess"]);
                }
            }
            catch (Exception e)
            {
                return BadRequest("Error inesperado antes de asignar el pedido al Repartidor " + e.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return Ok(response);
        }




        [Route("GetRepartidoresDistritos")]
        [HttpPost]
        public ActionResult GetRepartidoresDistritos([FromBody]RepartidoresDistritos model)
        {
            List<RepartidoresDistritos> listado = new List<RepartidoresDistritos>();
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            RepartidoresDistritos response;
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.CommandText = "FAC_TraerDistritosRepartidor";
                command.Parameters.Add("@Correo", SqlDbType.VarChar, 100).Value = model.CorreoRepartidor;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    response = new RepartidoresDistritos();
                    response.CodigoDistrito = Convert.ToString(reader["CodigoDistrito"]);
                    listado.Add(response);
                }
            }
            catch (Exception e)
            {
                return BadRequest("Error inesperado antes recuperar los distritos del Repartidor " + e.Message);
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






        [Route("ValidarRepartidor")]
        [HttpPost]
        public ActionResult ValidarRepartidor([FromBody] LoginRequest model)
        {
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            RegisterRequest response = new RegisterRequest();
            try
            { 
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.CommandText = "FAC_ValidarRepartidor";
                command.Parameters.Add("@Correo", SqlDbType.VarChar, 100).Value = model.Correo;
                command.Parameters.Add("@Contrasena", SqlDbType.VarChar, 50).Value = model.Password;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    response.Correo = Convert.ToString(reader["CorreoRepartidor"]);
                    response.Nombre = Convert.ToString(reader["Nombre"]);
                    response.Apellidos = Convert.ToString(reader["Apellidos"]);
                    response.Telefono = Convert.ToString(reader["Telefono"]);
                    response.CodigoProvincia = Convert.ToInt32(reader["CodigoProvincia"]);
                    response.NombreProvincia = Convert.ToString(reader["NombreProvincia"]);
                    response.CodigoCanton = Convert.ToInt32(reader["CodigoCanton"]);
                    response.NombreCanton = Convert.ToString(reader["NombreCanton"]);
                    response.TipoVehiculo = Convert.ToChar(reader["TipoVehiculo"]);
                    response.Placa = Convert.ToString(reader["Placa"]);
                    response.Estado = Convert.ToChar(reader["Estado"]); 
                } 
            }
            catch(Exception ex)
            {
                return BadRequest("Error inesperado antes de validar el Repartidor " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            if (response.Correo == " ")
            {
                Response response2 = new Response();
                response2.IsSuccess = false;
                return Ok(response2);
            }
            else
            {
                return Ok(response);
            }
        }




        [Route("CambiarContrasena")]
        [HttpPost]
        public ActionResult CambiarContrasena([FromBody] ChangePassword model)
        {
            SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
            Response response = new Response();
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.CommandText = "FAC_CambiarContrasena";
                command.Parameters.Add("@Correo", SqlDbType.VarChar, 100).Value = model.Correo;
                command.Parameters.Add("@CurrentPassword", SqlDbType.VarChar, 50).Value = model.CurrentPassword;
                command.Parameters.Add("@NewPassword", SqlDbType.VarChar, 50).Value = model.NewPassword;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    response.IsSuccess = Convert.ToBoolean(reader["IsSuccess"]);
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Error inesperado antes de realizar el cambio de la contrasena del  Repartidor " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            } 
            return Ok(response);
        }
    }
}