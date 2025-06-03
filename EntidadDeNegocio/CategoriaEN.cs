using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeNegocio
{
    /// <summary>
    /// Representa la entidad Categoria dentro de la capa EntidadDeNegocio.
    /// Contiene las propiedades básicas necesarias para identificar una categoria.
    /// </summary>
    /// <remarks>
    /// Integrante del equipo:
    /// - [Esau Perez]
    /// </remarks>
    public class CategoriaEN 
    {
        /// <summary>
        /// Identificador único de la categoria.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre o descripción de la categoria.
        /// </summary>
        public string Nombre { get; set; }
    }
}
