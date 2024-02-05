using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics.Contracts;
using System.Security.Policy;

namespace GM100422_Guia1
{
    public partial class Sistema : Form
    {
        string password;
        public Sistema()
        {
            InitializeComponent();
        }

        private void Sistema_Load(object sender, EventArgs e)
        {

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text; //capturamos los valores de usuario y contraseña 
            string contra = txtContra.Text;
            string url = "C:\\Users\\julio\\OneDrive - Universidad Francisco Gavidia\\UFG\\U 2024 Ciclo 5\\ANP\\Tareas\\Guia1-ANP-GM100422\\GM100422_Guia1" + usuario + ".txt"; //usted elige ubicación de carpeta, la que hizo en el paso 3, pero esta debe existir




            if (File.Exists(url)) //verifica si existe
            { password = File.ReadAllText(url); //lee el texto almacenado dentro del archivo
              if(contra.Equals(password)) //verifica si contraseña es igual al archivo
                 { MessageBox.Show("¡Ingreso exitoso, bienvenido!"); //login exitoso
                    MostrarMenu();
                }
              else 
                {
                    MessageBox.Show("¡Contraseña incorrecta! 🙁 ");//login fallido    
                }
            }
            
            else {
                MessageBox.Show("¡Usuario incorrecto! 🙁"); //usuario incorrecto
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text; //capturamos los valores de usuario y contraseña 
            string contra = txtContra.Text;
            string url = "C:\\Users\\julio\\OneDrive - Universidad Francisco Gavidia\\UFG\\U 2024 Ciclo 5\\ANP\\Tareas\\Guia1-ANP-GM100422\\GM100422_Guia1" + usuario + ".txt"; //usted elige ubicación de carpeta, la que hizo en el paso 3, pero esta debe existir




            if (File.Exists(url)) //verifica que el archive exista
            {
                  MessageBox.Show("ERROR. ¡Usuario ya existe!"); //usuario registrado
                  txtUsuario.Clear(); //limpiamos todos los textbox
                  txtContra.Clear(); 
            }
            else
            {
                File.WriteAllText(url, contra); /*Crea un Nuevo archivo con ese nombre y guarda dentro del archivo el valor del segundo parámetro*/ 
                MessageBox.Show("Usuario Registrado con éxito");
                txtUsuario.Clear();
                txtContra.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MostrarMenu()
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void lbUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
