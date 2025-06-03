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
    /// Formulario para realizar operaciones CRUD sobre la entidad Proveedor.
    /// Permite mostrar, agregar, modificar y eliminar registros de Proveedor.
    /// </summary>
    public partial class CRUDProveedor: Form
    {
        ProveedorBL _proveedorBL = new ProveedorBL();
        ProveedorEN _proveedorEN = new ProveedorEN();

        /// <summary>
        /// Constructor del formulario CRUDProveedor.
        /// Inicializa los componentes, oculta el campo ID y carga la lista de proveedor en el grid.
        /// </summary>
        public CRUDProveedor()
        {
            InitializeComponent();
            txtId.Visible = false;
            CargarGrid();
        }


        /// <summary>
        /// Carga los datos de los proveedores en el DataGridView.
        /// </summary>
        public void CargarGrid()
        {
            dgvMostrarProveedor.DataSource = _proveedorBL.MostrarProveedor();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumerodeCel.Text) || txtNumerodeCel.Text.Length < 8 || !txtNumerodeCel.Text.All(char.IsDigit))
            {
                MessageBox.Show("Ingrese un número de celular válido (mínimo 8 dígitos numéricos).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) || !txtCorreoElectronico.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("El campo Dirección es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }



        /// <summary>
        /// Evento que se ejecuta al seleccionar una fila del DataGridView.
        /// Llena los campos del formulario con los datos del proveedor seleccionado.
        /// </summary>
        private void dgvMostrarProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMostrarProveedor.SelectedRows.Count > 0)
            {
                txtNombre.Text = dgvMostrarProveedor.CurrentRow.Cells["Nombre"].Value.ToString();
                txtId.Text = dgvMostrarProveedor.CurrentRow.Cells["Id"].Value.ToString();
                txtApellido.Text = dgvMostrarProveedor.CurrentRow.Cells["Apellido"].Value.ToString();
                txtNumerodeCel.Text = dgvMostrarProveedor.CurrentRow.Cells["NumerodeCel"].Value.ToString();
                txtCorreoElectronico.Text = dgvMostrarProveedor.CurrentRow.Cells["CorreoElectronico"].Value.ToString();
                txtDireccion.Text = dgvMostrarProveedor.CurrentRow.Cells["Direccion"].Value.ToString();
            }
        }


        /// <summary>
        /// Evento del botón Guardar. Registra un nuevo proveedor en la base de datos.
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!ValidarCampos()) return;

            _proveedorEN.Nombre = txtNombre.Text;
            _proveedorEN.Apellido = txtApellido.Text;
            _proveedorEN.NumerodeCel = txtNumerodeCel.Text;
            _proveedorEN.CorreoElectronico = txtCorreoElectronico.Text;
            _proveedorEN.Direccion = txtDireccion.Text;
            _proveedorBL.GuardarProveedor(_proveedorEN);
            CargarGrid();
            txtNombre.Clear();
            txtApellido.Clear();
            txtNumerodeCel.Clear();
            txtCorreoElectronico.Clear();
            txtDireccion.Clear();
        }



        /// <summary>
        /// Evento del botón Modificar. Actualiza los datos de un proveedor existente.
        /// </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (!ValidarCampos()) return;

            _proveedorEN.Id = Convert.ToByte(txtId.Text);
            _proveedorEN.Nombre = txtNombre.Text;
            _proveedorEN.Apellido = txtApellido.Text;
            _proveedorEN.NumerodeCel = txtNumerodeCel.Text;
            _proveedorEN.CorreoElectronico = txtCorreoElectronico.Text;
            _proveedorEN.Direccion = txtDireccion.Text;
            _proveedorBL.ModificarProveedor(_proveedorEN);
            txtNombre.Clear();
            txtId.Clear();
            txtApellido.Clear();
            txtNumerodeCel.Clear();
            txtCorreoElectronico.Clear();
            txtDireccion.Clear();
            CargarGrid();
        }

        /// <summary>
        /// Evento del botón Eliminar. Elimina un proveedor de la base de datos.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _proveedorEN.Id = Convert.ToInt32(txtId.Text);
            _proveedorEN.Nombre = txtNombre.Text;
            _proveedorEN.Apellido = txtApellido.Text;
            _proveedorEN.NumerodeCel = txtNumerodeCel.Text;
            _proveedorEN.CorreoElectronico = txtCorreoElectronico.Text;
            _proveedorEN.Direccion = txtDireccion.Text;
            _proveedorBL.EliminarProveedor(_proveedorEN);
            txtNombre.Clear();
            txtId.Clear();
            txtApellido.Clear();
            txtNumerodeCel.Clear();
            txtCorreoElectronico.Clear();
            txtDireccion.Clear();
            CargarGrid();
        }

       
    }
}
