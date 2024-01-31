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
    public partial class Descuentos : Form
    {
        public Descuentos()
        {
            InitializeComponent();
        }

        private void Descuentos_Load(object sender, EventArgs e)
        {

        }

        private void rbtnSubgerente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbApelli_Click(object sender, EventArgs e)
        {

        }

        private void txtSalarioB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMontoDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalNeto_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnGerente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnSecretaria_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario
            string nombre = txtNombre.Text;
            string apellido = txtApelli.Text;

            // Validar que se haya seleccionado un tipo de empleado
            if (!rbtnGerente.Checked && !rbtnSubgerente.Checked && !rbtnSecretaria.Checked)
            {
                MessageBox.Show("Por favor, seleccione el tipo de empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSalarioB.Text))
            {
                MessageBox.Show("Por favor, ingrese el salario bruto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtSalarioB.Text, out double salarioBruto))
            {
                MessageBox.Show("El salario bruto debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double descuentoPorcentaje = 0;

            // Determinar el tipo de empleado y aplicar descuentos
            if (rbtnGerente.Checked)
            {
                descuentoPorcentaje = 0.20;
            }
            else if (rbtnSubgerente.Checked)
            {
                descuentoPorcentaje = 0.15;
            }
            else if (rbtnSecretaria.Checked)
            {
                descuentoPorcentaje = 0.05;
            }

            // Calcular descuento y salario neto
            double descuento = salarioBruto * descuentoPorcentaje;
            double salarioNeto = salarioBruto - descuento;

            // Mostrar resultados en los TextBox correspondientes
            txtMontoDesc.Text = descuento.ToString("C");
            txtSalNeto.Text = salarioNeto.ToString("C");

            // Mostrar mensaje con el tipo de empleado
            string tipoEmpleado = rbtnGerente.Checked ? "Gerente" : (rbtnSubgerente.Checked ? "Subgerente" : "Secretaria");
            MessageBox.Show($"Hola, {tipoEmpleado} {nombre} {apellido}.\nSalario bruto: {salarioBruto:C}\nDescuento: {descuento:C}\nSalario neto: {salarioNeto:C}",
                "Resultado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }


        private void btnResetear_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txtNombre.Clear();
            txtApelli.Clear();
            txtSalarioB.Clear();
            txtMontoDesc.Clear();
            txtSalNeto.Clear();

            rbtnGerente.Checked = false;
            rbtnSubgerente.Checked = false;
            rbtnSecretaria.Checked = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
    }
}
