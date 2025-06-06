﻿using System;
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
    /// Clase de acceso a datos para la entidad Usuario.
    /// Contiene métodos para realizar operaciones en el  (CRUDUsuario) en este caso seria lo que es el Login y la verificación del login es mediante los procedimientos almacenados.
    /// </summary>
    /// <remarks>
    /// Integrante del equipo:
    /// - [Marelin Mate]
    /// </remarks>
    public class UsuarioDAL : MetodosUsiario
    {
        /// <summary>
        /// Verifica las credenciales de un usuario mediante el procedimiento almacenado "VerificarUsuario".
        /// </summary>
        /// <param name="pUsuarioEN">Objeto UsuarioEN con nombre, clave y cargo.</param>
        /// <returns>1 si el usuario existe y las credenciales son válidas.</returns>
        public override int VerificarUsuarioLogin(UsuarioEN pUsuarioEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("VerificarUsuario", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Nombre", pUsuarioEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@Clave", pUsuarioEN.Clave));
                _comando.Parameters.Add(new SqlParameter("@Cargo", pUsuarioEN.Cargo));
                int userExiste = (int?)_comando.ExecuteScalar() ?? 0;
                _conn.Close();
                return userExiste;
            }
        }
        /// <summary>
        /// Muestra los usuarios que coinciden con los filtros proporcionados.
        /// Ejecuta el procedimiento almacenado "MostrarUsuario".
        /// </summary>
        /// <param name="pUsuarioEN"></param>
        /// <returns>Lista de usuarios encontrados.</returns>

        public override List<UsuarioEN> MostrarUsuario(UsuarioEN pUsuarioEN)
        {
            List<UsuarioEN> _Lista = new List<UsuarioEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("MostrarUsuario", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Nombre", pUsuarioEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@Clave", pUsuarioEN.Clave));
                _comando.Parameters.Add(new SqlParameter("@Cargo", pUsuarioEN.Cargo));
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new UsuarioEN
                    {
                        Id = _reader.GetInt32(0),
                        Nombre = _reader.GetString(1),
                        Clave = _reader.GetString(2),
                        Cargo = _reader.GetString(3)
                    });
                }
                _conn.Close();
                return _Lista;
            }
        }
        /// <summary>
        /// Guarda un nuevo usuario en la base de datos mediante el procedimiento "GuardarUsuario".
        /// </summary>
        /// <param name="pUsuarioEN"></param>
        /// <returns></returns>

        public override int GuardarUsuario(UsuarioEN pUsuarioEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("GuardarUsuario", _conn as SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Nombre", pUsuarioEN.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Clave", pUsuarioEN.Clave));
                cmd.Parameters.Add(new SqlParameter("@Cargo", pUsuarioEN.Cargo));
                int resultado = cmd.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Modifica un usuario existente mediante el procedimiento "ModificarUsuario".
        /// </summary>
        /// <param name="pUsuarioEN"></param>
        /// <returns></returns>

        public override int ModificarUsuario(UsuarioEN pUsuarioEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("ModificarUsuario", _conn as SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Id", pUsuarioEN.Id));
                cmd.Parameters.Add(new SqlParameter("@Nombre", pUsuarioEN.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Clave", pUsuarioEN.Clave));
                cmd.Parameters.Add(new SqlParameter("@Cargo", pUsuarioEN.Cargo));
                int resultado = cmd.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        /// <summary>
        /// Elimina un usuario de la base de datos mediante el procedimiento "EliminarUsuario".
        /// </summary>
        /// <param name="pUsuarioEN"></param>
        /// <returns></returns>
        public override int EliminarUsuario(UsuarioEN pUsuarioEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("EliminarUsuario", _conn as SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Id", pUsuarioEN.Id));
                int resultado = cmd.ExecuteNonQuery();
                _conn.Close();
                return resultado;

            }
        }
    }

}
    

