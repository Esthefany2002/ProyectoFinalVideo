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
    /// Formulario para realizar operaciones CRUD sobre la entidad Plataforma.
    /// Permite mostrar, agregar, modificar y eliminar registros de Plataforma.
    /// </summary>
    public partial class CRUDPlataforma: Form
    {
        PlataformaBL _plataformaBL = new PlataformaBL();
        PlataformaEN _plataformaEN = new PlataformaEN();

        /// <summary>
        /// Constructor del formulario CRUDPlataforma.
        /// Inicializa los componentes, oculta el campo ID y carga la lista de Plataforma en el grid.
        /// </summary>
        public CRUDPlataforma()
        {
            InitializeComponent();
            txtId.Visible = false;
            CargarGrid();
        }

        /// <summary>
        /// Carga los datos de las plataformas y los muestra en el DataGridView.
        /// </summary>
        public void CargarGrid()
        {
            dgvMostrarPlataforma.DataSource = _plataformaBL.MostrarPlataforma();
        }


        private bool EsSoloLetras(string texto)
        {
            return texto.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool EsByteValido(string texto)
        {
            return byte.TryParse(texto, out _);
        }


        /// <summary>
        /// Evento que se dispara al seleccionar una celda del DataGridView.
        /// Llena los campos del formulario con los datos de la plataforma seleccionada.
        /// </summary>

        private void dgvMostrarPlataforma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMostrarPlataforma.SelectedRows.Count > 0)
            {
                txtNombre.Text = dgvMostrarPlataforma.CurrentRow.Cells["Nombre"].Value.ToString();
                txtId.Text = dgvMostrarPlataforma.CurrentRow.Cells["Id"].Value.ToString();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Evento del botón Guardar. Registra una nueva plataforma en la base de datos.
        /// </summary>
        private void btnGuardar_Click_1(object sender, EventArgs e)
        
      
        {
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo 'Plataforma' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!EsSoloLetras(nombre))
            {
                MessageBox.Show("El campo 'Plataforma' solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _plataformaEN.Nombre = nombre;
            _plataformaBL.GuardarPlataforma(_plataformaEN);
            CargarGrid();
            txtNombre.Clear();
        }
        /// <summary>
        /// Evento del botón Modificar. Actualiza los datos de una plataforma existente.
        /// </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
   
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo 'Plataforma' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!EsSoloLetras(nombre))
            {
                MessageBox.Show("El campo 'Plataforma' solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _plataformaEN.Id = Convert.ToInt32(txtId.Text);
            _plataformaEN.Nombre = txtNombre.Text;
            _plataformaBL.ModificarPlataforma(_plataformaEN);
            txtNombre.Clear();
            txtId.Clear();
            CargarGrid();
        }


        /// <summary>
        /// Evento del botón Eliminar. Elimina una plataforma de la base de datos.
        /// </summary>
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
      
        

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Seleccione una plataforma para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _plataformaEN.Id = Convert.ToInt32(txtId.Text);
            _plataformaEN.Nombre = txtNombre.Text;
            _plataformaBL.EliminarPlataforma(_plataformaEN);
            txtNombre.Clear();
            txtId.Clear();
            CargarGrid();
        }
    }
    
    
}

