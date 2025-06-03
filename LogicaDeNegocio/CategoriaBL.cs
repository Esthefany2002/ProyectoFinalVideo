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
    /// Clase de la capa de lógica de negocio para gestionar operaciones de la entidad Categoría.
    /// Conecta la lógica de presentación con el acceso a datos.
    /// </summary>
    public class CategoriaBL
   {
        /// <summary>
        /// Trae todas las categorías desde la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<CategoriaEN> MostrarCategoria()
        {
            return CategoriaDAL.MostrarCategoria();
        }

        /// <summary>
        /// Guarda una nueva categoría en la base de datos.
        /// </summary>
        /// <param name="pcategoriaEN"></param>
        /// <returns></returns>
        public int GuardarCategoria(CategoriaEN pcategoriaEN)
        {
            return CategoriaDAL.GuardarCategoria(pcategoriaEN);
        }

        /// <summary>
        /// Elimina una categoría existente según su ID.
        /// </summary>
        /// <param name="pcategoriaEN"></param>
        /// <returns></returns>
        public int EliminarCategoria(CategoriaEN pcategoriaEN)
        {
            return CategoriaDAL.EliminarCategoria(pcategoriaEN);
        }

        /// <summary>
        /// Modifica los datos de una categoría existente.
        /// </summary>
        /// <param name="pcategoriaEN"></param>
        /// <returns></returns>
        public int ModificarCategoria(CategoriaEN pcategoriaEN)
        {
            return CategoriaDAL.ModificarCategoria(pcategoriaEN);
        }
    }
}
