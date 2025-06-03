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
    /// Clase de acceso a datos para la entidad Categoria.
    /// Contiene métodos para realizar operaciones en el CRUDCategoria usando procedimientos almacenados.
    /// </summary>
    /// <remarks>
    /// Integrante del equipo:
    /// - [Esau Perez]
    /// </remarks>
    public class CategoriaDAL : MetodosCategoria
    {
        /// <summary>
        /// Obtiene una lista con todas las categorías de la base de datos.
        /// </summary>
        /// <returns></returns>
        public override List<CategoriaEN> MostrarCategoria()
        {
            List<CategoriaEN> _Lista = new List<CategoriaEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("MostrarCategoria", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new CategoriaEN
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
        /// Guarda una nueva categoría en la base de datos.
        /// </summary>
        /// <param name="pCategoriaEN"></param>
        /// <returns></returns>
        public override int GuardarCategoria(CategoriaEN pCategoriaEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("GuardarCategoria", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Nombre", pCategoriaEN.Nombre));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        
        /// <summary>
        ///  Elimina una categoría de la base de datos según su Id.
        /// </summary>
        /// <param name="pCategoriaEN"></param>
        /// <returns>Número de filas afectadas</returns>
        public override int EliminarCategoria(CategoriaEN pCategoriaEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("EliminarCategoria", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pCategoriaEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Modifica una categoría existente en la base de datos.
        /// </summary>
        /// <param name="pCategoriaEN"></param>
        /// <returns></returns>
        public override int ModificarCategoria(CategoriaEN pCategoriaEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                    new SqlCommand("ModificarCategoria", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pCategoriaEN.Id));
                _comando.Parameters.Add(new SqlParameter("@Nombre", pCategoriaEN.Nombre));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
    }
}
