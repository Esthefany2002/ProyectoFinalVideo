using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------
using EntidadDeNegocio;
using LogicadeAcessoADatos;
//--------------------------------
namespace LogicaDeNegocio
{
    /// <summary>
    /// Clase de la capa de lógica de negocio para gestionar operaciones de la entidad Inventario.
    /// Conecta la lógica de presentación con el acceso a datos.
    /// </summary>
    public class InventarioBL
    {

        /// <summary>
        /// Obtiene todos los registros del inventario desde la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<InventarioEN> MostrarInventario()
        {
            return InventarioDAL.MostrarInventario();
        }

        /// <summary>
        /// Guarda un nuevo registro de inventario en la base de datos.
        /// </summary>
        /// <param name="pinventarioEN"></param>
        /// <returns></returns>
        public int GuardarInventario(InventarioEN pinventarioEN)
        {
            return InventarioDAL.GuardarInventario(pinventarioEN);
        }

        /// <summary>
        /// Elimina un registro de inventario existente según su ID.
        /// </summary>
        /// <param name="pinventarioEN"></param>
        /// <returns></returns>
        public int EliminarInventario(InventarioEN pinventarioEN)
        {
            return InventarioDAL.EliminarInventario(pinventarioEN);
        }

        /// <summary>
        /// Modifica un registro existente de inventario.
        /// </summary>
        /// <param name="pinventarioEN"></param>
        /// <returns></returns>
        public int ModificarInventario(InventarioEN pinventarioEN)
        {
            return InventarioDAL.ModificarInventario(pinventarioEN);
        }
    }
}
