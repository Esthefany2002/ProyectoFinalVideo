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
    /// Clase de acceso a datos para la entidad Cargo.
    /// Contiene métodos para realizar operaciones en el  CRUDCargo utilizando procedimientos almacenados.
    /// </summary>
    /// <remarks>
    /// Integrante del equipo:
    /// - [Morena Zuniga]
    /// </remarks>
    public class CargoDAL : MetodosCargo
    {
        /// <summary>
        /// Obtiene la lista de todos los cargos desde la base de datos.
        /// </summary>
        /// <returns>Lista de objetos CargoEN.</returns>
        public override List<CargoEN> MostrarCargo()
        {
            List<CargoEN> _Lista = new List<CargoEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("MostrarCargo", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new CargoEN
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
        /// Guarda un nuevo registro de cargo en la base de datos.
        /// </summary>
        /// <param name="pCargoEN"></param>
        /// <returns></returns>

        public override int GuardarCargo(CargoEN pCargoEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("GuardarCargo", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Nombre", pCargoEN.Nombre));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Elimina un registro de cargo de la base de datos.
        /// </summary>
        /// <param name="pCargoEN"></param>
        /// <returns></returns>
        public override int EliminarCargo(CargoEN pCargoEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("EliminarCargo", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pCargoEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Modifica un registro de cargo existente en la base de datos.
        /// </summary>
        /// <param name="pCargoEN"></param>
        /// <returns></returns>
        public override int ModificarCargo(CargoEN pCargoEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                    new SqlCommand("ModificarCargo", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pCargoEN.Id));
                _comando.Parameters.Add(new SqlParameter("@Nombre", pCargoEN.Nombre));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
    }
}
