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

        public bool ActualizarEntidad(Entidades entidades, string UserEntidad, string pass)
        {
            var id = GetUsernaemEntidadId(UserEntidad);
            var password = GetPassowrdmEntidad(id);

            _db.OpenConnection();
            // var query = "UPDATE [dbo].Entidades SET [Descripcion] = " + "'" + entidadesTabla.Descripcion + "'" + ", [Direccion] = " + "'" + entidadesTabla.Direccion + "'" + " , [Localidad] = " + "'" + entidadesTabla.Localidad + "'" + ", [NumeroDocumento] = " + "'" + entidadesTabla.NumeroDocumento + "'" + ", [Telefonos] =" + "'" + entidadesTabla.Telefonos + "'" + ", [UserNameEntidad] =" + "'" + entidadesTabla.UserNameEntidad + "'" + ", [PassworEntidad] = " + "'" + pass + "'" + " WHERE id_Entidad = " + id;
            //var command = new SqlCommand(query, _db._connection);
            //command.ExecuteNonQuery();

            _command.CommandType = CommandType.StoredProcedure;
            _command.CommandType = System.Data.CommandType.StoredProcedure;
            _command.CommandText = "usp_EntidadesUpdate";
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
            _command.Parameters.AddWithValue(Utils.IdTipoEntidad, entidades.IdTipoEntidad);
            _command.Parameters.AddWithValue(Utils.LimiteCredito, entidades.LimiteCredito ?? 100);
            _command.Parameters.AddWithValue(Utils.UserNameEntidad, entidades.UserNameEntidad);
            _command.Parameters.AddWithValue(Utils.PassworEntidad, entidades.PasswordEntidad);
            _command.Parameters.AddWithValue(Utils.RolUserEntidad, entidades.RolUserEntidad);
            _command.Parameters.AddWithValue(Utils.Comentario, entidades.Comentario);
            _command.Parameters.AddWithValue(Utils.Status, entidades.Status);
            _command.Parameters.AddWithValue(Utils.NoEliminable, entidades.NoEliminable);
            _command.Parameters.AddWithValue(Utils.FechaRegistro, DateTime.Now);
            _command.ExecuteNonQuery();




            _db.CloseConnection();




            return true;

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
            _command.Parameters.AddWithValue(Utils.IdTipoEntidad, entidades.IdTipoEntidad);
            _command.Parameters.AddWithValue(Utils.LimiteCredito, entidades.LimiteCredito?? 100);
            _command.Parameters.AddWithValue(Utils.UserNameEntidad, entidades.UserNameEntidad);
            _command.Parameters.AddWithValue(Utils.PassworEntidad, entidades.PasswordEntidad);
            _command.Parameters.AddWithValue(Utils.RolUserEntidad, entidades.RolUserEntidad);
            _command.Parameters.AddWithValue(Utils.Comentario, entidades.Comentario);
            _command.Parameters.AddWithValue(Utils.Status, entidades.TipoDocumento);
            _command.Parameters.AddWithValue(Utils.NoEliminable, entidades.NoEliminable);
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
            command.Parameters.Clear();
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
                _db.CloseConnection();
                return null;
            }
        }

        public Entidades BuscarEntidad(string UsernameEntidad)
        {
            Entidades entidadesTabla = new Entidades();


            _db.OpenConnection();
            var command = _db._command;
            command.CommandText = "usp_EntidadesSelect";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Clear();
            command.Parameters.AddWithValue(Utils.UserNameEntidad, UsernameEntidad);
            var result = command.ExecuteReader();
            while (result.Read())
            {
                Entidades ent = new Entidades()
                {
                    UserNameEntidad = result["UserNameEntidad"].ToString() ?? "El valor es null",
                    Descripcion = result["Descripcion"].ToString() ?? "El valor es null",
                    Direccion = result["Direccion"].ToString() ?? "El valor es null",
                    Localidad = result["Localidad"].ToString() ?? "El valor es null",
                    NumeroDocumento = int.Parse(result["NumeroDocumento"].ToString() ?? "El valor es null"),
                    Telefonos = result["Telefonos"].ToString() ?? "El valor es null",
                    TipoEntidad = result["TipoEntidad"].ToString() ?? "El valor es null",
                    TipoDocumento = result["TipoDocumento"].ToString() ?? "El valor es null",
                    Urlfacebook = result["URLFacebook"].ToString(),
                    UrlpaginaWeb = result["URLPaginaWeb"].ToString(),
                    Urlinstagram = result["URLInstagram"].ToString(),
                    UrltikTok = result["URLTikTok"].ToString(),
                    Urltwitter = result["URLTwitter"].ToString(),
                    IdTipoEntidad = int.Parse(result["IdTipoEntidad"].ToString()),
                    LimiteCredito = int.Parse(result["LimiteCredito"].ToString()),
                    PasswordEntidad = result["PassworEntidad"].ToString(),
                    FechaRegistro = DateTime.Parse(result["FechaRegistro"].ToString()),
                    RolUserEntidad = result["RolUserEntidad"].ToString() ?? "El valor es null",
                    Status = result["Status"].ToString() ?? "El valor es null",
                    NoEliminable = result["NoEliminable"].ToString() ?? "El valor es null",
                    IdGrupoEntidad = int.Parse(result["IdGrupoEntidad"].ToString() ?? "El valor es null"),
                    Comentario = result["Comentario"].ToString(),
                };
                entidadesTabla = ent;

            }
            _db.CloseConnection();
            return entidadesTabla;
        }

        public bool EliminarEntidades(string user)
        {
            throw new NotImplementedException();
        }

        public int GetUsernaemEntidadId(string usernameEntidad)
        {
            int Id = 0;
            _db.OpenConnection();
            var query = "select id_Entidad from Entidades where UserNameEntidad = " + "'" + usernameEntidad + "'";
            var command = new SqlCommand(query, _db._connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Id = int.Parse(reader["Id_Entidad"].ToString());
            }
            _db.CloseConnection();
            return Id;

        }
        public string GetPassowrdmEntidad(int id)
        {
            string password = "";
            _db.OpenConnection();
            var query = "select PassworEntidad from Entidades where id_Entidad = " + "'" + id + "'";
            var command = new SqlCommand(query, _db._connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                password = reader["PassworEntidad"].ToString();
            }
            _db.CloseConnection();
            return password;

        }

        public List<Entidades> ListaEntidades()
        {

            List<Entidades> Entidades = new List<Entidades>();


            _db.OpenConnection();
            var query = "Select *  from dbo.Entidades t";
            var command = new SqlCommand(query, _db._connection);


            var result = command.ExecuteReader();
            while (result.Read())
            {
                Entidades ent = new Entidades()
                {
                    UserNameEntidad = result["UserNameEntidad"].ToString() ?? "El valor es null",
                    Descripcion = result["Descripcion"].ToString() ?? "El valor es null",
                    Direccion = result["Direccion"].ToString() ?? "El valor es null",
                    Localidad = result["Localidad"].ToString() ?? "El valor es null",
                    NumeroDocumento = int.Parse(result["NumeroDocumento"].ToString() ?? "El valor es null"),
                    Telefonos = result["Telefonos"].ToString() ?? "El valor es null",
                    TipoEntidad = result["TipoEntidad"].ToString() ?? "El valor es null",
                    TipoDocumento = result["TipoDocumento"].ToString() ?? "El valor es null",
                    Urlfacebook = result["URLFacebook"].ToString(),
                    UrlpaginaWeb = result["URLPaginaWeb"].ToString(),
                    Urlinstagram = result["URLInstagram"].ToString(),
                    UrltikTok = result["URLTikTok"].ToString(),
                    Urltwitter = result["URLTwitter"].ToString(),
                    IdTipoEntidad = int.Parse(result["IdTipoEntidad"].ToString()),
                    LimiteCredito = int.Parse(result["LimiteCredito"].ToString()),
                    PasswordEntidad = result["PassworEntidad"].ToString(),
                    FechaRegistro = DateTime.Parse(result["FechaRegistro"].ToString()),
                    RolUserEntidad = result["RolUserEntidad"].ToString() ?? "El valor es null",
                    Status = result["Status"].ToString() ?? "El valor es null",
                    NoEliminable = result["NoEliminable"].ToString() ?? "El valor es null",
                    IdGrupoEntidad = int.Parse(result["IdGrupoEntidad"].ToString() ?? "El valor es null"),
                    Comentario = result["Comentario"].ToString(),



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

        public List<string> GetTipoEntidades()
        {
            List<string> TipoEntidades = new List<string>();


            _db.OpenConnection();
            var query = "select * from TiposEntidades";
            var command = new SqlCommand(query, _db._connection);
            var _NoEliminable = false;

            var result = command.ExecuteReader();
            while (result.Read())
            {
                if (result["NoEliminable"].ToString() == "0")
                {
                    _NoEliminable = true;
                }
                TiposEntidades _TiposEntidades = new TiposEntidades()
                {

                    Descripcion = result["Descripcion"].ToString(),
                    //IdGrupoEntidadNavigation = result["IdGrupoEntidad"].ToString();


                };
                TipoEntidades.Add(_TiposEntidades.Descripcion);

            }

            if (result != null)
            {
                _db.CloseConnection();

                return TipoEntidades;
            }
            else
            {
                return null;
            }

        }

        public bool ActualizarTipoEntidades(string descripcion, string UsuarioEntidad, string user)
        {

            _db.OpenConnection();
            var queryGrupoEntidad = "select t.IdGrupoEntidad from GruposEntidades t where t.descripcion = '" + descripcion + "'";
            var command = new SqlCommand(queryGrupoEntidad, _db._connection);
            var reader = command.ExecuteReader();
            var result = "";
            var IdGrupoEntidad = 0;
            var IdTipoEntidad = 0;
            while (reader.Read())
            {
                result = reader["IdGrupoEntidad"].ToString();
            }
            IdGrupoEntidad = int.Parse(result);
            reader.Close();

            var queryTipoEntidad = "select t.idTipoEntidad from TiposEntidades t where t.Descripcion = '" + descripcion + "'";
            var _command = new SqlCommand(queryTipoEntidad, _db._connection);
            var _reader = _command.ExecuteReader();
            var _result = "";
            while (_reader.Read())
            {
                _result = _reader["idTipoEntidad"].ToString();
            }
            IdTipoEntidad = int.Parse(_result);
            _reader.Close();
            if (result != null)
            {
                var id = result;
                var query = "update Entidades set IdTipoEntidad  = " + IdTipoEntidad + " , IdGrupoEntidad = " + IdGrupoEntidad + "  where UserNameEntidad = '" + user + "'";
                var __command = new SqlCommand(query, _db._connection);
                var val = __command.ExecuteNonQuery();
                _db.CloseConnection();
                
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<string> GetGrupoEntidades()
        {
            _db.OpenConnection();
            var result = new List<string>();
            var query = "Select Descripcion from GruposEntidades";
            _command = new SqlCommand(query, _db._connection);
            var reader = _command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader["Descripcion"].ToString());
            }

            _db.CloseConnection();
            return result;
            
        }
        public int GrupoEntidadesSearch(string value)
        {
            var id = 0;
            if (value == "Admin") id = 5;
            if (value == "Developer") id = 4;
            if (value == "Usuario") id = 6;
             return id;

            

        }

        public int? GetTipoEntidadIdByGrupoEntidadId(int? grupoEntidadId)
        {

            _db.OpenConnection();
            var query = "select idTipoEntidad from TiposEntidades where IdGrupoEntidad = " + grupoEntidadId;
            _command = new SqlCommand(query, _db._connection);
           var reader = _command.ExecuteReader();
            var result = 0;
            while (reader.Read())
            {
                result = int.Parse(reader["IdTipoEntidad"].ToString());
            }
            _db.CloseConnection();
            return result;

        }

        public List<GruposEntidades> GrupoEntidadesLista()
        {
            List<GruposEntidades> List = new List<GruposEntidades>();
            _db.OpenConnection();
            var query = "Select * from GruposEntidades";
            _command = new SqlCommand(query, _db._connection);
            var reader = _command.ExecuteReader();
            
            while (reader.Read())
            {

                GruposEntidades grupos = new GruposEntidades()
                {

                    IdGrupoEntidad = int.Parse(reader["IdGrupoEntidad"].ToString()),
                    Descripcion = reader["Descripcion"].ToString(),
                    Comentario = reader["Comentario"].ToString(),
                    Status = reader["Status"].ToString(),
                    NoEliminable = reader["NoEliminable"].ToString(),
                    FechaRegistro = DateTime.Parse(reader["FechaRegistro"].ToString())
                    
                    //IdGrupoEntidadNavigation = result["IdGrupoEntidad"].ToString();


                };
                List.Add(grupos);

            }
            _db.CloseConnection();
            return List;
        }

        public Tuple<int,string> GetGrupoIdByUsuario(string usernameEntidad)
        {
            var result = 0;
            var descripcion = "";
            var query = "select IdGrupoEntidad, Descripcion from entidades where UsernameEntidad = '" + usernameEntidad + "'";
            _db.OpenConnection();
            _command = new SqlCommand(query, _db._connection);
            var reader = _command.ExecuteReader();
           
            while (reader.Read())
            {
                result = int.Parse(reader["IdGrupoEntidad"].ToString());
                descripcion = reader["Descripcion"].ToString();
            }
            _db.CloseConnection();
            return new Tuple<int, string>(result, descripcion);
        }

        public int GetGrupoEntidadIDByDesc(string descripcion)
        {

            _db.OpenConnection();
           var result = 0;
            var query = "Select IdGrupoEntidad from GruposEntidades where Descripcion ='"+descripcion +"'";
            _command = new SqlCommand(query, _db._connection);
            var reader = _command.ExecuteReader();
            while (reader.Read())
            {
                result = int.Parse(reader["IdGrupoEntidad"].ToString());
            }

            _db.CloseConnection();
            return result;
        }

        public bool EliminarEntidad(string user)
        {
            _db.OpenConnection();
            var query = "delete from Entidades where UserNameEntidad = '" + user +"'";
            _command = new SqlCommand(query, _db._connection);
            var result = _command.ExecuteNonQuery();
            if (result == 0)
            {
                _db.CloseConnection();
                return false;
            }
            else
            {
                _db.CloseConnection();
                return true;
            }
        }

        public bool InsertarGrupoEntidad(GruposEntidades grupoEntidades)
        {
            _command.Parameters.Clear();
            _db.OpenConnection();
            _command.CommandText = "usp_GruposEntidadesInsert";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue(Utils.GrupoEntidades_Comentario, grupoEntidades.Comentario);
            _command.Parameters.AddWithValue(Utils.GrupoEntidades_Descripcion,grupoEntidades.Descripcion);
            _command.Parameters.AddWithValue(Utils.GrupoEntidades_NoEliminable,grupoEntidades.NoEliminable);
            _command.Parameters.AddWithValue(Utils.GrupoEntidades_Status,grupoEntidades.Status);
            _command.Parameters.AddWithValue(Utils.GrupoEntidades_FechaRegistro, DateTime.Now.ToShortDateString());
            var result = _command.ExecuteNonQuery();
            if (result == 0)
            {
                _db.CloseConnection();
                return false;
            }
            else
            {
                _db.CloseConnection();
                return true;
            }
        }

        public bool EliminarGrupoEntidad(string descripcion)
        {

            _db.OpenConnection();
            _command.CommandText = "usp_GruposEntidadesDelete";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue(Utils.GrupoEntidades_Descripcion, descripcion);
            
            var result = _command.ExecuteNonQuery();
            if (result == 0)
            {
                _db.CloseConnection();
                return false;
            }
            else
            {
                _db.CloseConnection();
                return true;
            }
        }

        public bool ActulizarGrupoEntidad(GruposEntidades gruposEntidades,string _descripcion)
        {

            _db.OpenConnection();
            _command.CommandText = "usp_GruposEntidadesUpdate";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue(Utils.GrupoEntidades_Comentario, gruposEntidades.Comentario);
            _command.Parameters.AddWithValue("@_Descripcion", _descripcion);
            _command.Parameters.AddWithValue(Utils.GrupoEntidades_Descripcion, gruposEntidades.Descripcion);
            _command.Parameters.AddWithValue(Utils.GrupoEntidades_NoEliminable, gruposEntidades.NoEliminable);
            _command.Parameters.AddWithValue(Utils.GrupoEntidades_Status, gruposEntidades.Status);

            var result = _command.ExecuteNonQuery();
            if (result == 0)
            {
                _db.CloseConnection();
                return false;
            }
            else
            {
                _db.CloseConnection();
                return true;
            }
        }
    }

   
}