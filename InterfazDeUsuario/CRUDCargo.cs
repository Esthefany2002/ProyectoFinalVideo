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
    /// Formulario CRUD para la gestión de cargos.
    /// Permite mostrar, agregar, modificar y eliminar cargos desde la interfaz gráfica.
    /// </summary>
    public partial class CRUDCargo: Form
    {
        CargoBL _cargoBL = new CargoBL();
        CargoEN _cargoEN = new CargoEN();

        /// <summary>
        /// Constructor del formulario CRUDCargo.
        /// Inicializa componentes, oculta el textbox de ID y carga los datos en el grid.
        /// </summary>
        public CRUDCargo()
        {
            InitializeComponent();
            txtId.Visible = false;
            CargarGrid();
        }

        /// <summary>
        /// Carga todos los cargos desde la base de datos y los muestra en el DataGridView.
        /// </summary>
        public void CargarGrid()
        {
            dgvMostrarCargo.DataSource = _cargoBL.MostrarCargo();
        }
        private bool EsSoloLetras(string texto)
        {
            return texto.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool EsByteValido(string texto)
        {
            return byte.TryParse(texto, out _);
        }

        private void CRUDCargo_Load(object sender, EventArgs e)
        {

        }

        private void dgvMostrarCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvMostrarCargo.SelectedRows.Count > 0)
            {
                txtCargo.Text = dgvMostrarCargo.CurrentRow.Cells["Nombre"].Value.ToString();
                txtId.Text = dgvMostrarCargo.CurrentRow.Cells["Id"].Value.ToString();
            }

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento del botón Guardar. Guarda un nuevo cargo con los datos ingresados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtCargo.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo 'Cargo' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!EsSoloLetras(nombre))
            {
                MessageBox.Show("El campo 'Cargo' solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _cargoEN.Nombre = nombre;
            _cargoBL.GuardarCargo(_cargoEN);
            CargarGrid();
            txtCargo.Clear();

        }

        /// <summary>
        /// Evento del botón Modificar. Actualiza un cargo existente seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {


            string nombre = txtCargo.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El campo 'Cargo' no puede estar vacío o solo contener espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsSoloLetras(nombre))
            {
                MessageBox.Show("El campo 'Cargo' solo debe contener letras y espacios entre palabras (sin números ni símbolos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _cargoEN.Id = Convert.ToByte(txtId.Text);
            _cargoEN.Nombre = txtCargo.Text;
            _cargoBL.ModificarCargo(_cargoEN);
            txtCargo.Clear();
            txtId.Clear();
            CargarGrid();
        }

        /// <summary>
        /// Evento del botón Eliminar. Elimina un cargo seleccionado mediante su Id.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (!EsByteValido(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un cargo válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _cargoEN.Id = Convert.ToByte(txtId.Text);
            _cargoEN.Nombre = txtCargo.Text;
            _cargoBL.EliminarCargo(_cargoEN);
            txtCargo.Clear();
            txtId.Clear();
            CargarGrid();
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
    
}
