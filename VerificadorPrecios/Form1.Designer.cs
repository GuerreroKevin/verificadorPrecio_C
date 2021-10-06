
namespace VerificadorPrecios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pImagen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pPrecio = new System.Windows.Forms.Label();
            this.pStock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VerificadorPrecios.Properties.Resources.barcode_scan;
            this.pictureBox2.Location = new System.Drawing.Point(311, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pImagen
            // 
            this.pImagen.Location = new System.Drawing.Point(35, 93);
            this.pImagen.Name = "pImagen";
            this.pImagen.Size = new System.Drawing.Size(218, 240);
            this.pImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImagen.TabIndex = 2;
            this.pImagen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(156, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pase el código de barras por el escaner";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pPrecio
            // 
            this.pPrecio.AutoSize = true;
            this.pPrecio.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pPrecio.Location = new System.Drawing.Point(627, 227);
            this.pPrecio.Name = "pPrecio";
            this.pPrecio.Size = new System.Drawing.Size(101, 29);
            this.pPrecio.TabIndex = 4;
            this.pPrecio.Text = "pPrecio";
            // 
            // pStock
            // 
            this.pStock.AutoSize = true;
            this.pStock.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pStock.Location = new System.Drawing.Point(627, 180);
            this.pStock.Name = "pStock";
            this.pStock.Size = new System.Drawing.Size(93, 29);
            this.pStock.TabIndex = 5;
            this.pStock.Text = "pStock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(269, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bienvenido";
            // 
            // pNombre
            // 
            this.pNombre.AutoSize = true;
            this.pNombre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pNombre.Location = new System.Drawing.Point(627, 134);
            this.pNombre.Name = "pNombre";
            this.pNombre.Size = new System.Drawing.Size(118, 29);
            this.pNombre.TabIndex = 9;
            this.pNombre.Text = "pNombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pStock);
            this.Controls.Add(this.pPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pImagen);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label pPrecio;
        private System.Windows.Forms.Label pStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pNombre;
    }
}

