using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programas_de_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* creamos el evento del boton salir para ello crearemos el evenHandler en la clase de
        designer del mismo formulario con la siguiente sintacsis 
        this.Salir.Click += new System.EventHandler(this.Salir_Click); asi procederemos con dicho evento*/
        private void Salir_Click(Object sender,EventArgs e)
        {
            this.Close();

        }

    }
}
