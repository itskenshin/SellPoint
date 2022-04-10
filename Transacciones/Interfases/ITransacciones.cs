using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones.Interfases
{
    public interface ITransacciones
    {

        Object Autenticacion(string user, string password);

    }
}
