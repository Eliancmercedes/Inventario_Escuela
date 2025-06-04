namespace CapaPresentacion
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
            cbarticulo = new ComboBox();
            btnmostrar = new Button();
            dataGProduct = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGProduct).BeginInit();
            SuspendLayout();
            // 
            // cbarticulo
            // 
            cbarticulo.FormattingEnabled = true;
            cbarticulo.Items.AddRange(new object[] { "Cuaderno", "Lapicero", "Regla" });
            cbarticulo.Location = new Point(64, 186);
            cbarticulo.Name = "cbarticulo";
            cbarticulo.Size = new Size(121, 23);
            cbarticulo.TabIndex = 0;
            cbarticulo.Text = "Seleccione el Articulo";
            // 
            // btnmostrar
            // 
            btnmostrar.Location = new Point(95, 302);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new Size(75, 23);
            btnmostrar.TabIndex = 1;
            btnmostrar.Text = "Mostrar";
            btnmostrar.UseVisualStyleBackColor = true;
            btnmostrar.Click += btnmostrar_Click;
            // 
            // dataGProduct
            // 
            dataGProduct.AllowUserToOrderColumns = true;
            dataGProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGProduct.Location = new Point(472, 213);
            dataGProduct.Name = "dataGProduct";
            dataGProduct.Size = new Size(352, 122);
            dataGProduct.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 585);
            Controls.Add(dataGProduct);
            Controls.Add(btnmostrar);
            Controls.Add(cbarticulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbarticulo;
        private Button btnmostrar;
        private DataGridView dataGProduct;
    }
}
