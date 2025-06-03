using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeNegocio
{
    /// <summary>
    /// Representa la entidad VideoJuegos dentro de la capa EntidadDeNegocio.
    /// Contiene información relacionada con los videojuegos registrados en el sistema.
    /// </summary>
    /// <remarks>
    /// Integrantes del equipo:
    /// - [Carlos Cruz]
    /// </remarks>
    public class VideoJuegosEN
    {
        /// <summary>
        /// Identificador único del videojuego.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del videojuego.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Identificador de la plataforma en la que se puede jugar el videojuego.
        /// </summary>
        public int IdPlataforma { get; set; }

        /// <summary>
        /// Identificador del género al que pertenece el videojuego.
        /// </summary>
        public int IdGenero { get; set; }

        /// <summary>
        /// Identificador de la categoría del videojuego.
        /// </summary>
        public int IdCategoria { get; set; }

        /// <summary>
        /// Identificador del proveedor que suministra el videojuego.
        /// </summary>
        public int IdProveedor { get; set; }

        /// <summary>
        /// Precio unitario del videojuego.
        /// </summary>
        public Decimal PrecioUnitario { get; set; }
    }
}
