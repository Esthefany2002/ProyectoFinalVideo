using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------------------------
using EntidadDeNegocio;
using LogicaDeNegocio;
//-------------------------
namespace InterfazDeUsuario
{

    /// <summary>
    /// Formulario que gestiona el inicio de sesión del sistema.
    /// Permite ingresar como "Empleado" o "Gerente" validando usuario, clave y cargo.
    /// </summary>
    public partial class Login: Form
    {

        /// <summary>
        /// Constructor principal del formulario de login.
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }
        // Entidad y lógica de negocio para manipulación de usuarios
        UsuarioEN pusuarioEN = new UsuarioEN();
        UsuarioBL pusuarioBL = new UsuarioBL();
        List<UsuarioEN> lisc = new List<UsuarioEN>();


        /// <summary>
        /// Evento que se ejecuta al presionar el botón "Ingresar".
        /// Verifica si las credenciales ingresadas son válidas y redirige según el cargo.
        /// </summary>
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text != "" && txtClave.Text != "" && cbCargo.Text != "")
            {
                pusuarioEN.Nombre = txtNombre.Text;
                pusuarioEN.Clave = txtClave.Text;
                pusuarioEN.Cargo = cbCargo.Text;
                var eNs = pusuarioBL.VerificarUsuarioLogin(pusuarioEN);
                if (eNs == 1)
                {
                    if (pusuarioEN.Cargo == "Empleado")
                    {
                        InicioEmpleado inicioE = new InicioEmpleado();
                        inicioE.Show();
                        this.Hide();
                    }
                    else if (pusuarioEN.Cargo == "Gerente")
                    {
                        lisc = pusuarioBL.MostrarUsuario(pusuarioEN);
                        Menu inicioD = new Menu(pusuarioEN.Nombre, pusuarioEN.Cargo);
                        inicioD.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("datos vacios");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
    
}
