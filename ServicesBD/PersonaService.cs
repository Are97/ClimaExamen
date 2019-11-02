using ClimaExamen.ConexionBD;
using ClimaExamen.ModelsBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaExamen.ServicesBD
{
    public class PersonaService
    {
        private readonly PersonaDataService _dataService;
        public PersonaService(string connectionString)
        {
            _dataService = new PersonaDataService(connectionString);
        }

        //public List<Persona> getidpersona()
        //{
        //    return _dataService.getidpersona();
        //}
    }
}
