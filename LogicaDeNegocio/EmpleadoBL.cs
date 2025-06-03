using EntidadDeNegocio;
using LogicadeAcessoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    /// <summary>
    /// Clase de la capa de lógica de negocio para gestionar operaciones de la entidad Empleado.
    /// Conecta la lógica de presentación con el acceso a datos.
    /// </summary>
    public class EmpleadoBL
    {
        /// <summary>
        /// Obtiene la lista completa de empleados desde la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<EmpleadoEN> MostrarEmpleado()
        {
            return EmpleadoDAL.MostrarEmpleado();
        }

        /// <summary>
        /// Guarda un nuevo empleado en la base de datos.
        /// </summary>
        /// <param name="pempleadoEN"></param>
        /// <returns></returns>
        public int GuardarEmpleado(EmpleadoEN pempleadoEN)
        {
            return EmpleadoDAL.GuardarEmpleado(pempleadoEN);
        }

        /// <summary>
        /// Elimina un empleado existente según su ID.
        /// </summary>
        /// <param name="pempleadoEN"></param>
        /// <returns></returns>
        public int EliminarEmpleado(EmpleadoEN pempleadoEN)
        {
            return EmpleadoDAL.EliminarEmpleado(pempleadoEN);
        }

        /// <summary>
        /// Modifica los datos de un empleado existente.
        /// </summary>
        /// <param name="pempleadoEN"></param>
        /// <returns></returns>
        public int ModificarEmpleado(EmpleadoEN pempleadoEN)
        {
            return EmpleadoDAL.ModificarEmpleado(pempleadoEN);
        }
    }
}
