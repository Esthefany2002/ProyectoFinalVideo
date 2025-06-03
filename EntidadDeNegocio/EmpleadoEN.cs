using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeNegocio
{
    /// <summary>
    /// Representa la entidad Empleado dentro de la capa EntidadDeNegocio.
    /// Contiene las propiedades que describen un empleado, incluyendo su cargo y datos personales.
    /// </summary>
    /// <remarks>
    /// Integrante del equipo:
    /// - [Marelin Mate]
    /// </remarks>

    public class EmpleadoEN
    {
        /// <summary>
        /// Identificador único del empleado.
        /// </summary>

        public int Id { get; set; }

        /// <summary>
        /// Identificador del cargo asignado al empleado.
        /// </summary>
        public int IdCargo { get; set; }


        /// <summary>
        /// Número de celular del empleado.
        /// </summary>
        public string Celular { get; set; }
        /// <summary>
        /// Correo electronico del empleado
        /// </summary>
        public string CorreoElectronico { get; set; }
        /// <summary>
        /// Nombre del empleado.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Apellido del empleado.
        /// </summary>
        public string Apellido { get; set; }


        /// <summary>
        /// Direccion del empleado
        /// </summary>
        public string Direccion { get; set; }
    }
}
