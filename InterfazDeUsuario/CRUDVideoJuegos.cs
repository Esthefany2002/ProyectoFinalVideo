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
    /// Formulario para realizar operaciones CRUD sobre la entidad VideoJuegos.
    /// Permite mostrar, agregar, modificar y eliminar registros de VideoJuegos.
    /// </summary>
    public partial class CRUDVideoJuegos: Form
    {
        VideoJuegosBL _videojuegosBL = new VideoJuegosBL();
        VideoJuegosEN _videojuegosEN = new VideoJuegosEN();

        /// <summary>
        /// Constructor del formulario CRUDVideoJuegos.
        /// Inicializa los componentes, oculta el campo ID y carga la lista de VideoJuegos en el grid.
        /// </summary>
        public CRUDVideoJuegos()
        {
            InitializeComponent();
            txtId.Visible = false;
            CargarGrid();
        }

        /// <summary>
        /// Carga los videojuegos desde la base de datos al DataGridView.
        /// </summary>
        public void CargarGrid()
        {
            dgvMostrarVideoJuegos.DataSource = _videojuegosBL.MostrarVideoJuegos();
        }





       
        private void dgvMostrarVideoJuegos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del videojuego es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtIdCategoria.Text, out int idCategoria))
            {
                MessageBox.Show("El Id de Categoría debe ser un número entero válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtIdPlataforma.Text, out int idPlataforma))
            {
                MessageBox.Show("El Id de Plataforma debe ser un número entero válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtIdGenero.Text, out int idGenero))
            {
                MessageBox.Show("El Id de Género debe ser un número entero válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtIdProveedor.Text, out int idProveedor))
            {
                MessageBox.Show("El Id de Proveedor debe ser un número entero válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecioUnitario.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("El Precio Unitario debe ser un número decimal válido y mayor o igual a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMostrarVideoJuegos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento que se ejecuta al seleccionar una fila del DataGridView.
        /// Llena los campos del formulario con los datos del videojuego seleccionado.
        /// </summary>

        private void dgvMostrarVideoJuegos_CellCClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMostrarVideoJuegos.SelectedRows.Count > 0)
            {
                txtNombre.Text = dgvMostrarVideoJuegos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtId.Text = dgvMostrarVideoJuegos.CurrentRow.Cells["Id"].Value.ToString();
                txtIdCategoria.Text = dgvMostrarVideoJuegos.CurrentRow.Cells["IdCategoria"].Value.ToString();
                txtIdGenero.Text = dgvMostrarVideoJuegos.CurrentRow.Cells["IdGenero"].Value.ToString();
                txtIdPlataforma.Text = dgvMostrarVideoJuegos.CurrentRow.Cells["IdPlataforma"].Value.ToString();
                txtIdProveedor.Text = dgvMostrarVideoJuegos.CurrentRow.Cells["IdProveedor"].Value.ToString();
                txtPrecioUnitario.Text = dgvMostrarVideoJuegos.CurrentRow.Cells["PrecioUnitario"].Value.ToString();
            }
        }


        /// <summary>
        /// Evento del botón Guardar. Registra un nuevo videojuego en la base de datos.
        /// </summary>
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {


            if (!ValidarCampos()) return;
            _videojuegosEN.Nombre = txtNombre.Text;
            _videojuegosEN.IdCategoria = Convert.ToInt32(txtIdCategoria.Text);
            _videojuegosEN.IdPlataforma = Convert.ToInt32(txtIdPlataforma.Text);
            _videojuegosEN.IdGenero = Convert.ToInt32(txtIdGenero.Text);
            _videojuegosEN.IdProveedor = Convert.ToInt32(txtIdProveedor.Text);
            _videojuegosEN.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);

            _videojuegosBL.GuardarVideoJuegos(_videojuegosEN);
            CargarGrid();
            //Limpiar campos
            txtNombre.Clear();
            txtIdCategoria.Clear();
            txtIdPlataforma.Clear();
            txtIdGenero.Clear();
            txtIdProveedor.Clear();
            txtPrecioUnitario.Clear();

        }


        /// <summary>
        /// Evento del botón Eliminar. Elimina un videojuego de la base de datos.
        /// </summary>
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            
  
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Seleccione un videojuego para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _videojuegosEN.Id = Convert.ToInt32(txtId.Text);
            _videojuegosEN.Nombre = txtNombre.Text;
            _videojuegosEN.IdCategoria = Convert.ToInt32(txtIdCategoria.Text);
            _videojuegosEN.IdPlataforma = Convert.ToInt32(txtIdPlataforma.Text);
            _videojuegosEN.IdGenero = Convert.ToInt32(txtIdGenero.Text);
            _videojuegosEN.IdProveedor = Convert.ToInt32(txtIdProveedor.Text);
            _videojuegosEN.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);

            _videojuegosBL.EliminarVideoJuegos(_videojuegosEN);
            CargarGrid();
            txtId.Clear();
            txtNombre.Clear();
            txtIdCategoria.Clear();
            txtIdPlataforma.Clear();
            txtIdGenero.Clear();
            txtIdProveedor.Clear();
            txtPrecioUnitario.Clear();
        }


        /// <summary>
        /// Evento del botón Modificar. Actualiza los datos de un videojuego existente.
        /// </summary>
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            
      
        

            if (!ValidarCampos()) return;
            _videojuegosEN.Id = Convert.ToInt32(txtId.Text);
            _videojuegosEN.Nombre = txtNombre.Text;
            _videojuegosEN.IdCategoria = Convert.ToInt32(txtIdCategoria.Text);
            _videojuegosEN.IdPlataforma = Convert.ToInt32(txtIdPlataforma.Text);
            _videojuegosEN.IdGenero = Convert.ToInt32(txtIdGenero.Text);
            _videojuegosEN.IdProveedor = Convert.ToInt32(txtIdProveedor.Text);
            _videojuegosEN.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);

            _videojuegosBL.ModificarVideoJuegos(_videojuegosEN);
            CargarGrid();
            txtId.Clear();
            txtNombre.Clear();
            txtIdCategoria.Clear();
            txtIdPlataforma.Clear();
            txtIdGenero.Clear();
            txtIdProveedor.Clear();
            txtPrecioUnitario.Clear();
        }
    }
    
    
    
}
