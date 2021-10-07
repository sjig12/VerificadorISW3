using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Verificador_Precios
{
    public partial class Form1 : Form
    {
        private int segundos = 0;

        private String codigo = "";
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            logo.Location = new Point(this.Width / 2 - logo.Width / 2, 30);
            pase_el_codigo.Location = new Point(this.Width / 2 - pase_el_codigo.Width / 2, 500);
            escaner.Location = new Point(this.Width / 2 - escaner.Width / 2, this.Height / 2 + 20);
            imagenes.Location = new Point(200, this.Height / 2 -300);
            nombre_producto.Location = new Point(this.Width / 2 - 300, 100);
            error.Location = new Point(this.Width / 2 -400, this.Height / 2-error.Height+50);
            datos_productos.Location = new Point(this.Width/2 -50,this.Height/2 -200);
            error2.Location = new Point(this.Width / 2 - 500, this.Height / 2 - error.Height + 60);
            flechas.Location = new Point(this.Width / 2 - flechas.Width / 2, this.Height - flechas.Height);
            bienvenidos.Location = new Point(this.Width / 2 - bienvenidos.Width / 2, logo.Height + 50);
            alerta.Location = new Point(this.Width/2 - alerta.Width/2,150);

            nombre_producto.Visible = false;
            error.Visible = false;
            imagenes.Visible = false;
            alerta.Visible = false;
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    MySqlConnection servidor;
                    servidor = new MySqlConnection("server = 127.0.0.1; user = root; database = dbvp; SSL Mode = None; ");
                    servidor.Open();
                    string query = "SELECT producto_nombre, producto_precio, producto_stock, producto_imagen FROM productos WHERE producto_codigo =" + codigo + ";";
                    //MessageBox.Show(query);
                    MySqlCommand consulta;
                    consulta = new MySqlCommand(query, servidor);
                    MySqlDataReader resultado = consulta.ExecuteReader();

                    segundos = 0;
                    timer1.Enabled = false;

                    if (resultado.HasRows)
                    {
                        this.BackColor = Color.LawnGreen;
                        logo.Visible = false;
                        pase_el_codigo.Visible = false;
                        error.Visible = false;
                        bienvenidos.Visible = false;
                        flechas.Visible = false;
                        alerta.Visible = false;
                        error2.Visible = false;

                        
                        resultado.Read();
                        //MessageBox.Show(resultado.GetString(1));
                        datos_productos.Visible = true;
                        nombre_producto.Text = resultado.GetString(0);
                        nombre_producto.Visible = true;
                        escaner.Visible=false;
                        imagenes.Visible = true;
                        datos_productos.Text = "Precio: $"+resultado.GetString(1) +
                            Environment.NewLine + "Cantidad Disponible: " + resultado.GetString(2);
                        imagenes.ImageLocation = resultado.GetString(3);
                        imagenes.SizeMode = PictureBoxSizeMode.Zoom;

                        segundos = 0;
                        timer1.Enabled = true;
                    }
                    else
                    {
                     
                        segundos = 0;
                        timer1.Enabled = true;
                        error.Visible = true;
                        alerta.Visible = true;


                        datos_productos.Visible = false;
                        imagenes.Visible = false;
                        pase_el_codigo.Visible = false;
                        logo.Visible = false;
                        nombre_producto.Visible = false;
                        escaner.Visible = false;
                        error2.Visible = false;
                        flechas.Visible = false;
                        bienvenidos.Visible = false;
                        
                        this.BackColor = Color.White;

                    }

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString(), "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }

                codigo = "";
            }
            else
            {
                codigo += e.KeyChar;
            }
            
            if (codigo.Equals("911")){
                this.BackColor = Color.Red;
                segundos = 0;
                timer1.Enabled = true;
                error2.Text = "ERROR #002" + Environment.NewLine + "EL ESCÁNER NO ESTÁ FUNCIONANDO CORRECTAMENTE" +
                    Environment.NewLine + "LLAME A SOPORTE TÉCNICO.";
                error2.Visible=true;
                error.Visible = false;
                logo.Visible = false;
                pase_el_codigo.Visible = false;
                nombre_producto.Visible = false;
                imagenes.Visible = false;
                escaner.Visible = false;
                datos_productos.Visible = false;
                bienvenidos.Visible = false;
                alerta.Visible=true;
                flechas.Visible = false;
                codigo="";
            }
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
            segundos++;

            if (segundos == 4)
            {
                timer1.Enabled = false;
                escaner.Visible = true;
                imagenes.Visible = false;
                datos_productos.Text = "";
                this.BackColor = Color.LawnGreen;
                logo.Visible = true;
                pase_el_codigo.Visible = true;
                nombre_producto.Visible = false;
                error.Visible = false;
                error2.Visible = false;
                flechas.Visible = true;
                bienvenidos.Visible = true;
                alerta.Visible=false;
            }
		}

    }
}