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
    public partial class FormulaGeneral : Form
    {
        public FormulaGeneral()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtA.Text, out double a) &&
            double.TryParse(txtB.Text, out double b) &&
            double.TryParse(txtC.Text, out double c))
            {
                // Calcular discriminante
                double discriminante = Math.Pow(b, 2) - (4 * a * c);

                if (discriminante >= 0)
                {
                    // Calcular las dos soluciones
                    double solucion1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                    double solucion2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                    // Mostrar soluciones en los TextBox correspondientes
                    txtResult1.Text = solucion1.ToString();
                    txtResult2.Text = solucion2.ToString();

                    // Mostrar la fórmula general en el GroupBox
                    groupBSolucion.Text = $"Solución: {a}x² + {b}x + {c} = 0";

                    // Asignar valores a los TextBox dentro de groupBSolucion
                    txtValorA.Text = a.ToString();
                    txtValorB.Text = b.ToString();
                    txtValorB2.Text = b.ToString();  // Supongo que es una copia de txtValorB
                    txtvalorAC.Text = $"({a}) ({c})";
                }
                else
                {
                    // Mostrar mensaje si el discriminante es negativo
                    MessageBox.Show("La ecuación no tiene soluciones reales.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Mostrar mensaje de error si no se ingresaron valores válidos
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos A, B y C.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
    }

}
    


