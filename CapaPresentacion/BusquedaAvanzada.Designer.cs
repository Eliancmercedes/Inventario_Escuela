namespace CapaPresentacion
{
    partial class BusquedaAvanzada
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
            btnVolver = new Button();
            cbTipo = new ComboBox();
            lstResultado = new ListBox();
            btnBuscar = new Button();
            txtPrecioMax = new TextBox();
            lblPrecioMax = new Label();
            txtPrecioMin = new TextBox();
            lblPrecioMin = new Label();
            lblMarca = new Label();
            btnMenu = new Button();
            btnVerGraficas = new Button();
            label1 = new Label();
            cbMarca = new ComboBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 11);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(133, 29);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Ir a Gestion";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // cbTipo
            // 
            cbTipo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(158, 105);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(133, 23);
            cbTipo.TabIndex = 9;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(592, 326);
            lstResultado.Margin = new Padding(3, 2, 3, 2);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(606, 274);
            lstResultado.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBuscar.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(182, 497);
            btnBuscar.Margin = new Padding(3, 2, 3, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(124, 37);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtPrecioMax
            // 
            txtPrecioMax.Location = new Point(8, 403);
            txtPrecioMax.Margin = new Padding(3, 2, 3, 2);
            txtPrecioMax.Name = "txtPrecioMax";
            txtPrecioMax.Size = new Size(142, 23);
            txtPrecioMax.TabIndex = 5;
            txtPrecioMax.Text = "Ingreso Opcional";
            // 
            // lblPrecioMax
            // 
            lblPrecioMax.AutoSize = true;
            lblPrecioMax.BackColor = Color.Transparent;
            lblPrecioMax.FlatStyle = FlatStyle.Flat;
            lblPrecioMax.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioMax.ForeColor = SystemColors.ButtonHighlight;
            lblPrecioMax.Location = new Point(12, 370);
            lblPrecioMax.Name = "lblPrecioMax";
            lblPrecioMax.Size = new Size(135, 22);
            lblPrecioMax.TabIndex = 2;
            lblPrecioMax.Text = "Precio Maximo";
            lblPrecioMax.Click += lblPrecioMax_Click;
            // 
            // txtPrecioMin
            // 
            txtPrecioMin.Location = new Point(12, 289);
            txtPrecioMin.Margin = new Padding(3, 2, 3, 2);
            txtPrecioMin.Name = "txtPrecioMin";
            txtPrecioMin.Size = new Size(142, 23);
            txtPrecioMin.TabIndex = 4;
            txtPrecioMin.Text = "Ingreso Opcional";
            // 
            // lblPrecioMin
            // 
            lblPrecioMin.AutoSize = true;
            lblPrecioMin.BackColor = Color.Transparent;
            lblPrecioMin.FlatStyle = FlatStyle.Flat;
            lblPrecioMin.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioMin.ForeColor = SystemColors.ButtonHighlight;
            lblPrecioMin.Location = new Point(12, 252);
            lblPrecioMin.Name = "lblPrecioMin";
            lblPrecioMin.Size = new Size(131, 22);
            lblPrecioMin.TabIndex = 1;
            lblPrecioMin.Text = "Precio Minimo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.Transparent;
            lblMarca.FlatStyle = FlatStyle.Flat;
            lblMarca.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.ForeColor = SystemColors.ButtonHighlight;
            lblMarca.Location = new Point(12, 162);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(65, 22);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Rockwell", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(1102, 23);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(117, 36);
            btnMenu.TabIndex = 10;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnVerGraficas
            // 
            btnVerGraficas.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVerGraficas.Location = new Point(165, 557);
            btnVerGraficas.Name = "btnVerGraficas";
            btnVerGraficas.Size = new Size(141, 29);
            btnVerGraficas.TabIndex = 11;
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
            label1.Location = new Point(3, 103);
            label1.Name = "label1";
            label1.Size = new Size(151, 22);
            label1.TabIndex = 12;
            label1.Text = "Seleccione el tipo";
            // 
            // cbMarca
            // 
            cbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMarca.FormattingEnabled = true;
            cbMarca.Location = new Point(92, 164);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(121, 23);
            cbMarca.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnVerGraficas);
            panel1.Controls.Add(cbMarca);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtPrecioMax);
            panel1.Controls.Add(lblPrecioMax);
            panel1.Controls.Add(txtPrecioMin);
            panel1.Controls.Add(lblPrecioMin);
            panel1.Controls.Add(cbTipo);
            panel1.Controls.Add(lblMarca);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 611);
            panel1.TabIndex = 14;
            // 
            // BusquedaAvanzada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 88);
            BackgroundImage = Properties.Resources.Diseño_sin_título__12_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1284, 611);
            Controls.Add(panel1);
            Controls.Add(btnMenu);
            Controls.Add(lstResultado);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "BusquedaAvanzada";
            Text = "BusquedaAvanzada";
            Load += BusquedaAvanzada_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnVolver;
        private ComboBox cbTipo;
        private ListBox lstResultado;
        private Label lblMarca;
        private Label lblPrecioMin;
        private TextBox txtPrecioMin;
        private Label lblPrecioMax;
        private TextBox txtPrecioMax;
        private Button btnBuscar;
        private Button btnMenu;
        private Button btnVerGraficas;
        private Label label1;
        private ComboBox cbMarca;
        private Panel panel1;
    }
}