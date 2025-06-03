using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDeUsuario
{

    /// <summary>
    /// Formulario principal que sirve como menú de inicio para los empleados.
    /// Desde aquí se puede acceder a diferentes formularios de administración y registro  en este caso el empleado solo puede 
    /// entrar al fromulario de CRUDEstadoVenta y solo ese CRUD puede modificar.
    /// </summary>
    public partial class InicioEmpleado: Form
    {


        /// <summary>
        /// Constructor que inicializa el formulario de inicio del empleado.
        /// </summary>
        public InicioEmpleado()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Evento que se dispara al hacer clic en la opción "registro" del menú.
        /// Abre el formulario CRUDEstadoVenta.
        /// </summary>
        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDEstadoVenta cRUDEstadoVenta = new CRUDEstadoVenta();
            cRUDEstadoVenta.ShowDialog();
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario de login nuevamente
            Login login = new Login();
            login.Show();

            // Cerrar el formulario actual 
            this.Close();
        }
    }
}
