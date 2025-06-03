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
    /// Clase de la capa de lógica de negocio para la entidad Cargo.
    /// Coordina las operaciones entre la capa de acceso a datos y otras capas del sistema.
    /// </summary>
    public class CargoBL
    {
        /// <summary>
        /// Obtiene la lista de todos los cargos registrados.
        /// </summary>
        /// <returns></returns>
        public List<CargoEN> MostrarCargo()
        {
            return CargoDAL.MostrarCargo();
        }

        /// <summary>
        /// Guarda un nuevo cargo en la base de datos.
        /// </summary>
        /// <param name="pcargoEN"></param>
        /// <returns></returns>
        public int GuardarCargo(CargoEN pcargoEN)
        {
            return CargoDAL.GuardarCargo(pcargoEN);
        }

        /// <summary>
        /// Elimina un cargo existente de la base de datos.
        /// </summary>
        /// <param name="pcargoEN"></param>
        /// <returns></returns>
        public int EliminarCargo(CargoEN pcargoEN)
        {
            return CargoDAL.EliminarCargo(pcargoEN);
        }

        /// <summary>
        ///  Modifica los datos de un cargo existente.
        /// </summary>
        /// <param name="pcargoEN"></param>
        /// <returns></returns>
        public int ModificarCargo(CargoEN pcargoEN)
        {
            return CargoDAL.ModificarCargo(pcargoEN);
        }
    }
}
