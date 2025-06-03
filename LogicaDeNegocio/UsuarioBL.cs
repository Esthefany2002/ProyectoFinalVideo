
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------
using EntidadDeNegocio;
using LogicadeAcessoADatos;
//-------------------------------------

namespace LogicaDeNegocio
{
    /// <summary>
    /// Clase de la capa de lógica de negocio para gestionar operaciones de la entidad Usuario.
    /// Contiene métodos para verificar login, mostrar, guardar, eliminar y modificar usuarios.
    /// </summary>
    public class UsuarioBL
    {

        /// <summary>
        /// Verifica si un usuario con las credenciales proporcionadas existe y es válido.
        /// </summary>
        /// <param name="pUsuarioEN"></param>
        /// <returns></returns>
        public int VerificarUsuarioLogin(UsuarioEN pUsuarioEN)
        {
            return UsuarioDAL.VerificarUsuarioLogin(pUsuarioEN);
        }

        /// <summary>
        /// Obtiene una lista de usuarios desde la base de datos, según los criterios indicados en la clase de  UsuarioEN.
        /// </summary>
        /// <param name="pUsuarioEN"></param>
        /// <returns></returns>

        public List<UsuarioEN> MostrarUsuario(UsuarioEN pUsuarioEN)
        {
            return UsuarioDAL.MostrarUsuario(pUsuarioEN);
        }

        /// <summary>
        /// Guarda un nuevo usuario en la base de datos.
        /// </summary>
        /// <param name="pUsuarioEN"></param>
        /// <returns></returns>
        public int GuardarUsuario(UsuarioEN pUsuarioEN)
        {
            return UsuarioDAL.GuardarUsuario(pUsuarioEN);
        }

        /// <summary>
        /// Elimina un usuario existente basado en su identificador.
        /// </summary>
        /// <param name="pUsuarioEN"></param>
        /// <returns></returns>
        public int EliminarUsuario(UsuarioEN pUsuarioEN)
        {
            return UsuarioDAL.EliminarUsuario(pUsuarioEN);
        }

        /// <summary>
        /// Modifica los datos de un usuario existente.
        /// </summary>
        /// <param name="pUsuarioEN"></param>
        /// <returns></returns>
        public int ModificarUsuario(UsuarioEN pUsuarioEN)
        {
            return UsuarioDAL.ModificarUsuario(pUsuarioEN);
        }
    }
}
