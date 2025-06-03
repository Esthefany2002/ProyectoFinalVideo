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
    /// Clase para el acceso a datos de la entidad EstadoVenta,
    /// mediante procedimientos almacenados en SQL Server.
    /// </summary>
    /// <remarks>
    /// Integrante del equipo:
    /// - [Pedro Palma]
    /// </remarks>
    public class EstadoVentaDAL : MetodosEstadoVenta
    {
        /// <summary>
        /// Obtiene la lista completa de los  estados de venta.
        /// Ejecutando el procedimiento almacenado "MostrarEstadoVenta".
        /// </summary>
        public override List<EstadoVentaEN> MostrarEstadoVenta()
        {
            List<EstadoVentaEN> _Lista = new List<EstadoVentaEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("MostrarEstadoVenta", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new EstadoVentaEN
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
        /// Guarda un nuevo estado de venta en la base de datos.
        /// </summary>
        /// <param name="pEstadoVentaEN">Objeto EstadoVentaEN con el nombre del estado a guardar.</param>
        /// <returns></returns>
        public override int GuardarEstadoVenta(EstadoVentaEN pEstadoVentaEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("GuardarEstadoVenta", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Nombre", pEstadoVentaEN.Nombre));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Elimina un estado de venta de la base de datos.
        /// </summary>
        /// <param name="pEstadoVentaEN">Objeto EstadoVentaEN con el Id del estado a eliminar.</param>
        /// <returns></returns>

        public override int EliminarEstadoVenta(EstadoVentaEN pEstadoVentaEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("EliminarEstadoVenta", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pEstadoVentaEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Modifica un estado de venta existente en la base de datos.
        /// </summary>
        /// <param name="pEstadoVentaEN">Objeto EstadoVentaEN con Id y nuevo nombre para actualizar.</param>
        /// <returns></returns>
        public override int ModificarEstadoVenta(EstadoVentaEN pEstadoVentaEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                    new SqlCommand("ModificarEstadoVenta", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pEstadoVentaEN.Id));
                _comando.Parameters.Add(new SqlParameter("@Nombre", pEstadoVentaEN.Nombre));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
    }
}

