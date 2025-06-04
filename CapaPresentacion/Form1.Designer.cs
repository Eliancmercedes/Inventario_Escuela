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
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cbarticulo
            // 
            cbarticulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbarticulo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbarticulo.FormattingEnabled = true;
            cbarticulo.Items.AddRange(new object[] { "Cuaderno", "Lapicero", "Regla" });
            cbarticulo.Location = new Point(48, 120);
            cbarticulo.Name = "cbarticulo";
            cbarticulo.Size = new Size(183, 27);
            cbarticulo.TabIndex = 0;
            // 
            // btnmostrar
            // 
            btnmostrar.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmostrar.Location = new Point(87, 186);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new Size(93, 42);
            btnmostrar.TabIndex = 1;
            btnmostrar.Text = "Mostrar";
            btnmostrar.UseVisualStyleBackColor = true;
            btnmostrar.Click += btnmostrar_Click;
            // 
            // dataGProduct
            // 
            dataGProduct.AllowUserToAddRows = false;
            dataGProduct.AllowUserToDeleteRows = false;
            dataGProduct.AllowUserToOrderColumns = true;
            dataGProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGProduct.Location = new Point(418, 479);
            dataGProduct.Name = "dataGProduct";
            dataGProduct.ReadOnly = true;
            dataGProduct.Size = new Size(465, 74);
            dataGProduct.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(444, 80);
            label1.Name = "label1";
            label1.Size = new Size(383, 37);
            label1.TabIndex = 3;
            label1.Text = "Escuelita Biblica El Cerro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 58);
            label2.Name = "label2";
            label2.Size = new Size(203, 23);
            label2.TabIndex = 4;
            label2.Text = "Seleccione su Producto";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.alcaldia_de_higuey_responde_a_demanda_de_politecnico_gregorio_luperon_focus_0_81_0_3_608_342;
            pictureBox1.Location = new Point(327, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(632, 336);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.descarga;
            pictureBox2.Location = new Point(36, 265);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(225, 259);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1037, 585);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGProduct);
            Controls.Add(btnmostrar);
            Controls.Add(cbarticulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbarticulo;
        private Button btnmostrar;
        private DataGridView dataGProduct;
        private Label label1;
        private Label label2;
        private PictureBox pbescuela;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
