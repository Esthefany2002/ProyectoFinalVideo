using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------
using EntidadDeNegocio;
using System.Data;
using System.Data.SqlClient;

//------------------------------------

namespace LogicadeAcessoADatos
{
    /// <summary>
    /// Clase de acceso a datos para la entidad Plataforma.
    /// Contiene métodos para realizar operaciones en el CRUDPlataforma utilizando procedimientos almacenados.
    /// </summary>
    /// <remarks>
    /// Integrante del equipo:
    /// - [Morena Zuniga]
    /// </remarks>
    public class PlataformaDAL : MetodosPlataforma
    {
        public override List<PlataformaEN> MostrarPlataforma()
        {
            List<PlataformaEN> _Lista = new List<PlataformaEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("MostrarPlataforma", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new PlataformaEN
                    {
                        Id = _reader.GetInt32(0),
                        Nombre = _reader.GetString(1)
                    });
                }
                _conn.Close();
            }
            return _Lista;
        }
        /// <summary>
        /// Guarda una nueva plataforma en la base de datos.
        /// Ejecuta el procedimiento almacenado "GuardarPlataforma".
        /// </summary>
        /// <param name="pPlataformaEN"></param>
        /// <returns></returns>
        public override int GuardarPlataforma(PlataformaEN pPlataformaEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("GuardarPlataforma", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Nombre", pPlataformaEN.Nombre));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Elimina una plataforma de la base de datos según su ID.
        /// Ejecuta el procedimiento almacenado "EliminarPlataforma".
        /// </summary>
        /// <param name="pPlataformaEN"></param>
        /// <returns></returns>
        public override int EliminarPlataforma(PlataformaEN pPlataformaEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("EliminarPlataforma", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pPlataformaEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Modifica los datos de una plataforma existente en la base de datos.
        /// Ejecuta el procedimiento almacenado "ModificarPlataforma".
        /// </summary>
        /// <param name="pPlataformaEN"></param>
        /// <returns></returns>
        public override int ModificarPlataforma(PlataformaEN pPlataformaEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                    new SqlCommand("ModificarPlataforma", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pPlataformaEN.Id));
                _comando.Parameters.Add(new SqlParameter("@Nombre", pPlataformaEN.Nombre));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
    }
}
