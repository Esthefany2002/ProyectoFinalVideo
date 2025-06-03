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
    /// Formulario CRUD para la gestión de empleados.
    /// Permite mostrar, agregar, modificar y eliminar empleados a través de la interfaz.
    /// </summary>
    public partial class CRUDEmpleado: Form
    {
        EmpleadoBL _empleadoBL = new EmpleadoBL();
        EmpleadoEN _empleadoEN = new EmpleadoEN();

        /// <summary>
        /// Constructor del formulario CRUDEmpleado.
        /// Inicializa los componentes, oculta el campo ID y carga la lista de empleados en el grid.
        /// </summary>
        public CRUDEmpleado()
        {
            InitializeComponent();
            txtId.Visible = false;
            CargarGrid();
        }

        /// <summary>
        /// Carga la lista de empleados desde la base de datos y los muestra en el DataGridView.
        /// </summary>
        public void CargarGrid()
        {
            dgvMostrarEmpleado.DataSource = _empleadoBL.MostrarEmpleado();
        }

        /// <summary>
        /// Valida si el texto contiene solo letras y espacios.
        /// </summary>
        private bool EsSoloLetras(string texto)
        {
            return texto.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        /// <summary>
        /// Valida si el texto se puede convertir a un entero (por ejemplo, IdCargo o Id).
        /// </summary>
        private bool EsEnteroValido(string texto)
        {
            return int.TryParse(texto, out _);
        }

        /// <summary>
        /// Valida si el número de celular contiene solo dígitos y al menos 8 caracteres.
        /// </summary>
        private bool EsCelularValido(string numero)
        {
            return numero.All(char.IsDigit) && numero.Length >= 8;
        }

        /// <summary>
        /// Valida si el correo electrónico tiene un formato válido básico.
        /// </summary>
        private bool EsCorreoValido(string correo)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(
                correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
            );
        }

        /// <summary>
        /// Valida si el texto no está vacío o solo contiene espacios.
        /// </summary>
        private bool EsTextoNoVacio(string texto)
        {
            return !string.IsNullOrWhiteSpace(texto);
        }


        /// <summary>
        /// Evento del botón Guardar. Registra un nuevo empleado con los datos ingresados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!EsEnteroValido(txtIdCargo.Text))
            {
                MessageBox.Show("El campo 'IdCargo' debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!EsCelularValido(txtCelular.Text))
            {
                MessageBox.Show("El campo 'Número de Celular' debe contener solo números y tener al menos 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!EsCorreoValido(txtCorreoElectronico.Text))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!EsSoloLetras(txtNombre.Text) || !EsSoloLetras(txtApellido.Text))

            {
                MessageBox.Show("Los campos 'Nombre' y 'Apellido' no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _empleadoEN.IdCargo = Convert.ToInt32(txtIdCargo.Text);
            _empleadoEN.Celular = txtCelular.Text;
            _empleadoEN.CorreoElectronico = txtCorreoElectronico.Text;
            _empleadoEN.Nombre = txtNombre.Text;
            _empleadoEN.Apellido = txtApellido.Text;
            _empleadoEN.Direccion = txtDireccion.Text;
            _empleadoBL.GuardarEmpleado(_empleadoEN);
            //Limpia todos los campos de entrada del formulario.
            CargarGrid();
            txtIdCargo.Clear();
            txtCelular.Clear();
            txtCorreoElectronico.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
        }


        /// <summary>
        /// Evento del botón Modificar. Actualiza un empleado existente con los datos ingresados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (!EsEnteroValido(txtIdCargo.Text))
            {
                MessageBox.Show("El campo 'IdCargo' debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
      
            if (!EsCelularValido(txtCelular.Text))
            {
                MessageBox.Show("El campo 'Número de Celular' debe contener solo números y tener al menos 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!EsCorreoValido(txtCorreoElectronico.Text))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!EsSoloLetras(txtNombre.Text) || !EsSoloLetras(txtApellido.Text))

            {
                MessageBox.Show("Los campos 'Nombre' y 'Apellido' no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _empleadoEN.IdCargo = Convert.ToInt32(txtIdCargo.Text);
            _empleadoEN.Celular = txtCelular.Text;
            _empleadoEN.CorreoElectronico = txtCorreoElectronico.Text;
            _empleadoEN.Nombre = txtNombre.Text;
            _empleadoEN.Apellido = txtApellido.Text;
            _empleadoEN.Direccion = txtDireccion.Text;
            _empleadoBL.ModificarEmpleado(_empleadoEN);
            CargarGrid();
            txtIdCargo.Clear();
            txtCelular.Clear();
            txtCorreoElectronico.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
        }


        /// <summary>
        /// Evento del botón Eliminar. Borra un empleado seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (!EsEnteroValido(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un empleado válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _empleadoEN.IdCargo = Convert.ToInt32(txtIdCargo.Text);
            _empleadoEN.Celular = txtCelular.Text;
            _empleadoEN.CorreoElectronico = txtCorreoElectronico.Text;
            _empleadoEN.Nombre = txtNombre.Text;
            _empleadoEN.Apellido = txtApellido.Text;
            _empleadoEN.Direccion = txtDireccion.Text;
            _empleadoBL.EliminarEmpleado(_empleadoEN);
            CargarGrid();
            txtIdCargo.Clear();
            txtCelular.Clear();
            txtCorreoElectronico.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
        }


        /// <summary>
        /// Evento al hacer click en una fila del DataGridView.
        /// Carga los datos del empleado seleccionado en los campos de texto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMostrarEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMostrarEmpleado.SelectedRows.Count > 0)
            {
                 txtId.Text = dgvMostrarEmpleado.CurrentRow.Cells["Id"].Value.ToString();
                txtIdCargo.Text = dgvMostrarEmpleado.CurrentRow.Cells["IdCargo"].Value.ToString();
                txtCelular.Text = dgvMostrarEmpleado.CurrentRow.Cells["Celular"].Value.ToString();
                txtCorreoElectronico.Text = dgvMostrarEmpleado.CurrentRow.Cells["CorreoElectronico"].Value.ToString();
                txtNombre.Text = dgvMostrarEmpleado.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvMostrarEmpleado.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDireccion.Text = dgvMostrarEmpleado.CurrentRow.Cells["Direccion"].Value.ToString();

            }
        }


        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
