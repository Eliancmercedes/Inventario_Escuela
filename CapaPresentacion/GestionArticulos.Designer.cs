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
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            SuspendLayout();
            // 
            // cbTipoArticulo
            // 
            cbTipoArticulo.FormattingEnabled = true;
            cbTipoArticulo.Location = new Point(31, 36);
            cbTipoArticulo.Name = "cbTipoArticulo";
            cbTipoArticulo.Size = new Size(151, 28);
            cbTipoArticulo.TabIndex = 0;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(247, 36);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(125, 27);
            txtMarca.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(247, 79);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(31, 257);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(31, 321);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(247, 131);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(125, 27);
            txtIdEliminar.TabIndex = 5;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(31, 387);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(94, 29);
            btnMostrar.TabIndex = 6;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Location = new Point(294, 185);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.RowHeadersWidth = 51;
            dgvArticulos.Size = new Size(475, 253);
            dgvArticulos.TabIndex = 7;
            // 
            // btnVerGraficas
            // 
            btnVerGraficas.Location = new Point(149, 387);
            btnVerGraficas.Name = "btnVerGraficas";
            btnVerGraficas.Size = new Size(129, 29);
            btnVerGraficas.TabIndex = 8;
            btnVerGraficas.Text = "Ver Graficas";
            btnVerGraficas.UseVisualStyleBackColor = true;
            btnVerGraficas.Click += btnVerGraficas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 39);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 9;
            label1.Text = "Coloque Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 86);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 10;
            label2.Text = "Coloque Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 138);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 11;
            label3.Text = "Eliminar por ID";
            // 
            // GestionArticulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVerGraficas);
            Controls.Add(dgvArticulos);
            Controls.Add(btnMostrar);
            Controls.Add(txtIdEliminar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecio);
            Controls.Add(txtMarca);
            Controls.Add(cbTipoArticulo);
            Name = "GestionArticulos";
            Text = "Form1";
            Load += GestionArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}