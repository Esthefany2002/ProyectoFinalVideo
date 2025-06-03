
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
    /// Clase de la capa de lógica de negocio para gestionar operaciones de la entidad Proveedor.
    /// Conecta la lógica de presentación con el acceso a datos.
    /// </summary>

    public class ProveedorBL
    {
        /// <summary>
        /// Obtiene la lista completa de proveedores desde la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<ProveedorEN> MostrarProveedor()
        {
            return ProveedorDAL.MostrarProveedor();
        }

        /// <summary>
        /// Guarda un nuevo proveedor en la base de datos.
        /// </summary>
        /// <param name="pproveedorEN"></param>
        /// <returns></returns>
        public int GuardarProveedor(ProveedorEN pproveedorEN)
        {
            return ProveedorDAL.GuardarProveedor(pproveedorEN);
        }
        /// <summary>
        /// Elimina un proveedor existente según su ID.
        /// </summary>
        /// <param name="pproveedorEN"></param>
        /// <returns></returns>
        public int EliminarProveedor(ProveedorEN pproveedorEN)
        {
            return ProveedorDAL.EliminarProveedor(pproveedorEN);
        }

        /// <summary>
        /// Modifica los datos de un proveedor existente.
        /// </summary>
        /// <param name="pproveedorEN"></param>
        /// <returns></returns>
        public int ModificarProveedor(ProveedorEN pproveedorEN)
        {
            return ProveedorDAL.ModificarProveedor(pproveedorEN);
        }
    }
}
