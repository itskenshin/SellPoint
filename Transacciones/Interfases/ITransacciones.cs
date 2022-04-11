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
        Entidades ActualizarEntidad(string user);


    }
}
