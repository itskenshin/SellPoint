using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transacciones.Interfases;
using Datos;
using System.Data.SqlClient;

namespace Transacciones
{
    public class Transacciones : ITransacciones
    {
        private Datos.Datos _db = new Datos.Datos();



        public Object Autenticacion(string user, string password)
        {
            _db.OpenConnection();
            var command = _db._command;
            command.CommandText = "SPAutenticar";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            var result = command.ExecuteScalar();
            if (result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
