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
    /// Formulario para realizar operaciones CRUD sobre la entidad Inventario.
    /// Permite mostrar, agregar, modificar y eliminar registros de inventario.
    /// </summary>
    public partial class CRUDInventario: Form
    {
        InventarioBL _inventarioBL = new InventarioBL();
        InventarioEN _inventarioEN = new InventarioEN();

        /// <summary>
        /// Constructor del formulario CRUDInventario.
        /// Inicializa los componentes, oculta el campo ID y carga la lista de Inventario en el grid.
        /// </summary>
        public CRUDInventario()
        {
            InitializeComponent();
            txtId.Visible = false;
            CargarGrid();
        }

        /// <summary>
        /// Carga los datos del inventario desde la capa lógica y los muestra en el DataGridView.
        /// </summary>
        public void CargarGrid()
        {
            dgvMostrarInventario.DataSource = _inventarioBL.MostrarInventario();
        }

        private bool EsEnteroValido(string texto)
        {
            return int.TryParse(texto, out _);
        }

        private bool EsDecimalValido(string texto)
        {
            return decimal.TryParse(texto, out _);
        }



        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón Guardar.
        /// Registra un nuevo inventario en la base de datos con los datos proporcionados.
        /// </summary>
       
        private void btnGuardar_Click(object sender, EventArgs e)
        {

           
            _inventarioEN.IdVideoJuegos = Convert.ToInt32(txtIdVideoJuegos.Text);
            _inventarioEN.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            _inventarioEN.PorcentajeGanancia = Convert.ToDecimal(txtPorcentajeGanancia.Text);
            _inventarioEN.StockInicial = Convert.ToInt32(txtStockInicial.Text);
            _inventarioEN.Vendido = Convert.ToInt32(txtVendido.Text);
            _inventarioEN.StockActual = Convert.ToInt32(txtStockActual.Text);
            _inventarioEN.IdEstadoVenta = Convert.ToInt32(txtIdEstadoVenta.Text);
            _inventarioEN.IdEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
            _inventarioBL.GuardarInventario(_inventarioEN);
            CargarGrid();
            // Limpiar campos
            txtIdVideoJuegos.Clear();
            txtPrecioVenta.Clear();
            txtPorcentajeGanancia.Clear();
            txtStockInicial.Clear();
            txtVendido.Clear();
            txtStockActual.Clear();
            txtIdEstadoVenta.Clear();
            txtIdEmpleado.Clear();
        }


        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón Modificar.
        /// Actualiza un registro de inventario con los nuevos datos proporcionados.
        /// </summary>
       
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            _inventarioEN.IdVideoJuegos = Convert.ToInt32(txtIdVideoJuegos.Text);
            _inventarioEN.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            _inventarioEN.PorcentajeGanancia = Convert.ToDecimal(txtPorcentajeGanancia.Text);
            _inventarioEN.StockInicial = Convert.ToInt32(txtStockInicial.Text);
            _inventarioEN.Vendido = Convert.ToInt32(txtVendido.Text);
            _inventarioEN.StockActual = Convert.ToInt32(txtStockActual.Text);
            _inventarioEN.IdEstadoVenta = Convert.ToInt32(txtIdEstadoVenta.Text);
            _inventarioEN.IdEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
            _inventarioBL.ModificarInventario(_inventarioEN);
            CargarGrid();
            // Limpiar campos
            txtIdVideoJuegos.Clear();
            txtPrecioVenta.Clear();
            txtPorcentajeGanancia.Clear();
            txtStockInicial.Clear();
            txtVendido.Clear();
            txtStockActual.Clear();
            txtIdEstadoVenta.Clear();
            txtIdEmpleado.Clear();
        }



        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón Eliminar.
        /// Elimina un registro de inventario de la base de datos.
        /// </summary>
       
        private void btnEliminar_Click(object sender, EventArgs e)
        {

           
            _inventarioEN.IdVideoJuegos = Convert.ToInt32(txtIdVideoJuegos.Text);
            _inventarioEN.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            _inventarioEN.PorcentajeGanancia = Convert.ToDecimal(txtPorcentajeGanancia.Text);
            _inventarioEN.StockInicial = Convert.ToInt32(txtStockInicial.Text);
            _inventarioEN.Vendido = Convert.ToInt32(txtVendido.Text);
            _inventarioEN.StockActual = Convert.ToInt32(txtStockActual.Text);
            _inventarioEN.IdEstadoVenta = Convert.ToInt32(txtIdEstadoVenta.Text);
            _inventarioEN.IdEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
            _inventarioBL.EliminarInventario(_inventarioEN);
            CargarGrid();
            // Limpiar campos
            txtIdVideoJuegos.Clear();
            txtPrecioVenta.Clear();
            txtPorcentajeGanancia.Clear();
            txtStockInicial.Clear();
            txtVendido.Clear();
            txtStockActual.Clear();
            txtIdEstadoVenta.Clear();
            txtIdEmpleado.Clear();
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en una celda del DataGridView.
        /// Llena los campos del formulario con los datos del inventario seleccionado.
        /// </summary>
       
        private void dgvMostrarInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMostrarInventario.SelectedRows.Count > 0)
            {
                txtId.Text = dgvMostrarInventario.CurrentRow.Cells["Id"].Value.ToString();
                txtIdVideoJuegos.Text = dgvMostrarInventario.CurrentRow.Cells["IdVideoJuegos"].Value.ToString();
                txtPrecioVenta.Text = dgvMostrarInventario.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                txtPorcentajeGanancia.Text = dgvMostrarInventario.CurrentRow.Cells["PorcentajeGanancia"].Value.ToString();
                txtStockInicial.Text = dgvMostrarInventario.CurrentRow.Cells["StockInicial"].Value.ToString();
                txtVendido.Text = dgvMostrarInventario.CurrentRow.Cells["Vendido"].Value.ToString();
                txtStockActual.Text = dgvMostrarInventario.CurrentRow.Cells["StockActual"].Value.ToString();
                txtIdEstadoVenta.Text = dgvMostrarInventario.CurrentRow.Cells["IdEstadoVenta"].Value.ToString();
                txtIdEmpleado.Text = dgvMostrarInventario.CurrentRow.Cells["IdEmpleado"].Value.ToString();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
