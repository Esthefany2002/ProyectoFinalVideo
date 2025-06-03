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
    /// Formulario CRUD para la gestión de categorías.
    /// Permite mostrar, agregar, modificar y eliminar categorías desde la interfaz gráfica.
    /// </summary>
    public partial class CRUDCategoria: Form
    {
        CategoriaBL _categoriaBL = new CategoriaBL();
        CategoriaEN _categoriaEN = new CategoriaEN();

        /// <summary>
        /// Constructor del formulario CRUDCategoria.
        /// Inicializa componentes, oculta el textbox de ID y carga las categorías en el grid.
        /// </summary>
        public CRUDCategoria()
        {
            InitializeComponent();
            txtId.Visible = false;
            CargarGrid();
        }

        /// <summary>
        /// Carga todas las categorías desde la base de datos y las muestra en el DataGridView.
        /// </summary>
        public void CargarGrid()
        {
            dgvMostrarCategoria.DataSource = _categoriaBL.MostrarCategoria();
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
        /// Evento del botón Guardar. Guarda una nueva categoría con los datos ingresados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {


            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo 'Categoria' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!EsSoloLetras(nombre))
            {
                MessageBox.Show("El campo 'Categoria' solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _categoriaEN.Nombre = txtNombre.Text;
            _categoriaBL.GuardarCategoria(_categoriaEN);
            CargarGrid();
            txtNombre.Clear();
        }


        /// <summary>
        /// Evento del botón Modificar. Actualiza una categoría existente seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El campo 'Categoria' no puede estar vacío o solo contener espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsSoloLetras(nombre))
            {
                MessageBox.Show("El campo 'Categoria' solo debe contener letras y espacios entre palabras (sin números ni símbolos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _categoriaEN.Id = Convert.ToByte(txtId.Text);
            _categoriaEN.Nombre = txtNombre.Text;
            _categoriaBL.ModificarCategoria(_categoriaEN);
            txtNombre.Clear();
            txtId.Clear();
            CargarGrid();
        }


        /// <summary>
        /// Evento del botón Eliminar. Elimina una categoría seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (!EsByteValido(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar una categoría válida para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _categoriaEN.Id = Convert.ToByte(txtId.Text);
            _categoriaEN.Nombre = txtNombre.Text;
            _categoriaBL.EliminarCategoria(_categoriaEN);
            txtNombre.Clear();
            txtId.Clear();
            CargarGrid();
        }

        private void dgvMostrarCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento cuando se selecciona una fila en el DataGridView.
        /// Carga los datos de la categoría seleccionada en los campos de texto.
        /// Los cuales se pueden Guardar, Modificar y Eliminar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dgvMostrarCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMostrarCategoria.SelectedRows.Count > 0)
            {
                txtNombre.Text = dgvMostrarCategoria.CurrentRow.Cells["Nombre"].Value.ToString();
                txtId.Text = dgvMostrarCategoria.CurrentRow.Cells["Id"].Value.ToString();
            }

        }
    }
}
