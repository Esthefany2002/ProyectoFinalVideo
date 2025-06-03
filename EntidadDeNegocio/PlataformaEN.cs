using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeNegocio
{ /// <summary>
  /// Representa la entidad Plataforma dentro de la capa EntidadDeNegocio.
  /// Contiene información sobre las plataformas en las que se pueden jugar los videojuegos.
  /// </summary>
  /// <remarks>
  /// Integrante del equipo:
  /// - [Morena Zuniga]
  /// </remarks>
    public class PlataformaEN
    {
        /// <summary>
        /// Identificador único de la plataforma.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la plataforma.
        /// </summary>
        public string Nombre { get; set; }
    }
}
