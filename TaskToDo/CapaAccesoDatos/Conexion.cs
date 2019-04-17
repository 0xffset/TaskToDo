using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        #region single
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get
            {
                return Conexion._instancia;
            }
        }
        #endregion

        public SqlConnection conecta()
        {
            try
            {
                SqlConnection c = new SqlConnection();
                c.ConnectionString = "Data Source=ROLEYDER-PC\\SQLEXPRESS;Initial Catalog=TaskToDo;Integrated Security=True";
                return c;
            }
            catch (Exception) { throw; }
        }


    }
}
