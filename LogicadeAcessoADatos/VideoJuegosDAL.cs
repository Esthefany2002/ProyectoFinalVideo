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
    /// Clase de acceso a datos para la entidad VideoJuegos.
    /// Contiene métodos para realizar operaciones en el CRUDVideoJuegos usando procedimientos almacenados en SQL Server.
    /// </summary>
    /// <remarks>
    /// Integrante del equipo:
    /// - [Carlos Cruz]
    /// </remarks>
    public class VideoJuegosDAL : MetodosVideoJuegos
    {
        /// <summary>
        /// Obtiene una lista de todos los videojuegos desde la base de datos.
        /// Ejecuta el procedimiento almacenado "MostrarVideoJuegos".
        /// </summary>
        /// <returns></returns>
        public override List<VideoJuegosEN> MostrarVideoJuegos()
        {
            List<VideoJuegosEN> _Lista = new List<VideoJuegosEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("MostrarVideoJuegos", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new VideoJuegosEN
                    {
                        Id = _reader.GetInt32(0),
                        Nombre = _reader.GetString(1),
                        IdPlataforma = _reader.GetInt32(2),
                        IdGenero = _reader.GetInt32(3),
                        IdCategoria = _reader.GetInt32(4),
                        IdProveedor = _reader.GetInt32(5),
                        PrecioUnitario = _reader.GetDecimal(6)
                    });
                }
                _conn.Close();
            }
            return _Lista;
        }
        /// <summary>
        /// Guarda un nuevo videojuego en la base de datos.
        /// Ejecuta el procedimiento almacenado "GuardarVideoJuegos".
        /// </summary>
        /// <param name="pVideoJuegosEN"></param>
        /// <returns></returns>
        public override int GuardarVideoJuegos(VideoJuegosEN pVideoJuegosEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("GuardarVideoJuegos", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Nombre", pVideoJuegosEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@IdPlataforma", pVideoJuegosEN.IdPlataforma));
                _comando.Parameters.Add(new SqlParameter("@IdGenero", pVideoJuegosEN.IdGenero));
                _comando.Parameters.Add(new SqlParameter("@IdCategoria", pVideoJuegosEN.IdCategoria));
                _comando.Parameters.Add(new SqlParameter("@IdProveedor", pVideoJuegosEN.IdProveedor));
                _comando.Parameters.Add(new SqlParameter("@PrecioUnitario", pVideoJuegosEN.PrecioUnitario));


                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Elimina un videojuego de la base de datos.
        /// Ejecuta el procedimiento almacenado "EliminarVideoJuegos".
        /// </summary>
        /// <param name="pVideoJuegosEN"></param>
        /// <returns></returns>
        public override int EliminarVideoJuegos(VideoJuegosEN pVideoJuegosEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("EliminarVideoJuegos", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pVideoJuegosEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Modifica los datos de un videojuego existente.
        /// Ejecuta el procedimiento almacenado "ModificarVideoJuegos".
        /// </summary>
        /// <param name="pVideoJuegosEN"></param>
        /// <returns></returns>
        public override int ModificarVideoJuegos(VideoJuegosEN pVideoJuegosEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                    new SqlCommand("ModificarVideoJuegos", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pVideoJuegosEN.Id));
                _comando.Parameters.Add(new SqlParameter("@Nombre", pVideoJuegosEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@IdPlataforma", pVideoJuegosEN.IdPlataforma));
                _comando.Parameters.Add(new SqlParameter("@IdGenero", pVideoJuegosEN.IdGenero));
                _comando.Parameters.Add(new SqlParameter("@IdCategoria", pVideoJuegosEN.IdCategoria));
                _comando.Parameters.Add(new SqlParameter("@IdProveedor", pVideoJuegosEN.IdProveedor));
                _comando.Parameters.Add(new SqlParameter("@PrecioUnitario", pVideoJuegosEN.PrecioUnitario));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
    }
}
