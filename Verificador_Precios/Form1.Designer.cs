
namespace Verificador_Precios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pase_el_codigo = new System.Windows.Forms.Label();
            this.escaner = new System.Windows.Forms.PictureBox();
            this.datos_productos = new System.Windows.Forms.Label();
            this.imagenes = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nombre_producto = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.error2 = new System.Windows.Forms.Label();
            this.flechas = new System.Windows.Forms.PictureBox();
            this.bienvenidos = new System.Windows.Forms.Label();
            this.alerta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escaner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flechas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alerta)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(377, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(211, 207);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // pase_el_codigo
            // 
            this.pase_el_codigo.AutoSize = true;
            this.pase_el_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pase_el_codigo.Location = new System.Drawing.Point(118, 222);
            this.pase_el_codigo.Name = "pase_el_codigo";
            this.pase_el_codigo.Size = new System.Drawing.Size(1037, 42);
            this.pase_el_codigo.TabIndex = 1;
            this.pase_el_codigo.Text = "Por favor pase el codigo de barras por debajo del escaner";
            this.pase_el_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // escaner
            // 
            this.escaner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("escaner.BackgroundImage")));
            this.escaner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.escaner.Image = ((System.Drawing.Image)(resources.GetObject("escaner.Image")));
            this.escaner.Location = new System.Drawing.Point(320, 268);
            this.escaner.Name = "escaner";
            this.escaner.Size = new System.Drawing.Size(363, 222);
            this.escaner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.escaner.TabIndex = 2;
            this.escaner.TabStop = false;
            // 
            // datos_productos
            // 
            this.datos_productos.AutoSize = true;
            this.datos_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datos_productos.Location = new System.Drawing.Point(748, 386);
            this.datos_productos.Name = "datos_productos";
            this.datos_productos.Size = new System.Drawing.Size(124, 42);
            this.datos_productos.TabIndex = 3;
            this.datos_productos.Text = "label2";
            this.datos_productos.Visible = false;
            // 
            // imagenes
            // 
            this.imagenes.Location = new System.Drawing.Point(1050, 278);
            this.imagenes.Margin = new System.Windows.Forms.Padding(2);
            this.imagenes.Name = "imagenes";
            this.imagenes.Size = new System.Drawing.Size(497, 439);
            this.imagenes.TabIndex = 4;
            this.imagenes.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nombre_producto
            // 
            this.nombre_producto.AutoSize = true;
            this.nombre_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_producto.Location = new System.Drawing.Point(669, 132);
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.Size = new System.Drawing.Size(194, 55);
            this.nombre_producto.TabIndex = 5;
            this.nombre_producto.Text = "nombre";
            this.nombre_producto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.Location = new System.Drawing.Point(235, 521);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(778, 111);
            this.error.TabIndex = 6;
            this.error.Text = "ERROR #001\r\nLo sentimos, NO se reconoce el código de barras.\r\nPor favor, Diríjase" +
    " a Servicio al Cliente.";
            this.error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // error2
            // 
            this.error2.AutoSize = true;
            this.error2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error2.Location = new System.Drawing.Point(370, 302);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(126, 39);
            this.error2.TabIndex = 7;
            this.error2.Text = "error 2";
            this.error2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.error2.Visible = false;
            // 
            // flechas
            // 
            this.flechas.BackColor = System.Drawing.Color.Transparent;
            this.flechas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flechas.BackgroundImage")));
            this.flechas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flechas.Location = new System.Drawing.Point(945, 278);
            this.flechas.Name = "flechas";
            this.flechas.Size = new System.Drawing.Size(208, 212);
            this.flechas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flechas.TabIndex = 8;
            this.flechas.TabStop = false;
            // 
            // bienvenidos
            // 
            this.bienvenidos.AutoSize = true;
            this.bienvenidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenidos.Location = new System.Drawing.Point(429, 65);
            this.bienvenidos.Name = "bienvenidos";
            this.bienvenidos.Size = new System.Drawing.Size(672, 42);
            this.bienvenidos.TabIndex = 9;
            this.bienvenidos.Text = "BIENVENIDOS A PUNTO DE VENTA";
            this.bienvenidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alerta
            // 
            this.alerta.BackColor = System.Drawing.Color.Transparent;
            this.alerta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alerta.BackgroundImage")));
            this.alerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alerta.Location = new System.Drawing.Point(1108, 325);
            this.alerta.Name = "alerta";
            this.alerta.Size = new System.Drawing.Size(287, 273);
            this.alerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alerta.TabIndex = 10;
            this.alerta.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(1518, 715);
            this.Controls.Add(this.alerta);
            this.Controls.Add(this.bienvenidos);
            this.Controls.Add(this.flechas);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.error);
            this.Controls.Add(this.nombre_producto);
            this.Controls.Add(this.imagenes);
            this.Controls.Add(this.datos_productos);
            this.Controls.Add(this.escaner);
            this.Controls.Add(this.pase_el_codigo);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escaner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flechas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alerta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label pase_el_codigo;
        private System.Windows.Forms.PictureBox escaner;
        private System.Windows.Forms.Label datos_productos;
        private System.Windows.Forms.PictureBox imagenes;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label nombre_producto;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label error2;
        private System.Windows.Forms.PictureBox flechas;
        private System.Windows.Forms.Label bienvenidos;
        private System.Windows.Forms.PictureBox alerta;
    }
}

