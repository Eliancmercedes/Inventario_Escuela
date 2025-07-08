namespace CapaPresentacion
{
    partial class PanelPrincipal
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
            PNMenu = new Panel();
            panel3 = new Panel();
            btnIrBusqueda = new Button();
            btnIrAnalisis = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            btnIrGestion = new Button();
            PNContenedor = new Panel();
            pictureBox2 = new PictureBox();
            PN1 = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            PNMenu.SuspendLayout();
            PNContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PNMenu
            // 
            PNMenu.BackColor = Color.DeepSkyBlue;
            PNMenu.Controls.Add(panel3);
            PNMenu.Controls.Add(btnIrBusqueda);
            PNMenu.Controls.Add(btnIrAnalisis);
            PNMenu.Controls.Add(panel2);
            PNMenu.Controls.Add(panel1);
            PNMenu.Controls.Add(btnIrGestion);
            PNMenu.Dock = DockStyle.Left;
            PNMenu.Location = new Point(0, 40);
            PNMenu.Name = "PNMenu";
            PNMenu.Size = new Size(256, 585);
            PNMenu.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(215, 216, 218);
            panel3.Location = new Point(3, 180);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 43);
            panel3.TabIndex = 9;
            // 
            // btnIrBusqueda
            // 
            btnIrBusqueda.FlatAppearance.BorderSize = 0;
            btnIrBusqueda.FlatStyle = FlatStyle.Flat;
            btnIrBusqueda.Font = new Font("Rockwell", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnIrBusqueda.ForeColor = SystemColors.ButtonHighlight;
            btnIrBusqueda.Image = Properties.Resources.icons8_buscar_100__1_1;
            btnIrBusqueda.ImageAlign = ContentAlignment.MiddleLeft;
            btnIrBusqueda.Location = new Point(8, 178);
            btnIrBusqueda.Name = "btnIrBusqueda";
            btnIrBusqueda.Size = new Size(242, 45);
            btnIrBusqueda.TabIndex = 8;
            btnIrBusqueda.Text = "Busqueda";
            btnIrBusqueda.UseVisualStyleBackColor = true;
            btnIrBusqueda.Click += button3_Click;
            // 
            // btnIrAnalisis
            // 
            btnIrAnalisis.FlatAppearance.BorderSize = 0;
            btnIrAnalisis.FlatStyle = FlatStyle.Flat;
            btnIrAnalisis.Font = new Font("Rockwell", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnIrAnalisis.ForeColor = SystemColors.ButtonHighlight;
            btnIrAnalisis.Image = Properties.Resources.icons8_gráfico_combinado_48;
            btnIrAnalisis.ImageAlign = ContentAlignment.MiddleLeft;
            btnIrAnalisis.Location = new Point(9, 106);
            btnIrAnalisis.Name = "btnIrAnalisis";
            btnIrAnalisis.Size = new Size(239, 45);
            btnIrAnalisis.TabIndex = 7;
            btnIrAnalisis.Text = "Analisis";
            btnIrAnalisis.UseVisualStyleBackColor = true;
            btnIrAnalisis.Click += btnIrAnalisis_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(215, 216, 218);
            panel2.Location = new Point(3, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 43);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(215, 216, 218);
            panel1.Location = new Point(3, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 43);
            panel1.TabIndex = 5;
            // 
            // btnIrGestion
            // 
            btnIrGestion.FlatAppearance.BorderSize = 0;
            btnIrGestion.FlatStyle = FlatStyle.Flat;
            btnIrGestion.Font = new Font("Rockwell", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnIrGestion.ForeColor = SystemColors.ButtonHighlight;
            btnIrGestion.Image = Properties.Resources.icons8_engranaje_48;
            btnIrGestion.ImageAlign = ContentAlignment.MiddleLeft;
            btnIrGestion.Location = new Point(9, 28);
            btnIrGestion.Name = "btnIrGestion";
            btnIrGestion.Size = new Size(244, 45);
            btnIrGestion.TabIndex = 4;
            btnIrGestion.Text = "Gestion";
            btnIrGestion.UseVisualStyleBackColor = true;
            btnIrGestion.Click += btnIrGestion_Click;
            // 
            // PNContenedor
            // 
            PNContenedor.BackColor = Color.FromArgb(215, 216, 218);
            PNContenedor.Controls.Add(pictureBox2);
            PNContenedor.Dock = DockStyle.Fill;
            PNContenedor.Location = new Point(256, 40);
            PNContenedor.Name = "PNContenedor";
            PNContenedor.Size = new Size(1038, 585);
            PNContenedor.TabIndex = 2;
            PNContenedor.Paint += PNContenedor_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Blue_and_White_Vintage_School_Logo__8_;
            pictureBox2.Location = new Point(256, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(520, 515);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // PN1
            // 
            PN1.BackColor = Color.DeepSkyBlue;
            PN1.Dock = DockStyle.Top;
            PN1.Location = new Point(0, 0);
            PN1.Name = "PN1";
            PN1.Size = new Size(1294, 40);
            PN1.TabIndex = 0;
            PN1.Paint += PN1_Paint;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // PanelPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 625);
            Controls.Add(PNContenedor);
            Controls.Add(PNMenu);
            Controls.Add(PN1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PanelPrincipal";
            Text = "Form1";
            PNMenu.ResumeLayout(false);
            PNContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel PNMenu;
        private Panel PNContenedor;
        private Button btnIrGestion;
        private Panel panel1;
        private Panel panel3;
        private Button btnIrBusqueda;
        private Button btnIrAnalisis;
        private Panel panel2;
        private Panel PN1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox pictureBox2;
    }
}