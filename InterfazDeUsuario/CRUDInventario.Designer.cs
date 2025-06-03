namespace InterfazDeUsuario
{
    partial class CRUDInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvMostrarInventario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdVideoJuegos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPorcentajeGanancia = new System.Windows.Forms.TextBox();
            this.txtStockInicial = new System.Windows.Forms.TextBox();
            this.txtVendido = new System.Windows.Forms.TextBox();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.txtIdEstadoVenta = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(191, 471);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 37);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvMostrarInventario
            // 
            this.dgvMostrarInventario.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.dgvMostrarInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarInventario.Location = new System.Drawing.Point(24, 514);
            this.dgvMostrarInventario.Name = "dgvMostrarInventario";
            this.dgvMostrarInventario.Size = new System.Drawing.Size(954, 161);
            this.dgvMostrarInventario.TabIndex = 1;
            this.dgvMostrarInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarInventario_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite su Id de VideoJuegos:";
            // 
            // txtIdVideoJuegos
            // 
            this.txtIdVideoJuegos.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVideoJuegos.Location = new System.Drawing.Point(218, 154);
            this.txtIdVideoJuegos.Name = "txtIdVideoJuegos";
            this.txtIdVideoJuegos.Size = new System.Drawing.Size(195, 29);
            this.txtIdVideoJuegos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite el Precio venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite el Porcentaje de Ganancia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Digite el Stock Inicial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Digite la cantidad Vendida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(563, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Digite el Stock Actual:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Digite el Id de Estado Venta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(582, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Digite el Id del Empleado:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(218, 228);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(195, 29);
            this.txtPrecioVenta.TabIndex = 11;
            // 
            // txtPorcentajeGanancia
            // 
            this.txtPorcentajeGanancia.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeGanancia.Location = new System.Drawing.Point(218, 348);
            this.txtPorcentajeGanancia.Name = "txtPorcentajeGanancia";
            this.txtPorcentajeGanancia.Size = new System.Drawing.Size(195, 29);
            this.txtPorcentajeGanancia.TabIndex = 12;
            // 
            // txtStockInicial
            // 
            this.txtStockInicial.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockInicial.Location = new System.Drawing.Point(218, 423);
            this.txtStockInicial.Name = "txtStockInicial";
            this.txtStockInicial.Size = new System.Drawing.Size(195, 29);
            this.txtStockInicial.TabIndex = 13;
            // 
            // txtVendido
            // 
            this.txtVendido.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendido.Location = new System.Drawing.Point(572, 154);
            this.txtVendido.Name = "txtVendido";
            this.txtVendido.Size = new System.Drawing.Size(195, 29);
            this.txtVendido.TabIndex = 14;
            // 
            // txtStockActual
            // 
            this.txtStockActual.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockActual.Location = new System.Drawing.Point(567, 228);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(195, 29);
            this.txtStockActual.TabIndex = 15;
            // 
            // txtIdEstadoVenta
            // 
            this.txtIdEstadoVenta.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEstadoVenta.Location = new System.Drawing.Point(572, 324);
            this.txtIdEstadoVenta.Name = "txtIdEstadoVenta";
            this.txtIdEstadoVenta.Size = new System.Drawing.Size(195, 29);
            this.txtIdEstadoVenta.TabIndex = 16;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(480, 471);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(104, 37);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(743, 471);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 37);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(807, 354);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(19, 20);
            this.txtId.TabIndex = 20;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpleado.Location = new System.Drawing.Point(579, 396);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(195, 29);
            this.txtIdEmpleado.TabIndex = 17;
            // 
            // CRUDInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfazDeUsuario.Properties.Resources.R1;
            this.ClientSize = new System.Drawing.Size(976, 702);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.txtIdEstadoVenta);
            this.Controls.Add(this.txtStockActual);
            this.Controls.Add(this.txtVendido);
            this.Controls.Add(this.txtStockInicial);
            this.Controls.Add(this.txtPorcentajeGanancia);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdVideoJuegos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMostrarInventario);
            this.Controls.Add(this.btnGuardar);
            this.Name = "CRUDInventario";
            this.Text = "CRUDInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvMostrarInventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdVideoJuegos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPorcentajeGanancia;
        private System.Windows.Forms.TextBox txtStockInicial;
        private System.Windows.Forms.TextBox txtVendido;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.TextBox txtIdEstadoVenta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIdEmpleado;
    }
}