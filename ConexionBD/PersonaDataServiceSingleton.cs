using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClimaExamen.ModelsBD;

namespace ClimaExamen.ConexionBD
{
    class PersonaDataServiceSingleton
    {
        private readonly SqlClient _client;
    }

    //private PersonaDataServiceSingleton(string connectionString)
    //{
    //    _client = new SqlClient(connectionString);
    //    return;
    //}

    //private static PersonaDataServiceSingleton _instance;

    //public static PersonaDataServiceSingleton GetInstance(string connectionString)
    //{
    //    if (_instance == null)
    //    {
    //        _instance = new PersonaDataServiceSingleton(connectionString);
    //    }
    //    return _instance;
    //}
}
