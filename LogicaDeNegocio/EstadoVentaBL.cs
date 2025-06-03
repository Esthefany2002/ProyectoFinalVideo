using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------
using EntidadDeNegocio;
using LogicadeAcessoADatos;
//------------------------------

namespace LogicaDeNegocio
{
    /// <summary>
    /// Clase de la capa de lógica de negocio para gestionar operaciones de la entidad EstadoVenta.
    /// Conecta la lógica de presentación con el acceso a datos.
    /// </summary>
    public class EstadoVentaBL
    {
        /// <summary>
        /// Obtiene la lista completa de estados de venta desde la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<EstadoVentaEN> MostrarEstadoVenta()
        {
            return EstadoVentaDAL.MostrarEstadoVenta();
        }

        /// <summary>
        /// Guarda un nuevo estado de venta en la base de datos.
        /// </summary>
        /// <param name="pestadoventaEN"></param>
        /// <returns></returns>
        public int GuardarEstadoVenta(EstadoVentaEN pestadoventaEN)
        {
            return EstadoVentaDAL.GuardarEstadoVenta(pestadoventaEN);
        }

        /// <summary>
        /// Elimina un estado de venta existente según su ID.
        /// </summary>
        /// <param name="pestadoventaEN"></param>
        /// <returns></returns>
        public int EliminarEstadoVenta(EstadoVentaEN pestadoventaEN)
        {
            return EstadoVentaDAL.EliminarEstadoVenta(pestadoventaEN);
        }

        /// <summary>
        /// Modifica los datos de un estado de venta existente.
        /// </summary>
        /// <param name="pestadoventaEN"></param>
        /// <returns></returns>
        public int ModificarEstadoVenta(EstadoVentaEN pestadoventaEN)
        {
            return EstadoVentaDAL.ModificarEstadoVenta(pestadoventaEN);
        }

    }
}
