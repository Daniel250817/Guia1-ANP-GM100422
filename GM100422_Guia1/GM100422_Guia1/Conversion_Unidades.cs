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
    public partial class Conversion_Unidades : Form
    {
        public Conversion_Unidades()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Conversion_Unidades_Load(object sender, EventArgs e)
        {
            //agrega item al combo
            cmBop.Items.Clear();
            cmBop.Items.Add("Temperatura: Celcius a Farenheit");
            cmBop.Items.Add("Longitud: Metros a pies");
            cmBop.Items.Add("Peso: Kilogramos a libras");
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCalcular.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor válido para la conversión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double valorEntrada;
            if (!double.TryParse(txtCalcular.Text, out valorEntrada))
            {
                MessageBox.Show("Ingrese un número válido para la conversión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string opcionSeleccionada = cmBop.SelectedItem?.ToString();

            if (opcionSeleccionada == null)
            {
                MessageBox.Show("Por favor, seleccione una opción de conversión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double resultado = RealizarConversion(opcionSeleccionada, valorEntrada);

            txtResultadoConv.Text = $"{valorEntrada} {ObtenerUnidadEntrada(opcionSeleccionada)} es igual a {resultado} {ObtenerUnidadSalida(opcionSeleccionada)}";
        }

        private double RealizarConversion(string opcion, double valorEntrada)
        {
            switch (opcion)
            {
                case "Temperatura: Celcius a Farenheit":
                    return ConvertirCelciusAFarenheit(valorEntrada);
                case "Longitud: Metros a pies":
                    return ConvertirMetrosAPies(valorEntrada);
                case "Peso: Kilogramos a libras":
                    return ConvertirKilogramosALibras(valorEntrada);
                default:
                    return 0; // Manejo de opción no válida
            }
        }

        private double ConvertirCelciusAFarenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }

        private double ConvertirMetrosAPies(double metros)
        {
            return metros * 3.28084;
        }

        private double ConvertirKilogramosALibras(double kilogramos)
        {
            return kilogramos * 2.20462;
        }

        private string ObtenerUnidadEntrada(string opcion)
        {
            if (opcion.StartsWith("Temperatura"))
                return "Celcius";
            else if (opcion.StartsWith("Longitud"))
                return "Metros";
            else if (opcion.StartsWith("Peso"))
                return "Kilogramos";
            else
                return "";
        }

        private string ObtenerUnidadSalida(string opcion)
        {
            if (opcion.EndsWith("Farenheit"))
                return "Farenheit";
            else if (opcion.EndsWith("pies"))
                return "Pies";
            else if (opcion.EndsWith("libras"))
                return "Libras";
            else
                return "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
    }
}
