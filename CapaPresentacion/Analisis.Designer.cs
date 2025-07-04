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
            SuspendLayout();
            // 
            // formsPlotCantidad
            // 
            formsPlotCantidad.DisplayScale = 1.25F;
            formsPlotCantidad.Location = new Point(24, 219);
            formsPlotCantidad.Name = "formsPlotCantidad";
            formsPlotCantidad.Size = new Size(265, 229);
            formsPlotCantidad.TabIndex = 0;
            // 
            // formsPlotPromedio
            // 
            formsPlotPromedio.DisplayScale = 1.25F;
            formsPlotPromedio.Location = new Point(529, 229);
            formsPlotPromedio.Name = "formsPlotPromedio";
            formsPlotPromedio.Size = new Size(259, 219);
            formsPlotPromedio.TabIndex = 1;
            // 
            // formsPlotMarca
            // 
            formsPlotMarca.DisplayScale = 1.25F;
            formsPlotMarca.Location = new Point(257, -2);
            formsPlotMarca.Name = "formsPlotMarca";
            formsPlotMarca.Size = new Size(310, 246);
            formsPlotMarca.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(46, 25);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // Analisis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(formsPlotMarca);
            Controls.Add(formsPlotPromedio);
            Controls.Add(formsPlotCantidad);
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
    }
}