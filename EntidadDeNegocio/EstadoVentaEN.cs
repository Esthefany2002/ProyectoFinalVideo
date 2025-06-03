using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeNegocio
{
    /// <summary>
    /// Representa la entidad EstadoVenta dentro de la capa EntidadDeNegocio.
    /// Contiene información sobre los distintos estados posibles de las ventas.
    /// </summary>
    /// <remarks>
    /// Integrante del equipo:
    /// - [Pedro Palma]
    /// </remarks>
    public class EstadoVentaEN
    {
        /// <summary>
        /// Identificador único del estado de la venta.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre o descripción del estado de la venta 
        /// </summary>
        public string Nombre { get; set; }
    }
}
