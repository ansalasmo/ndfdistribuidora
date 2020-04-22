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
        [HttpGet]
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
                command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = model.Nombre;
                command.Parameters.Add("@Apellidos", SqlDbType.VarChar, 50).Value = model.Apellidos;
                command.Parameters.Add("@Correo", SqlDbType.VarChar, 100).Value = model.Correo;
                command.Parameters.Add("@Telefono", SqlDbType.VarChar, 20).Value = model.Telefono;
                command.Parameters.Add("@CodigoProvincia", SqlDbType.Int).Value = model.CodigoProvincia;
                command.Parameters.Add("@CodigoCanton", SqlDbType.Int, 100).Value = model.CodigoCanton;
                command.Parameters.Add("@CodigoDistrito", SqlDbType.Int, 100).Value = model.CodigoDistrito;
                command.Parameters.Add("@TipoVehiculo", SqlDbType.Char, 1).Value = model.TipoVehiculo;
                command.Parameters.Add("@Placa", SqlDbType.VarChar, 15).Value = model.Placa;
                command.Parameters.Add("@Contrasena", SqlDbType.VarChar, 50).Value = model.Password;
                command.Parameters.Add("@CodigoLocal", SqlDbType.Int).Value = model.CodigoLocal;
                 
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    respuesta.Message = Convert.ToString(reader["mensaje"]);
                    respuesta.IsSuccess = Convert.ToBoolean(reader["isSuccess"]);
                }


            }
            catch (Exception e)
            {
                return BadRequest("Error inesperado antes de realizar el registro del nuevo Repartidor" + e.Message);
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


        [Route("RegistrarRepartidor")]
        [HttpGet]
        public Object Login([FromBody]LoginRequest model)
        {




            Response respuesta = new Response();
            respuesta.IsSuccess = true;
            respuesta.Message = "ok";
            return respuesta;
        }

    }
}