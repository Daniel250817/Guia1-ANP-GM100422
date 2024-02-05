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

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculos_básicos Calculos_básicos = new Calculos_básicos();
            Calculos_básicos.Show();
            this.Hide();
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            Conversion_Unidades Conversion_Unidades = new Conversion_Unidades();
            Conversion_Unidades.Show();
            this.Hide();
        }

        private void btnFormulaGen_Click(object sender, EventArgs e)
        {
            FormulaGeneral FormulaGeneral = new FormulaGeneral();
            FormulaGeneral.Show();
            this.Hide();
        }
    }

}
