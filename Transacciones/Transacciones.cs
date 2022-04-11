using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transacciones.Interfases;
using Datos;
using System.Data.SqlClient;
using Datos.Modelos;
using Datos.Utils;
using System.Data;

namespace Transacciones
{
    public class Transacciones : ITransacciones
    {
        private Datos.Datos _db = new Datos.Datos();
        private Entidades _Entidades = new Entidades();
        private SqlCommand _command;


        public Transacciones()
        {
            _command = _db._command;
        }

        public Entidades ActualizarEntidad(string user)
        {
            throw new NotImplementedException();
        }

        public bool AgregarEntidad(Entidades entidades)
        {

            _db.OpenConnection();
            _command.CommandType = System.Data.CommandType.StoredProcedure;
            _command.CommandText = "usp_EntidadesInsert";
            _command.Parameters.AddWithValue(Utils.Descripcion, entidades.Descripcion);
            _command.Parameters.AddWithValue(Utils.Direccion, entidades.Direccion);
            _command.Parameters.AddWithValue(Utils.Localidad, entidades.Localidad);
            _command.Parameters.AddWithValue(Utils.TipoEntidad, entidades.TipoEntidad);
            _command.Parameters.AddWithValue(Utils.TipoDocumento, entidades.TipoDocumento);
            _command.Parameters.AddWithValue(Utils.NumeroDocumento, entidades.NumeroDocumento);
            _command.Parameters.AddWithValue(Utils.Telefonos, entidades.Telefonos);
            _command.Parameters.AddWithValue(Utils.URLPaginaWeb, entidades.UrlpaginaWeb ?? "google.com");
            _command.Parameters.AddWithValue(Utils.URLFacebook, entidades.Urlfacebook ?? "Facebook.com");
            _command.Parameters.AddWithValue(Utils.URLInstagram, entidades.Urlinstagram ?? "Instagram.com");
            _command.Parameters.AddWithValue(Utils.URLTwitter, entidades.Urltwitter ?? "Twitter.com");
            _command.Parameters.AddWithValue(Utils.URLTiktok, entidades.UrltikTok ?? "Tiktok.com");
            _command.Parameters.AddWithValue(Utils.IdGrupoEntidad, entidades.IdGrupoEntidad);
            _command.Parameters.AddWithValue(Utils.LimiteCredito, entidades.LimiteCredito);
            _command.Parameters.AddWithValue(Utils.UserNameEntidad, entidades.UserNameEntidad);
            _command.Parameters.AddWithValue(Utils.PassworEntidad, entidades.PasswordEntidad);
            _command.Parameters.AddWithValue(Utils.RolUserEntidad, entidades.RolUserEntidad);
            _command.Parameters.AddWithValue(Utils.Comentario, entidades.Comentario);
            _command.Parameters.AddWithValue(Utils.Status, entidades.TipoDocumento);
            _command.Parameters.AddWithValue(Utils.NoEliminable, entidades.TipoDocumento);
            _command.Parameters.AddWithValue(Utils.FechaRegistro, DateTime.Now);

            var result = _command.ExecuteNonQuery();
            _db._connection.Close();
            if (result > 0) return true;
            else return false;
            
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
                Entidades.PasswordEntidad = result["PassworEntidad"] as string;
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

        public bool EliminarEntidades(string user)
        {
            throw new NotImplementedException();
        }

        public List<Entidades> ListaEntidades()
        {

            List<Entidades> Entidades = new List<Entidades>();


            _db.OpenConnection();
            var query = "Select t.UserNameEntidad,t.Telefonos,t.NumeroDocumento,t.Descripcion,t.Localidad, t.Direccion  from dbo.Entidades t";
            var command = new SqlCommand(query, _db._connection);
         
           
                
            var result = command.ExecuteReader();      
            while (result.Read())
            {
                Entidades ent =  new Entidades()
                {
                    UserNameEntidad = result["UserNameEntidad"].ToString(),
                    Descripcion = result["Descripcion"].ToString(),
                    Direccion = result["Direccion"].ToString(),
                    Localidad = result["Localidad"].ToString(),
                    NumeroDocumento = int.Parse(result["NumeroDocumento"].ToString()),
                    Telefonos = result["Telefonos"].ToString()
                };
             Entidades.Add(ent);
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

        public Entidades VerEntidad(string user)
{
    throw new NotImplementedException();
}
    }
}
