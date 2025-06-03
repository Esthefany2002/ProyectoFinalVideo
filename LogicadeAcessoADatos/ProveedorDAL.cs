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
    /// Clase de acceso a datos para la entidad Proveedor.
    /// Contiene métodos para realizar operaciones CRUD utilizando procedimientos almacenados.
    /// </summary>
    /// <remarks>
    /// Integrante del equipo:
    /// - [Esau Perez]
    /// </remarks>
    public class ProveedorDAL : MetodosProveedor
    {
        /// <summary>
        /// Obtiene una lista de todos los proveedores desde la base de datos.
        /// Ejecuta el procedimiento almacenado "MostrarProveedor".
        /// </summary>
        /// <returns>Lista de objetos ProveedorEN.</returns>
        public override List<ProveedorEN> MostrarProveedor()
        {
            List<ProveedorEN> _Lista = new List<ProveedorEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("MostrarProveedor", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new ProveedorEN
                    {
                        Id = _reader.GetInt32(0),
                        Nombre = _reader.GetString(1),
                        Apellido = _reader.GetString(2),
                        NumerodeCel = _reader.GetString(3),
                        CorreoElectronico = _reader.GetString(4),
                        Direccion = _reader.GetString(5)
                    });
                }
                _conn.Close();
            }
            return _Lista;
        }
        /// <summary>
        /// Guarda un nuevo proveedor en la base de datos.
        /// Ejecuta el procedimiento almacenado "GuardarProveedor".
        /// </summary>
        /// <param name="pProveedorEN"></param>
        /// <returns></returns>
        public override int GuardarProveedor(ProveedorEN pProveedorEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("GuardarProveedor", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Nombre", pProveedorEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@Apellido", pProveedorEN.Apellido));
                _comando.Parameters.Add(new SqlParameter("@NumerodeCel", pProveedorEN.NumerodeCel));
                _comando.Parameters.Add(new SqlParameter("@CorreoElectronico", pProveedorEN.CorreoElectronico));
                _comando.Parameters.Add(new SqlParameter("@Direccion", pProveedorEN.Direccion));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Elimina un proveedor de la base de datos según su ID.
        /// Ejecuta el procedimiento almacenado "EliminarProveedor".
        /// </summary>
        /// <param name="pProveedorEN"></param>
        /// <returns></returns>
        public override int EliminarProveedor(ProveedorEN pProveedorEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("EliminarProveedor", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pProveedorEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Modifica los datos de un proveedor existente en la base de datos.
        /// Ejecuta el procedimiento almacenado "ModificarProveedor".
        /// </summary>
        /// <param name="pProveedorEN"></param>
        /// <returns></returns>
        public override int ModificarProveedor(ProveedorEN pProveedorEN)
        {
            using (IDbConnection _conn =
                ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                    new SqlCommand("ModificarProveedor", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pProveedorEN.Id));
                _comando.Parameters.Add(new SqlParameter("@Nombre", pProveedorEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@Apellido", pProveedorEN.Apellido));
                _comando.Parameters.Add(new SqlParameter("@NumerodeCel", pProveedorEN.NumerodeCel));
                _comando.Parameters.Add(new SqlParameter("@CorreoElectronico", pProveedorEN.CorreoElectronico));
                _comando.Parameters.Add(new SqlParameter("@Direccion", pProveedorEN.Direccion));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
    }
}
