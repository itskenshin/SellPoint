using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones.Interfases
{
    public  interface ITransacciones 
    {
        
        Entidades Autenticacion(string user, string password);
        bool AgregarEntidad(Entidades entidades);
        Entidades VerEntidad(string user);
        bool EliminarEntidades(string user);
        List<Entidades> ListaEntidades();
        bool ActualizarEntidad(Entidades entidades,string UserEntidad,string pass);

        Entidades BuscarEntidad(string UsernameEntidad);

        int GetUsernaemEntidadId(string usernameEntidad);
        string GetPassowrdmEntidad(int id);

        List<string> GetTipoEntidades();
        List<string> GetGrupoEntidades();

        bool ActualizarTipoEntidades(string descripcion, string userNameEntidad,string user);
         int? GetTipoEntidadIdByGrupoEntidadId(int? grupoEntidadId);
        List<GruposEntidades> GrupoEntidadesLista();

        Tuple<int, string> GetGrupoIdByUsuario(string usernameEntidad);

        int GetGrupoEntidadIDByDesc(string descripcion);


        bool EliminarEntidad(string user);

        bool InsertarGrupoEntidad(GruposEntidades grupoEntidades);
        bool EliminarGrupoEntidad(int id);
        bool ActulizarGrupoEntidad(GruposEntidades gruposEntidades);






    }
}
