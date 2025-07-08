namespace CapaPresentacion
{
    partial class Analisis
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
            formsPlotCantidad = new ScottPlot.WinForms.FormsPlot();
            formsPlotPromedio = new ScottPlot.WinForms.FormsPlot();
            formsPlotMarca = new ScottPlot.WinForms.FormsPlot();
            btnVolver = new Button();
            btnBusquedaAvz = new Button();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // formsPlotCantidad
            // 
            formsPlotCantidad.DisplayScale = 1.25F;
            formsPlotCantidad.Location = new Point(22, 305);
            formsPlotCantidad.Margin = new Padding(3, 2, 3, 2);
            formsPlotCantidad.Name = "formsPlotCantidad";
            formsPlotCantidad.Size = new Size(397, 295);
            formsPlotCantidad.TabIndex = 0;
            // 
            // formsPlotPromedio
            // 
            formsPlotPromedio.DisplayScale = 1.25F;
            formsPlotPromedio.Location = new Point(841, 308);
            formsPlotPromedio.Margin = new Padding(3, 2, 3, 2);
            formsPlotPromedio.Name = "formsPlotPromedio";
            formsPlotPromedio.Size = new Size(431, 292);
            formsPlotPromedio.TabIndex = 1;
            // 
            // formsPlotMarca
            // 
            formsPlotMarca.BackColor = Color.White;
            formsPlotMarca.DisplayScale = 1.25F;
            formsPlotMarca.Location = new Point(394, 19);
            formsPlotMarca.Margin = new Padding(3, 2, 3, 2);
            formsPlotMarca.Name = "formsPlotMarca";
            formsPlotMarca.Size = new Size(483, 285);
            formsPlotMarca.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(40, 19);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(147, 39);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnBusquedaAvz
            // 
            btnBusquedaAvz.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBusquedaAvz.Location = new Point(569, 445);
            btnBusquedaAvz.Name = "btnBusquedaAvz";
            btnBusquedaAvz.Size = new Size(147, 31);
            btnBusquedaAvz.TabIndex = 4;
            btnBusquedaAvz.Text = "Ir a busqueda avanzada";
            btnBusquedaAvz.UseVisualStyleBackColor = true;
            btnBusquedaAvz.Click += btnBusquedaAvz_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(1125, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(147, 39);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // Analisis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Diseño_sin_título__9_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1284, 611);
            Controls.Add(btnMenu);
            Controls.Add(btnBusquedaAvz);
            Controls.Add(btnVolver);
            Controls.Add(formsPlotMarca);
            Controls.Add(formsPlotPromedio);
            Controls.Add(formsPlotCantidad);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Analisis";
            Text = "Form1";
            Load += Analisis_Load;
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlotCantidad;
        private ScottPlot.WinForms.FormsPlot formsPlotPromedio;
        private ScottPlot.WinForms.FormsPlot formsPlotMarca;
        private Button btnVolver;
        private Button btnBusquedaAvz;
        private Button btnMenu;
    }
}