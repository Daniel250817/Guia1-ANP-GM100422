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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void lbGuia1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            frmventana frmventana = new frmventana();
            frmventana.Show();
            this.Hide();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Calculadora Calculadora = new Calculadora();
            Calculadora.Show();
            this.Hide();
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            Descuentos Descuentos = new Descuentos();
            Descuentos.Show();
            this.Hide();
        }
    }

}
