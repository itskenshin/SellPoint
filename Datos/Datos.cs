using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    public class Datos
    {
        public  SqlConnection _connection;
        public SqlCommand _command;
        
        private string Command;

        public Datos()
        {
            _connection = new SqlConnection();
            _command = new SqlCommand(Command,this._connection);
            
            
            
        }

        public  void OpenConnection()
        {
          var connectionString =  _connection.ConnectionString = ConfigurationManager.ConnectionStrings[2].ConnectionString;
            if (connectionString!= String.Empty)
            {
                try
                {
                    _connection.Open();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
           
           
        }
        public  void CloseConnection()
        {
            _connection.Close();
            _connection.Dispose();
        }


       

    }
}
