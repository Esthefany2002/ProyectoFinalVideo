using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------
using System.Data;
using System.Data.SqlClient;
//----------------------------

namespace LogicadeAcessoADatos
{
    class ComunBD
    {
        public enum TipoBD
        {
            SqlServer, Oracle, DB2
        }
        /// <summary>
        /// Cadena de conexión para SQL Server.
        /// Ajusta esta cadena según tu servidor y base de datos.
        /// </summary>
        public const string Sqlconn = @"Data Source=HP-ENVY;Initial Catalog=ProyectoFinalVJ;Integrated Security=True;TrustServerCertificate=True;";
        public static IDbConnection ObtenerConexion(TipoBD pTipoBD)
        {
            IDbConnection _conn;
            if (pTipoBD == TipoBD.SqlServer)
            {
                _conn = new SqlConnection(Sqlconn);
                return _conn;
            }
            return null;
        }
    }
}
    

