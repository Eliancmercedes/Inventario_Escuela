namespace CapaPresentacion
{
    partial class GestionArticulos
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
            cbTipoArticulo = new ComboBox();
            txtMarca = new TextBox();
            txtPrecio = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            txtIdEliminar = new TextBox();
            btnMostrar = new Button();
            dgvArticulos = new DataGridView();
            btnVerGraficas = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnBusquedaAvz = new Button();
            btnMenu = new Button();
            label4 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbTipoArticulo
            // 
            cbTipoArticulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoArticulo.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cbTipoArticulo.FormattingEnabled = true;
            cbTipoArticulo.Location = new Point(23, 66);
            cbTipoArticulo.Margin = new Padding(3, 2, 3, 2);
            cbTipoArticulo.Name = "cbTipoArticulo";
            cbTipoArticulo.Size = new Size(133, 23);
            cbTipoArticulo.TabIndex = 0;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(158, 163);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(110, 23);
            txtMarca.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(158, 225);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 23);
            txtPrecio.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Rockwell", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(12, 424);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 37);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(167, 322);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 28);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(158, 285);
            txtIdEliminar.Margin = new Padding(3, 2, 3, 2);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(110, 23);
            txtIdEliminar.TabIndex = 5;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Rockwell", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(12, 477);
            btnMostrar.Margin = new Padding(3, 2, 3, 2);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(140, 33);
            btnMostrar.TabIndex = 6;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            dgvArticulos.AllowUserToAddRows = false;
            dgvArticulos.AllowUserToDeleteRows = false;
            dgvArticulos.AllowUserToResizeColumns = false;
            dgvArticulos.AllowUserToResizeRows = false;
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Location = new Point(792, 367);
            dgvArticulos.Margin = new Padding(3, 2, 3, 2);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.ReadOnly = true;
            dgvArticulos.RowHeadersWidth = 51;
            dgvArticulos.Size = new Size(459, 224);
            dgvArticulos.TabIndex = 7;
            // 
            // btnVerGraficas
            // 
            btnVerGraficas.Font = new Font("Rockwell", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVerGraficas.Location = new Point(606, 490);
            btnVerGraficas.Margin = new Padding(3, 2, 3, 2);
            btnVerGraficas.Name = "btnVerGraficas";
            btnVerGraficas.Size = new Size(147, 39);
            btnVerGraficas.TabIndex = 8;
            btnVerGraficas.Text = "Ver Graficas";
            btnVerGraficas.UseVisualStyleBackColor = true;
            btnVerGraficas.Click += btnVerGraficas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 161);
            label1.Name = "label1";
            label1.Size = new Size(138, 22);
            label1.TabIndex = 9;
            label1.Text = "Coloque Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(5, 223);
            label2.Name = "label2";
            label2.Size = new Size(136, 22);
            label2.TabIndex = 10;
            label2.Text = "Coloque Precio";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(5, 283);
            label3.Name = "label3";
            label3.Size = new Size(140, 22);
            label3.TabIndex = 11;
            label3.Text = "Eliminar por ID";
            // 
            // btnBusquedaAvz
            // 
            btnBusquedaAvz.Font = new Font("Rockwell", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBusquedaAvz.Location = new Point(597, 558);
            btnBusquedaAvz.Margin = new Padding(3, 2, 3, 2);
            btnBusquedaAvz.Name = "btnBusquedaAvz";
            btnBusquedaAvz.Size = new Size(167, 33);
            btnBusquedaAvz.TabIndex = 12;
            btnBusquedaAvz.Text = "Ir a busqueda avanzada";
            btnBusquedaAvz.UseVisualStyleBackColor = true;
            btnBusquedaAvz.Click += btnBusquedaAvz_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Rockwell", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(1158, 24);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(93, 29);
            btnMenu.TabIndex = 13;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(23, 31);
            label4.Name = "label4";
            label4.Size = new Size(141, 22);
            label4.TabIndex = 14;
            label4.Text = "Seleccionar tipo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 88);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbTipoArticulo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMarca);
            panel1.Controls.Add(btnMostrar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(txtIdEliminar);
            panel1.Controls.Add(txtPrecio);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 611);
            panel1.TabIndex = 15;
            // 
            // GestionArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 8, 8);
            BackgroundImage = Properties.Resources.Diseño_sin_título__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1284, 611);
            Controls.Add(panel1);
            Controls.Add(btnMenu);
            Controls.Add(btnBusquedaAvz);
            Controls.Add(btnVerGraficas);
            Controls.Add(dgvArticulos);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "GestionArticulos";
            Text = "Form1";
            Load += GestionArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbTipoArticulo;
        private TextBox txtMarca;
        private TextBox txtPrecio;
        private Button btnAgregar;
        private Button btnEliminar;
        private TextBox txtIdEliminar;
        private Button btnMostrar;
        private DataGridView dgvArticulos;
        private Button btnVerGraficas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnBusquedaAvz;
        private Button btnMenu;
        private Label label4;
        private Panel panel1;
    }
}