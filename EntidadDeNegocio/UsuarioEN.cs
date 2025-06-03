using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeNegocio
{
    /// <summary>
    /// Representa la entidad Usuario dentro de la capa EntidadDeNegocio.
    /// Contiene la información básica de autenticación y rol del usuario en el sistema.
    /// </summary>
    /// <remarks>
    /// Integrantes del equipo:
    /// - [Marelin Mate]
    /// </remarks>
    public class UsuarioEN
    {
        /// <summary>
        /// Identificador único del usuario.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de usuario utilizado para iniciar sesión.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Contraseña del usuario para autenticación.
        /// </summary>
        public string Clave { get; set; }

        /// <summary>
        /// Cargo o rol que tiene el usuario en el sistema.
        /// </summary>
        public string Cargo { get; set; }
    }
}

