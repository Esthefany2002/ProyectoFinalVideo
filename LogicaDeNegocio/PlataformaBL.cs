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
    /// Clase de la capa de lógica de negocio para gestionar operaciones de la entidad Plataforma.
    /// Conecta la lógica de presentación con el acceso a datos.
    /// </summary>
    public class PlataformaBL
    {

        /// <summary>
        /// Recupera todas las plataformas desde la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<PlataformaEN> MostrarPlataforma()
        {
            return PlataformaDAL.MostrarPlataforma();
        }

        /// <summary>
        /// Guarda una nueva plataforma en la base de datos.
        /// </summary>
        /// <param name="pplataformaEN"></param>
        /// <returns></returns>
        public int GuardarPlataforma(PlataformaEN pplataformaEN)
        {
            return PlataformaDAL.GuardarPlataforma(pplataformaEN);
        }

        /// <summary>
        /// Elimina una plataforma existente según su ID.
        /// </summary>
        /// <param name="pplataformaEN"></param>
        /// <returns></returns>
        public int EliminarPlataforma(PlataformaEN pplataformaEN)
        {
            return PlataformaDAL.EliminarPlataforma(pplataformaEN);
        }

        /// <summary>
        /// Modifica los datos de una plataforma existente.
        /// </summary>
        /// <param name="pplataformaEN"></param>
        /// <returns></returns>
        public int ModificarPlataforma(PlataformaEN pplataformaEN)
        {
            return PlataformaDAL.ModificarPlataforma(pplataformaEN);
        }
    }
}
