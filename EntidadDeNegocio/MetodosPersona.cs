using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeNegocio

{
    public abstract class MetodosCargo
    {
        public abstract List<CargoEN> MostrarCargo();

        public abstract int ModificarCargo(CargoEN pCargoEN);

        public abstract int EliminarCargo(CargoEN pCargoEN);

        public abstract int GuardarCargo(CargoEN pCargoEN);

    }

    public abstract class MetodosEmpleado
    {
        public abstract List<EmpleadoEN> MostrarEmpleado();

        public abstract int ModificarEmpleado(EmpleadoEN pEmpleadoEN);

        public abstract int EliminarEmpleado(EmpleadoEN pEmpleadoEN);

        public abstract int GuardarEmpleado(EmpleadoEN pEmpleadoEN);

    }

    public abstract class MetodosUsiario
    {
        public abstract int VerificarUsuarioLogin(UsuarioEN pUsuarioEN);

        public abstract List<UsuarioEN> MostrarUsuario(UsuarioEN pUsuarioEN);

        public abstract int GuardarUsuario(UsuarioEN pUsuarioEN);

        public abstract int ModificarUsuario(UsuarioEN pUsuarioEN);

        public abstract int EliminarUsuario(UsuarioEN pUsuarioEN);
    }

    public abstract class MetodosProveedor
    {
        public abstract List<ProveedorEN> MostrarProveedor();

        public abstract int GuardarProveedor(ProveedorEN pProveedorEN);

        public abstract int EliminarProveedor(ProveedorEN pProveedorEN);
        
        public abstract int ModificarProveedor(ProveedorEN pProveedorEN);
    }
}
