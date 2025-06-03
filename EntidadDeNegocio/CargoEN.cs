using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeNegocio
{
    /// <summary>
    /// Representa la entidad Cargo dentro de la capa EntidadDeNegocio.
    /// Contiene las propiedades básicas necesarias para identificar un cargo.
    /// </summary>
    /// <remarks>
    /// Integrante del equipo:
    /// - [Morena Zuniga]
    /// </remarks>
    public class CargoEN
    {
            /// <summary>
            /// Identificador único del cargo.
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// Nombre o descripción del cargo.
            /// </summary>
            public string Nombre { get; set; }
            public string Fecha { get; set; }
    }
}
