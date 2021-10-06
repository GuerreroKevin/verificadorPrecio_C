using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VerificadorPrecios
{
    
    public partial class Form1 : Form
    {
        private int tiempo = 0;
        private String codigo = "";

        private bool proFind = true;

        private MySqlDataReader result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width / 2, 
                Screen.PrimaryScreen.WorkingArea.Height / 2);

            pictureBox1.Location = new Point(this.Width / 2 - pictureBox1.Width / 2,
                this.Height / 4 - pictureBox1.Height + 50);

            pictureBox2.Location = new Point(this.Width / 2 - pictureBox2.Width / 2,
                this.Height / 2 + pictureBox2.Height - 30);

            label1.Location = new Point(this.Width / 2 - label1.Width / 2,
                this.Height / 2);

            label2.Location = new Point(this.Width / 2 - label2.Width / 2,
                20);

            pPrecio.Visible = false;
            pStock.Visible = false;
            pImagen.Visible = false;
            pNombre.Visible = false;    
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                //database connection
                try
                {
                    MySqlConnection server;
                    server = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios; SSL Mode=None;");
                    server.Open();
                    String queryString = "SELECT producto_codigo, producto_nombre, producto_cantidad_disponible, producto_precio, producto_imagen " +
                        "FROM productos WHERE producto_codigo = " + codigo + ";";
                    MySqlCommand query = new MySqlCommand(queryString, server);
                    result = query.ExecuteReader();

                    if (result.HasRows)
                    {

                        label1.Text = "Buscando...";
                        label1.Location = new Point(this.Width / 2 - label1.Width / 2,
                            this.Height / 4 - label1.Height + 50);

                        pictureBox2.Image = global::VerificadorPrecios.Properties.Resources.gifload;
                        pictureBox2.Location = new Point(this.Width / 2 - pictureBox2.Width / 2,
                            this.Height / 2 );
                        pictureBox2.Visible = true;

                        tiempo = 0;
                        timer1.Enabled = true;

                        label2.Visible = false;
                        pictureBox1.Visible = false;
                        pPrecio.Visible = false;
                        pStock.Visible = false;
                        pNombre.Visible = false;
                        pImagen.Visible = false;
                    }
                    else
                    {
                        proFind = false;

                        label1.Text = "No se encontro el código\n     Intentelo de nuevo";
                        label1.Location = new Point(this.Width / 2 - (label1.Width / 2),
                            this.Height / 4 + label1.Height + 30);

                        pictureBox2.Image = global::VerificadorPrecios.Properties.Resources.error_msg;
                        pictureBox2.Location = new Point(this.Width / 2 - pictureBox2.Width / 2,
                            this.Height / 2 + pictureBox2.Height / 2);
                        pictureBox2.Visible = true;

                        tiempo = 0;
                        timer1.Enabled = true;

                        label2.Visible = false;
                        pictureBox1.Visible = false;
                        pPrecio.Visible = false;
                        pStock.Visible = false;
                        pNombre.Visible = false;
                        pImagen.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                codigo = "";
            }
            else
            {
                codigo += e.KeyChar;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;
            if (tiempo == 2 && proFind)
            {
                result.Read();
                label1.Visible = false;

                label2.Text = "Busqueda exitosa";
                label2.Location = new Point(this.Width / 2 - label2.Width / 2,
                    20);
                label2.Visible = true;

                pNombre.Text = "Articulo: " + result.GetString(1);
                pNombre.Location = new Point((this.Width / 2), 
                    this.Height / 4 + label2.Height);
                pNombre.Visible = true;

                pStock.Text = "Stock: " + result.GetString(2);
                pStock.Location = new Point((this.Width / 2),
                    this.Height / 4 + pNombre.Height + 45);
                pStock.Visible = true;

                pPrecio.Text = "Precio: $" + result.GetString(3);
                pPrecio.Location = new Point((this.Width / 2),
                    (this.Height / 4) + pStock.Height + 80);
                pPrecio.Visible = true;

                pImagen.ImageLocation = result.GetString(4);
                pImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pImagen.Location = new Point((this.Width / 4) - (pImagen.Width / 2),
                    (this.Height / 2) - pImagen.Height / 2 + 30);
                pImagen.Visible = true;

                pictureBox2.Visible = false;
            }
            else if (tiempo == 5 && !proFind)
            {
                timer1.Enabled = false;
                returnToOriginal();
            }
            if (tiempo == 10)
            {
                timer1.Enabled = false;
                returnToOriginal();
            }
        }
        private void returnToOriginal()
        {
            pictureBox2.Visible = true;
            label1.Visible = true;
            label1.Text = "Pase el código de barras por el escaner";
            label2.Visible = true;
            pictureBox1.Visible = true;
            label1.Location = new Point(this.Width / 2 - label1.Width / 2,
                this.Height / 2);
            pPrecio.Visible = false;
            pStock.Visible = false;
            pNombre.Visible = false;
            pictureBox2.Location = new Point(this.Width / 2 - pictureBox2.Width / 2,
                this.Height / 2 + pictureBox2.Height - 30);
            pictureBox2.Image = global::VerificadorPrecios.Properties.Resources.barcode_scan;
            pImagen.Visible = false;
            pImagen.ImageLocation = null;

            proFind = true;
        }
    }
}
