using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
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
    /// Formulario para realizar operaciones CRUD sobre la entidad Género.
    /// Permite mostrar, agregar, modificar y eliminar registros de géneros.
    /// </summary>
    public partial class CRUDGenero: Form

    {

        GeneroBL _generoBL = new GeneroBL();
        GeneroEN _generoEN = new GeneroEN();

        /// <summary>
        /// Constructor del formulario CRUDGenero.
        /// Inicializa los componentes, oculta el campo ID y carga la lista de Genero en el grid.
        /// </summary>
        public CRUDGenero()
        {
            InitializeComponent();
            txtId.Visible = false;
            CargarGrid();
        }

        /// <summary>
        /// Carga los datos de los géneros desde la capa lógica y los muestra en el DataGridView.
        /// </summary>
        public void CargarGrid()
        {
            dgvMostrarGenero.DataSource = _generoBL.MostrarGenero();
        }

        /// <summary>
        /// Valida que el texto contenga solo letras y espacios.
        /// </summary>
        private bool EsTextoValido(string texto)
        {
            return texto.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        /// <summary>
        /// Verifica si el texto se puede convertir a un entero válido.
        /// </summary>
        private bool EsEnteroValido(string texto)
        {
            return int.TryParse(texto, out _);
        }




        private void CRUDGenero_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón Guardar.
        /// </summary>
       
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
                return;
            }
            _generoEN.Nombre = nombre;
            _generoBL.GuardarGenero(_generoEN);
            CargarGrid();
            txtNombre.Clear();
        }


        /// <summary>
        /// Evento que se ejecuta al hacer clic sobre una fila del DataGridView.
        /// Llena los campos de texto con los datos del género seleccionado.
        /// </summary>
       
        private void dgvMostrarGenero_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvMostrarGenero.SelectedRows.Count > 0)
            {
                txtNombre.Text = dgvMostrarGenero.CurrentRow.Cells["Nombre"].Value.ToString();
                txtId.Text = dgvMostrarGenero.CurrentRow.Cells["Id"].Value.ToString();
            }
        }


        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón Eliminar.
        /// Elimina el género seleccionado en el DataGridView.
        /// </summary>
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (!EsEnteroValido(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un género válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _generoEN.Id = Convert.ToInt32(txtId.Text);
            _generoEN.Nombre = txtNombre.Text;
            _generoBL.EliminarGenero(_generoEN);
            txtNombre.Clear();
            txtId.Clear();
            CargarGrid();
        }


        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón Modificar.
        /// Actualiza el género seleccionado con los datos ingresados en los campos de texto.
        /// </summary>
      
        private void btnModificar_Click(object sender, EventArgs e)
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
                return;
            }
            _generoEN.Id = Convert.ToInt32(txtId.Text);
            _generoEN.Nombre = nombre;
            _generoBL.ModificarGenero(_generoEN);
            txtNombre.Clear();
            txtId.Clear();
            CargarGrid();
        }

      
    }
}
