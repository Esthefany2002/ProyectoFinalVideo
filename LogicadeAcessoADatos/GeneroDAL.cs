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
    /// Clase para el acceso a datos de la entidad Genero,
    /// usando procedimientos almacenados en SQL Server.
    /// </summary>
    ///  <remarks>
    /// Integrante del equipo:
    /// - [Pedro Palma]
    /// </remarks>
    public class GeneroDAL : MetodosGenero
    {
        /// <summary>
        /// Obtiene todos los géneros registrados en la base de datos.
        /// </summary>
        /// <returns></returns>
        public override List<GeneroEN> MostrarGenero()
        {
            List<GeneroEN> _Lista = new List<GeneroEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("MostrarGenero", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new GeneroEN
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
        /// Guarda un nuevo género en la base de datos.
        /// </summary>
        /// <param name="pGeneroEN"></param>
        /// <returns></returns>

        public override int GuardarGenero(GeneroEN pGeneroEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("GuardarGenero", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Nombre", pGeneroEN.Nombre));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Elimina un género existente en la base de datos.
        /// </summary>
        /// <param name="pGeneroEN"></param>
        /// <returns></returns>
        public override int EliminarGenero(GeneroEN pGeneroEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("EliminarGenero", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pGeneroEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Modifica un género existente en la base de datos.
        /// </summary>
        /// <param name="pGeneroEN"></param>
        /// <returns></returns>
        public override int ModificarGenero(GeneroEN pGeneroEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                    new SqlCommand("ModificarGenero", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pGeneroEN.Id));
                _comando.Parameters.Add(new SqlParameter("@Nombre", pGeneroEN.Nombre));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
    }

}
