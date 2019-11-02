using ClimaExamen.ModelsBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaExamen.ConexionBD
{
    class PersonaDataService
    {
        private readonly SqlClient _client;

        public PersonaDataService(string connectionString)
        {
            _client = new SqlClient(connectionString);
            return;
        }

        //public List<Persona> getidpersona()
        //{
        //    var result = new List<Persona>();
        //    try
        //    {
        //        if (_client.Open())
        //        {
        //            var command = new SqlCommand
        //            {
        //                Connection = _client.Conecction,
        //                CommandText = "getidpersona",
        //                CommandType = CommandType.StoredProcedure
        //            };
        //            var dataReader = command.ExecuteReader();
        //            while (dataReader.Read())
        //            {
        //                var persona = new Persona
        //                {
        //                    correo = dataReader["correo"].ToString(),
        //                    contras = dataReader["contras"].ToString()
        //                };
        //                result.Add(persona);
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        // ignored
        //    }
        //    finally
        //    {
        //        _client.Close();
        //    }
        //}
    }
}
