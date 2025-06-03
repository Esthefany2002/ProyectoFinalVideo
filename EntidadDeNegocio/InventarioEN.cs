using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeNegocio
{
    /// <summary>
    /// Representa la entidad Inventario dentro de la capa EntidadDeNegocio.
    /// Contiene la información relacionada con los videojuegos disponibles, su precio, stock y estado de venta.
    /// </summary>
    /// <remarks>
    /// Integrante del equipo:
    /// - [Marelin Mate]
    /// </remarks>
    public class InventarioEN
    {
        /// <summary>
        /// Identificador único del registro de inventario.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador del videojuego relacionado con este inventario.
        /// </summary>
        public int IdVideoJuegos { get; set; }

        /// <summary>
        /// Precio de venta del videojuego.
        /// </summary>
        public Decimal PrecioVenta { get; set; }

        /// <summary>
        /// Porcentaje de ganancia aplicado sobre el costo del videojuego.
        /// </summary>
        public Decimal  PorcentajeGanancia { get; set; }

        /// <summary>
        /// Cantidad inicial de unidades disponibles en inventario.
        /// </summary>
        public int StockInicial { get; set; }

        /// <summary>
        /// Cantidad inicial de unidades disponibles en inventario.
        /// </summary>
        public int Vendido { get; set; }


        /// <summary>
        /// Cantidad actual de unidades disponibles en inventario.
        /// </summary>
        public int StockActual { get; set; }

        /// <summary>
        /// Identificador del estado de la venta.
        /// </summary>
        public int IdEstadoVenta { get; set; }

        /// <summary>
        /// Identificador del empleado.
        /// </summary>
        public int IdEmpleado { get; set; }
    }
}



