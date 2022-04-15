﻿using System;
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

        public bool ActualizarEntidad(EntidadesTabla entidadesTabla, string UserEntidad, string pass)
        {
            var id = GetUsernaemEntidadId(UserEntidad);
            var password = GetPassowrdmEntidad(id);

            _db.OpenConnection();
            var query = "UPDATE [dbo].Entidades SET [Descripcion] = " + "'" + entidadesTabla.Descripcion + "'" + ", [Direccion] = " + "'" + entidadesTabla.Direccion + "'" + " , [Localidad] = " + "'" + entidadesTabla.Localidad + "'" + ", [NumeroDocumento] = " + "'" + entidadesTabla.NumeroDocumento + "'" + ", [Telefonos] =" + "'" + entidadesTabla.Telefonos + "'" + ", [UserNameEntidad] =" + "'" + entidadesTabla.UserNameEntidad + "'" + ", [PassworEntidad] = " + "'" + pass + "'" + " WHERE id_Entidad = " + id;
            var command = new SqlCommand(query, _db._connection);
            command.ExecuteNonQuery();


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

        public EntidadesTabla BuscarEntidad(string UsernameEntidad)
        {
            EntidadesTabla entidadesTabla = new EntidadesTabla();


            _db.OpenConnection();
            var command = _db._command;
            command.CommandText = "usp_EntidadesSelect";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Clear();
            command.Parameters.AddWithValue(Utils.UserNameEntidad, UsernameEntidad);
            var result = command.ExecuteReader();
            while (result.Read())
            {
                EntidadesTabla ent = new EntidadesTabla()
                {
                    UserNameEntidad = result["UserNameEntidad"].ToString(),
                    Descripcion = result["Descripcion"].ToString(),
                    Direccion = result["Direccion"].ToString(),
                    Localidad = result["Localidad"].ToString(),
                    NumeroDocumento = int.Parse(result["NumeroDocumento"].ToString()),
                    Telefonos = result["Telefonos"].ToString()
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
            var query = "Select t.UserNameEntidad,t.Telefonos,t.NumeroDocumento,t.Descripcion,t.Localidad, t.Direccion ,t.IdGrupoEntidad,t.NoEliminable,t.Status,t.TipoDocumento,t.RolUserEntidad, t.TipoEntidad  from dbo.Entidades t";
            var command = new SqlCommand(query, _db._connection);


            var result = command.ExecuteReader();
            while (result.Read())
            {
                Entidades ent = new Entidades()
                {
                    UserNameEntidad = result["UserNameEntidad"].ToString(),
                    Descripcion = result["Descripcion"].ToString(),
                    Direccion = result["Direccion"].ToString(),
                    Localidad = result["Localidad"].ToString(),
                    NumeroDocumento = int.Parse(result["NumeroDocumento"].ToString()),
                    Telefonos = result["Telefonos"].ToString(),
                    TipoEntidad = result["TipoEntidad"].ToString(),
                    TipoDocumento = result["TipoDocumento"].ToString(),
                    RolUserEntidad = result["RolUserEntidad"].ToString(),
                    Status = result["Status"].ToString(),
                    NoEliminable = result["NoEliminable"].ToString(),
                    IdGrupoEntidad = int.Parse(result["IdGrupoEntidad"].ToString())


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

        public bool ActualizarTipoEntidades(string descripcion, string UsuarioEntidad)
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

            var queryTipoEntidad = "select t.idTipoEntidad from TiposEntidades t where t.IdGrupoEntidad = " + IdGrupoEntidad + "";
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
                var query = "update Entidades set IdTipoEntidad  = " + IdTipoEntidad + " , IdGrupoEntidad = " + IdGrupoEntidad + "  where UserNameEntidad = '" + UsuarioEntidad + "'";
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


    }


}