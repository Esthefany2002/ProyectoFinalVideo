using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeNegocio
{
    /// <summary>
    /// Representa la entidad Proveedor dentro de la capa EntidadDeNegocio.
    /// Contiene la información personal y de contacto de los proveedores del sistema.
    /// </summary>
    /// <remarks>
    /// Integrantes del equipo:
    /// - [Esau Perez]
    /// </remarks>
    public class ProveedorEN
    {
        /// <summary>
        /// Identificador único del proveedor.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del proveedor.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Apellido del proveedor.
        /// </summary>
        public string Apellido { get; set; }

        /// <summary>
        /// Número de celular del proveedor.
        /// </summary>
        public string NumerodeCel { get; set; }

        /// <summary>
        /// Correo electrónico del proveedor.
        /// </summary>
        public string CorreoElectronico { get; set; }

        /// <summary>
        /// Dirección del proveedor.
        /// </summary>
        public string Direccion { get; set; }
    }
}

