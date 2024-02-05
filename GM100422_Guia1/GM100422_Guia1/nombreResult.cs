using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GM100422_Guia1
{
    public partial class nombreResult : Form
    {
        public nombreResult(string texto)
        {
            InitializeComponent();
            lblRecibido.Text = texto;
        }

        private void nombreResult_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            frmventana form1 = new frmventana(); //instanciamos al primer formulario
            this.Close(); //cerramos el formulario actual
            form1.Visible = true; //hacemos visible al form1 de nuevo
        }
    }
}
