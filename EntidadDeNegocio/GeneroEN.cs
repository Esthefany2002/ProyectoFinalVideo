using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeNegocio
{
    /// <summary>
    /// Representa la entidad Genero dentro de la capa EntidadDeNegocio.
    /// Contiene las propiedades necesarias para identificar el género de un videojuego.
    /// </summary>
    /// <remarks>
    /// Integrante del equipo:
    /// - [Pedro Palma]
    /// </remarks>
    public class GeneroEN
     {
        /// <summary>
        /// Identificador único del genero.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre o descripción del genero.
        /// </summary>
        public string Nombre { get; set; }
     }
}
