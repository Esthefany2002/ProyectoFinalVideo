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
    /// Clase que contiene métodos para realizar operaciones en el CRUDInventario,
    /// usando procedimientos almacenados en SQL Server.
    /// </summary>
    ///  /// <remarks>
    /// Integrante del equipo:
    /// - [Marelin Mate]
    /// </remarks>
    public class InventarioDAL : MetodosInventario
    {
        /// <summary>
        /// Obtiene todos los registros de inventario de la base de datos.
        /// Ejecuta el procedimiento almacenado "MostrarInventario".
        /// </summary>
        /// <returns></returns>
        public override List<InventarioEN> MostrarInventario()
        {
            List<InventarioEN> _Lista = new List<InventarioEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("MostrarInventario", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new InventarioEN
                    {
                        Id = _reader.GetInt32(0),
                        IdVideoJuegos = _reader.GetInt32(1),
                        PrecioVenta = _reader.GetDecimal(2),                  
                        PorcentajeGanancia = _reader.GetDecimal(3),
                        StockInicial = _reader.GetInt32(4),
                        Vendido = _reader.GetInt32(5),
                        StockActual = _reader.GetInt32(6),
                        IdEstadoVenta = _reader.GetInt32(7),
                        IdEmpleado = _reader.GetInt32(8)
                    });
                     


    }
                _conn.Close();
            }
            return _Lista;
        }
        /// <summary>
        /// Inserta un nuevo registro de inventario en la base de datos.
        /// Ejecuta el procedimiento almacenado "GuardarInventario".
        /// </summary>
        /// <param name="pInventarioEN">Objeto InventarioEN con los datos a insertar.</param>
        /// <returns>Número de filas afectadas.</returns>
        public override int GuardarInventario(InventarioEN pInventarioEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("GuardarInventario", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pInventarioEN.Id));
                _comando.Parameters.Add(new SqlParameter("@IdVideoJuegos", pInventarioEN.IdVideoJuegos));
                _comando.Parameters.Add(new SqlParameter("@PrecioVenta", pInventarioEN.PrecioVenta));
                _comando.Parameters.Add(new SqlParameter("@PorcentajeGanancia", pInventarioEN.PorcentajeGanancia));
                _comando.Parameters.Add(new SqlParameter("@StockInicial", pInventarioEN.StockInicial));
                _comando.Parameters.Add(new SqlParameter("@Vendido", pInventarioEN.Vendido));
                _comando.Parameters.Add(new SqlParameter("@StockActual", pInventarioEN.StockActual));
                _comando.Parameters.Add(new SqlParameter("@IdEstadoVenta", pInventarioEN.IdEstadoVenta));
                _comando.Parameters.Add(new SqlParameter("@IdEmpleado", pInventarioEN.IdEmpleado));


                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Elimina un registro de inventario según su ID.
        /// Ejecuta el procedimiento almacenado "EliminarInventario".
        /// </summary>
        /// <param name="pInventarioEN">Objeto InventarioEN con el ID del registro a eliminar.</param>
        /// <returns>Número de filas afectadas.</returns>

        public override int EliminarInventario(InventarioEN pInventarioEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("EliminarInventario", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pInventarioEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Modifica los datos de un registro de inventario existente.
        /// Ejecuta el procedimiento almacenado "ModificarInventario".
        /// </summary>
        /// <param name="pInventarioEN">Objeto InventarioEN con los nuevos datos a actualizar.</param>
        /// <returns>Número de filas afectadas.</returns>
        public override int ModificarInventario(InventarioEN pInventarioEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                 new SqlCommand("ModificarInventario", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pInventarioEN.Id));
                _comando.Parameters.Add(new SqlParameter("@IdVideoJuegos", pInventarioEN.IdVideoJuegos));
                _comando.Parameters.Add(new SqlParameter("@PrecioVenta", pInventarioEN.PrecioVenta));
                _comando.Parameters.Add(new SqlParameter("@PorcentajeGanancia", pInventarioEN.PorcentajeGanancia));
                _comando.Parameters.Add(new SqlParameter("@StockInicial", pInventarioEN.StockInicial));
                _comando.Parameters.Add(new SqlParameter("@Vendido", pInventarioEN.Vendido));
                _comando.Parameters.Add(new SqlParameter("@StockActual", pInventarioEN.StockActual));
                _comando.Parameters.Add(new SqlParameter("@IdEstadoVenta", pInventarioEN.IdEstadoVenta));
                _comando.Parameters.Add(new SqlParameter("@IdEmpleado", pInventarioEN.IdEmpleado));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }


    }
}
