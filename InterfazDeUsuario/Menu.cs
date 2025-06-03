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
    /// Formulario principal de menú para el usuario Gerente.
    /// Proporciona acceso a los formularios CRUD de todas las entidades.
    /// </summary>
    public partial class Menu : Form
    {

        /// <summary>
        /// Constructor del formulario que recibe nombre y cargo del usuario para mostrarlo en pantalla.
        /// </summary>
        /// <param name="nombreUsuario">Nombre del usuario que inició sesión.</param>
        /// <param name="cargo">Cargo del usuario (Gerente).</param>
        public Menu(string nombreUsuario, string cargo)
        {
            InitializeComponent();
            lblMenu.Text = $"Bienvenido, {nombreUsuario} ({cargo})";
        }


        // Abre CRUD de Genero
        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDGenero cRUDGenero = new CRUDGenero();
            cRUDGenero.ShowDialog();
        }


        // Abre CRUD de Plataforma
        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CRUDPlataforma cRUDPlataforma = new CRUDPlataforma();
            cRUDPlataforma.ShowDialog();
        }


        // Abre CRUD de Categoria
        private void registroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CRUDCategoria cRUDCategoria = new CRUDCategoria();
            cRUDCategoria.ShowDialog();
        }


        // Abre CRUD de Proveedor
        private void registroToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CRUDProveedor cRUDProveedor = new CRUDProveedor();
            cRUDProveedor.ShowDialog();
        }


        // Abre CRUD de VideoJuegos
        private void registroToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CRUDVideoJuegos cRUDVideoJuegos = new CRUDVideoJuegos();
            cRUDVideoJuegos.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }


        // Abre CRUD de Empleado
        private void registroToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            CRUDEmpleado cRUDEmpleado = new CRUDEmpleado();
            cRUDEmpleado.ShowDialog();
        }


        // Abre CRUD de Inventario
        private void registroToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            CRUDInventario cRUDInventario = new CRUDInventario();
            cRUDInventario.ShowDialog();
        }


        // Abre CRUD de Cargo
        private void registroToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            CRUDCargo cRUDCargo = new CRUDCargo();
            cRUDCargo.ShowDialog();
        }


        // Abre CRUD de EstadoVenta
        private void registroToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            CRUDEstadoVenta cRUDEstadoVenta = new CRUDEstadoVenta();
            cRUDEstadoVenta.ShowDialog();
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

