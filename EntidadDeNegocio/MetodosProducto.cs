using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeNegocio
{
    public abstract class MetodosCategoria
    {
        public abstract List<CategoriaEN> MostrarCategoria();

        public abstract int GuardarCategoria(CategoriaEN pCategoriaEN);

        public abstract int EliminarCategoria(CategoriaEN pCategoriaEN);

        public abstract int ModificarCategoria(CategoriaEN pCategoriaEN);
    }

    public abstract class MetodosGenero
    {
        public abstract List<GeneroEN> MostrarGenero();

        public abstract int GuardarGenero(GeneroEN pGeneroEN);

        public abstract int EliminarGenero(GeneroEN pGeneroEN);

        public abstract int ModificarGenero(GeneroEN pGeneroEN);
    }

    public abstract class MetodosPlataforma
    {
        public abstract List<PlataformaEN> MostrarPlataforma();

        public abstract int GuardarPlataforma(PlataformaEN pPlataformaEN);

        public abstract int EliminarPlataforma(PlataformaEN pPlataformaEN);

        public abstract int ModificarPlataforma(PlataformaEN pPlataformaEN);
    }

    public abstract class MetodosVideoJuegos
    {
        public abstract List<VideoJuegosEN> MostrarVideoJuegos();

        public abstract int GuardarVideoJuegos(VideoJuegosEN pVideoJuegosEN);

        public abstract int EliminarVideoJuegos(VideoJuegosEN pVideoJuegosEN);

        public abstract int ModificarVideoJuegos(VideoJuegosEN pVideoJuegosEN);
    }
}
