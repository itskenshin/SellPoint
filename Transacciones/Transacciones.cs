using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transacciones.Interfases;
using Datos;
using System.Data.SqlClient;
using Datos.Modelos;


namespace Transacciones
{
    public class Transacciones : ITransacciones
    {
        private Datos.Datos _db = new Datos.Datos();
        
        public Transacciones()
        {

        }

        public Entidades Autenticacion(string user, string password)
        {
            Entidades Entidades = new Entidades();
            _db.OpenConnection();
            var command = _db._command;
            command.CommandText = "SPAutenticar";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("User", user);
            command.Parameters.AddWithValue("Password", password);
            var result = command.ExecuteReader();
            while (result.Read())
            {
                Entidades.UserNameEntidad = result["UserNameEntidad"] as string;
                Entidades.PassworEntidad = result["PassworEntidad"] as string;
            }

            if (result != null)
            {
                _db.CloseConnection();
                return Entidades;
            }
            else
            {
                return null;
            }
        }
    }
}
