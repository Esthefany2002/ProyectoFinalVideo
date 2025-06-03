using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------------------
using EntidadDeNegocio;
using LogicaDeNegocio;
//--------------------------

namespace InterfazDeUsuario
{

    /// <summary>
    /// Formulario CRUD para administrar los Estados de Venta.
    /// Permite mostrar, agregar, modificar y eliminar registros.
    /// </summary>
    public partial class CRUDEstadoVenta: Form
    {
        EstadoVentaBL _estadoventaBL = new EstadoVentaBL();
        EstadoVentaEN _estadoventaEN = new EstadoVentaEN();

        /// <summary>
        /// Constructor del formulario CRUDEstadoVenta.
        /// Inicializa los componentes, oculta el campo ID y carga la lista de EstadoVenta en el grid.
        /// </summary>
        public CRUDEstadoVenta()
        {
            InitializeComponent();
            txtId.Visible = false;
            CargarGrid();
        }

        /// <summary>
        /// Carga los datos desde la base de datos y los muestra en el DataGridView.
        /// </summary>
        public void CargarGrid()
        {
            dgvMostrarEstadoVenta.DataSource = _estadoventaBL.MostrarEstadoVenta();
        }
        /// <summary>
        /// Verifica si el texto contiene solo letras y espacios.
        /// </summary>
        private bool EsTextoValido(string texto)
        {
            return texto.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        /// <summary>
        /// Verifica si el texto puede convertirse en entero válido.
        /// </summary>
        private bool EsEnteroValido(string texto)
        {
            return int.TryParse(texto, out _);
        }


        /// <summary>
        /// Evento al hacer click en una fila del DataGridView.
        /// Carga los datos seleccionados en los campos para editar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dgvMostrarEstadoVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMostrarEstadoVenta.SelectedRows.Count > 0)
            {
                txtNombre.Text = dgvMostrarEstadoVenta.CurrentRow.Cells["Nombre"].Value.ToString();
                txtId.Text = dgvMostrarEstadoVenta.CurrentRow.Cells["Id"].Value.ToString();
            }
        }

        /// <summary>
        /// Evento para guardar un nuevo Estado de Venta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo 'Nombre' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsTextoValido(nombre))
            {
                MessageBox.Show("El campo 'Nombre' solo debe contener letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _estadoventaEN.Nombre = txtNombre.Text;
            _estadoventaBL.GuardarEstadoVenta(_estadoventaEN);
            CargarGrid();
            txtNombre.Clear();
        }


        /// <summary>
        /// Evento para modificar un Estado de Venta existente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtModificar_Click(object sender, EventArgs e)
        {

            if (!EsEnteroValido(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un Estado de Venta válido para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || !EsTextoValido(nombre))
            {
                MessageBox.Show("Ingrese un nombre válido (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _estadoventaEN.Id = Convert.ToInt32(txtId.Text);
            _estadoventaEN.Nombre = txtNombre.Text;
            _estadoventaBL.ModificarEstadoVenta(_estadoventaEN);
            txtNombre.Clear();
            txtId.Clear();
            CargarGrid();
        }


        /// <summary>
        /// Evento para eliminar un Estado de Venta seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (!EsEnteroValido(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un Estado de Venta válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _estadoventaEN.Id = Convert.ToInt32(txtId.Text);
            _estadoventaEN.Nombre = txtNombre.Text;
            _estadoventaBL.EliminarEstadoVenta(_estadoventaEN);
            txtNombre.Clear();
            txtId.Clear();
            CargarGrid();
        }
    }
}
