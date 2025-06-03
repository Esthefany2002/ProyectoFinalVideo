using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeNegocio
{
    public abstract class MetodosEstadoVenta
    {
        public abstract List<EstadoVentaEN> MostrarEstadoVenta();

        public abstract int ModificarEstadoVenta(EstadoVentaEN pEstadoVentaEN);

        public abstract int EliminarEstadoVenta(EstadoVentaEN pEstadoVentaEN);

        public abstract int GuardarEstadoVenta(EstadoVentaEN pEstadoVentaEN);
    }

    public abstract class MetodosInventario
    {
        public abstract List<InventarioEN> MostrarInventario();

        public abstract int ModificarInventario(InventarioEN pInventarioEN);

        public abstract int EliminarInventario(InventarioEN pInventarioEN);

        public abstract int GuardarInventario(InventarioEN pInventarioEN);
    }
}
