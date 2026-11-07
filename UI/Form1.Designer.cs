namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDni = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtImporte = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            cmbTipoBicicleta = new ComboBox();
            label4 = new Label();
            dtpFechaAlquiler = new DateTimePicker();
            label5 = new Label();
            btnAgregarLista = new Button();
            dgvAlquileresPendientes = new DataGridView();
            label6 = new Label();
            dgvAlquileresRegistrados = new DataGridView();
            label7 = new Label();
            btnQuitarLista = new Button();
            btnGuardarTodos = new Button();
            btnBuscar = new Button();
            btnConsultar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlquileresPendientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlquileresRegistrados).BeginInit();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.Location = new Point(126, 36);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 1;
            label1.Text = "Dni";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Importe";
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(126, 134);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(125, 27);
            txtImporte.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 468);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 5;
            label3.Text = "Id del alquiler";
            // 
            // txtId
            // 
            txtId.Location = new Point(152, 461);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 4;
            // 
            // cmbTipoBicicleta
            // 
            cmbTipoBicicleta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoBicicleta.FormattingEnabled = true;
            cmbTipoBicicleta.Location = new Point(126, 85);
            cmbTipoBicicleta.Name = "cmbTipoBicicleta";
            cmbTipoBicicleta.Size = new Size(151, 28);
            cmbTipoBicicleta.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 88);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 7;
            label4.Text = "Tipo de bicicleta";
            // 
            // dtpFechaAlquiler
            // 
            dtpFechaAlquiler.Format = DateTimePickerFormat.Short;
            dtpFechaAlquiler.Location = new Point(140, 201);
            dtpFechaAlquiler.Name = "dtpFechaAlquiler";
            dtpFechaAlquiler.Size = new Size(161, 27);
            dtpFechaAlquiler.TabIndex = 8;
            dtpFechaAlquiler.Value = new DateTime(2026, 11, 6, 19, 13, 24, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 206);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 9;
            label5.Text = "Fecha de alquiler";
            // 
            // btnAgregarLista
            // 
            btnAgregarLista.Location = new Point(55, 264);
            btnAgregarLista.Name = "btnAgregarLista";
            btnAgregarLista.Size = new Size(204, 29);
            btnAgregarLista.TabIndex = 10;
            btnAgregarLista.Text = "Agregar a lista";
            btnAgregarLista.UseVisualStyleBackColor = true;
            btnAgregarLista.Click += btnAgregarLista_Click;
            // 
            // dgvAlquileresPendientes
            // 
            dgvAlquileresPendientes.AllowUserToAddRows = false;
            dgvAlquileresPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlquileresPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlquileresPendientes.Location = new Point(420, 36);
            dgvAlquileresPendientes.Name = "dgvAlquileresPendientes";
            dgvAlquileresPendientes.ReadOnly = true;
            dgvAlquileresPendientes.RowHeadersWidth = 51;
            dgvAlquileresPendientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlquileresPendientes.Size = new Size(548, 165);
            dgvAlquileresPendientes.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(422, 13);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 12;
            label6.Text = "Alquileres pendientes";
            // 
            // dgvAlquileresRegistrados
            // 
            dgvAlquileresRegistrados.AllowUserToAddRows = false;
            dgvAlquileresRegistrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlquileresRegistrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlquileresRegistrados.Location = new Point(420, 324);
            dgvAlquileresRegistrados.Name = "dgvAlquileresRegistrados";
            dgvAlquileresRegistrados.ReadOnly = true;
            dgvAlquileresRegistrados.RowHeadersWidth = 51;
            dgvAlquileresRegistrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlquileresRegistrados.Size = new Size(548, 207);
            dgvAlquileresRegistrados.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(422, 301);
            label7.Name = "label7";
            label7.Size = new Size(153, 20);
            label7.TabIndex = 14;
            label7.Text = "Alquileres registrados";
            // 
            // btnQuitarLista
            // 
            btnQuitarLista.Location = new Point(432, 220);
            btnQuitarLista.Name = "btnQuitarLista";
            btnQuitarLista.Size = new Size(143, 29);
            btnQuitarLista.TabIndex = 15;
            btnQuitarLista.Text = "Quitar de lista";
            btnQuitarLista.UseVisualStyleBackColor = true;
            btnQuitarLista.Click += btnQuitarLista_Click;
            // 
            // btnGuardarTodos
            // 
            btnGuardarTodos.Location = new Point(703, 220);
            btnGuardarTodos.Name = "btnGuardarTodos";
            btnGuardarTodos.Size = new Size(123, 29);
            btnGuardarTodos.TabIndex = 16;
            btnGuardarTodos.Text = "Guardar todos";
            btnGuardarTodos.UseVisualStyleBackColor = true;
            btnGuardarTodos.Click += btnGuardarTodos_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(80, 522);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(422, 568);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 18;
            btnConsultar.Text = "Consultar todos";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(594, 568);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(764, 568);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(929, 568);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 615);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnConsultar);
            Controls.Add(btnBuscar);
            Controls.Add(btnGuardarTodos);
            Controls.Add(btnQuitarLista);
            Controls.Add(label7);
            Controls.Add(dgvAlquileresRegistrados);
            Controls.Add(label6);
            Controls.Add(dgvAlquileresPendientes);
            Controls.Add(btnAgregarLista);
            Controls.Add(label5);
            Controls.Add(dtpFechaAlquiler);
            Controls.Add(label4);
            Controls.Add(cmbTipoBicicleta);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(txtImporte);
            Controls.Add(label1);
            Controls.Add(txtDni);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAlquileresPendientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlquileresRegistrados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDni;
        private Label label1;
        private Label label2;
        private TextBox txtImporte;
        private Label label3;
        private TextBox txtId;
        private ComboBox cmbTipoBicicleta;
        private Label label4;
        private DateTimePicker dtpFechaAlquiler;
        private Label label5;
        private Button btnAgregarLista;
        private DataGridView dgvAlquileresPendientes;
        private Label label6;
        private DataGridView dgvAlquileresRegistrados;
        private Label label7;
        private Button btnQuitarLista;
        private Button btnGuardarTodos;
        private Button btnBuscar;
        private Button btnConsultar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}
