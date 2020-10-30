namespace Programas_de_C_
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
            // hacemos las instanciaciones de las clases de cada componente
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.MenuInicial=new System.Windows.Forms.MenuStrip();
            this.Archivo=new System.Windows.Forms.ToolStripMenuItem();
            this.Electricidad=new System.Windows.Forms.ToolStripMenuItem();
            this.Salir=new System.Windows.Forms.ToolStripMenuItem();
            this.txtContraseña=new System.Windows.Forms.TextBox();
            this.btnIniciar=new System.Windows.Forms.Button();
            this.MenuInicial.SuspendLayout(); 
            this.SuspendLayout();
            

            //
            //MenuInicial 
            // creamos el menu archivo con sus respectivas propiedades
            /* items y addRange nos permite agregar objetos al menu Inicial  
            esto nos permite poder tener varias opciones  */
            this.MenuInicial.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{ this.Archivo, this.Electricidad});
            this.MenuInicial.Location=new System.Drawing.Point(0,0);
            this.MenuInicial.Name="MenuInicial";
            this.MenuInicial.Size=new System.Drawing.Size(500,25);
            //
            //Archivo
            //
            /*configuracion basica del menu Archivo en el cual podemos tener varios sub-menus
             en el cualñ agregaremos Sub-Menus Salir y Guardar*/
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{
            this.Salir
            });
            this.Archivo.Font=new System.Drawing.Font("Papyrus",9f,System.Drawing.FontStyle.Italic);
            this.Archivo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Archivo.Size=new System.Drawing.Size(160,24);
            this.Archivo.Name="Archivo";
            this.Archivo.Text="Archivo";
            //
            //Salir
            //
            this.Salir.Font=new System.Drawing.Font("Papyrus",9f,System.Drawing.FontStyle.Italic);
            this.Salir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Salir.Size=new System.Drawing.Size(160,24);
            this.Salir.Name="Salir";
            this.Salir.Text="Salir";
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            //txtUsuario
            //
            this.txtUsuario.Location=new System.Drawing.Point(100,100);
            this.txtUsuario.Name="txtUsuario";
            this.txtUsuario.Size=new System.Drawing.Size(100,20);
            this.txtUsuario.TabIndex=0;
            //
            //calculadora
            //
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.MenuInicial);
            this.MainMenuStrip=this.MenuInicial;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Pruebas";
             this.MenuInicial.ResumeLayout(false);
            this.MenuInicial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

            private System.Windows.Forms.TextBox txtUsuario;
            private System.Windows.Forms.TextBox txtContraseña;
            private System.Windows.Forms.Button btnIniciar;
            private System.Windows.Forms.MenuStrip MenuInicial;
            private System.Windows.Forms.ToolStripMenuItem Archivo;
            private System.Windows.Forms.ToolStripMenuItem Electricidad;
            private System.Windows.Forms.ToolStripMenuItem Salir;



        

        
    }
}

