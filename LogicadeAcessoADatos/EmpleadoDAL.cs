using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------
using EntidadDeNegocio;
using System.Data;
using System.Data.SqlClient;

//------------------------------------


namespace LogicadeAcessoADatos
{
    /// <summary>
    /// Clase encargada de manejar el acceso a datos para la entidad Empleado,
    /// mediante la ejecución de procedimientos almacenados en la base de datos.
    /// </summary>
    /// <remarks>
    /// Integrante del equipo:
    /// - [Marelin Mate]
    /// </remarks>
    public class EmpleadoDAL : MetodosEmpleado
    {
        /// <summary>
        /// Obtiene una lista de todos los empleados desde la base de datos.
        /// Ejecutando el procedimiento almacenado "MostrarEmpleado".
        /// </summary>
        /// <returns>Lista de objetos EmpleadoEN con todos los empleados registrados.</returns>
        //public static List<EmpleadoEN> MostrarEmpleado()
        //{
        //    List<EmpleadoEN> _Lista = new List<EmpleadoEN>();
        //    using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
        //    {
        //        _conn.Open();
        //        SqlCommand _comando =
        //        new SqlCommand("MostrarEmpleado", _conn as SqlConnection);
        //        _comando.CommandType = CommandType.StoredProcedure;
        //        IDataReader _reader = _comando.ExecuteReader();
        //        while (_reader.Read())
        //        {
        //            _Lista.Add(new EmpleadoEN
        //            {
        //                Id = _reader.GetInt32(0),
        //                IdCargo = _reader.GetInt32(1),
        //                Celular = _reader.GetString(2),
        //                CorreoElectronico = _reader.GetString(3),
        //                Nombre = _reader.GetString(4),
        //                Apellido = _reader.GetString(5),
        //                Direccion = _reader.GetString(6)
        //            });
        //        }
        //        _conn.Close();
        //    }
        //    return _Lista;
        //}
        /// <summary>
        /// Guarda un nuevo empleado en la base de datos.
        /// </summary>
        /// <param name="pEmpleadoEN"></param>
        /// <returns></returns>
        public override int GuardarEmpleado(EmpleadoEN pEmpleadoEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("GuardarEmpleado", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@IdCargo", pEmpleadoEN.IdCargo));
                _comando.Parameters.Add(new SqlParameter("@Celular", pEmpleadoEN.Celular));
                _comando.Parameters.Add(new SqlParameter("@CorreoElectronico", pEmpleadoEN.CorreoElectronico));
                _comando.Parameters.Add(new SqlParameter("@Nombre", pEmpleadoEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@Apellido", pEmpleadoEN.Apellido));
                _comando.Parameters.Add(new SqlParameter("@Direccion", pEmpleadoEN.Direccion));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Elimina un  empleado de la base de datos.
        /// </summary>
        /// <param name="pEmpleadoEN"></param>
        /// <returns></returns>

        public override int EliminarEmpleado(EmpleadoEN pEmpleadoEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("EliminarEmpleado", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pEmpleadoEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Modifica los datos de un empleado existente en la base de datos.
        /// </summary>
        /// <param name="pEmpleadoEN"></param>
        /// <returns></returns>
        public override int ModificarEmpleado(EmpleadoEN pEmpleadoEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                    new SqlCommand("ModificarEmpleado", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pEmpleadoEN.Id));
                _comando.Parameters.Add(new SqlParameter("@IdCargo", pEmpleadoEN.IdCargo));
                _comando.Parameters.Add(new SqlParameter("@Celular", pEmpleadoEN.Celular));
                _comando.Parameters.Add(new SqlParameter("@CorreoElectronico", pEmpleadoEN.CorreoElectronico));
                _comando.Parameters.Add(new SqlParameter("@Nombre", pEmpleadoEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@Apellido", pEmpleadoEN.Apellido));
                _comando.Parameters.Add(new SqlParameter("@Direccion", pEmpleadoEN.Direccion));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }

        public override List<EmpleadoEN> MostrarEmpleado()
        {
            List<EmpleadoEN> _Lista = new List<EmpleadoEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("MostrarEmpleado", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new EmpleadoEN
                    {
                        Id = _reader.GetInt32(0),
                        IdCargo = _reader.GetInt32(1),
                        Celular = _reader.GetString(2),
                        CorreoElectronico = _reader.GetString(3),
                        Nombre = _reader.GetString(4),
                        Apellido = _reader.GetString(5),
                        Direccion = _reader.GetString(6)
                    });
                }
                _conn.Close();
            }
            return _Lista;
        }
    }
}

