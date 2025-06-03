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
    /// Clase de la capa de lógica de negocio para gestionar operaciones de la entidad Género.
    /// Conecta la lógica de presentación con el acceso a datos.
    /// </summary>
    public class GeneroBL
     {
        /// <summary>
        /// Obtiene la lista completa de géneros desde la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<GeneroEN> MostrarGenero()
        {
            return GeneroDAL.MostrarGenero();
        }

        /// <summary>
        /// Guarda un nuevo género en la base de datos.
        /// </summary>
        /// <param name="pgeneroEN"></param>
        /// <returns></returns>
        public int GuardarGenero(GeneroEN pgeneroEN)
        {
            return GeneroDAL.GuardarGenero(pgeneroEN);
        }

        /// <summary>
        /// Elimina un género existente según su ID.
        /// </summary>
        /// <param name="pgeneroEN"></param>
        /// <returns></returns>
        public int EliminarGenero(GeneroEN pgeneroEN)
        {
            return GeneroDAL.EliminarGenero(pgeneroEN);
        }

        /// <summary>
        /// Modifica los datos de un género existente.
        /// </summary>
        /// <param name="pgeneroEN"></param>
        /// <returns></returns>
        public int ModificarGenero(GeneroEN pgeneroEN)
        {
            return GeneroDAL.ModificarGenero(pgeneroEN);
        }
    }
}
