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
    public partial class frmventana : Form
    {
        public frmventana()
        {
            InitializeComponent();
        }


        private void frmventana_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string texto = txtNombre.Text; 
            string mensaje = string.Format("Bienvenido al segundo formulario " + texto); 
            nombreResult frmrecibe = new nombreResult(mensaje); /* creo un objeto del segundo formulario, adonde mando información*/ 
            frmrecibe.Visible = true; // muestra el nuevo formulario this.Visible = false; // esconde el formulario actual
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbGuia1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
    }
}
