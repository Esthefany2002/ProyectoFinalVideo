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
    /// Clase de la capa de lógica de negocio para gestionar operaciones de la entidad VideoJuegos.
    /// Conecta la lógica de presentación con el acceso a datos.
    /// </summary>
    public class VideoJuegosBL
    {
        /// <summary>
        /// Obtiene la lista completa de videojuegos desde la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<VideoJuegosEN> MostrarVideoJuegos()
        {
            return VideoJuegosDAL.MostrarVideoJuegos();
        }

        /// <summary>
        /// Guarda un nuevo videojuego en la base de datos.
        /// </summary>
        /// <param name="pvideojuegosEN"></param>
        /// <returns></returns>
        public int GuardarVideoJuegos(VideoJuegosEN pvideojuegosEN)
        {
            return VideoJuegosDAL.GuardarVideoJuegos(pvideojuegosEN);
        }

        /// <summary>
        /// Elimina un videojuego existente según su ID.
        /// </summary>
        /// <param name="pvideojuegosEN"></param>
        /// <returns></returns>
        public int EliminarVideoJuegos(VideoJuegosEN pvideojuegosEN)
        {
            return VideoJuegosDAL.EliminarVideoJuegos(pvideojuegosEN);
        }

        /// <summary>
        /// Modifica los datos de un videojuego existente.
        /// </summary>
        /// <param name="pvideojuegosEN"></param>
        /// <returns></returns>
        public int ModificarVideoJuegos(VideoJuegosEN pvideojuegosEN)
        {
            return VideoJuegosDAL.ModificarVideoJuegos(pvideojuegosEN);
        }
    }
}
