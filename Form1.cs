using ClimaExamen.ServicesAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClimaExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bPruebas_Click(object sender, EventArgs e)
        {
            
        }

        private void bRegistrate_Click(object sender, EventArgs e)
        {
            labelLogIn.Visible = false;
            labelRegistro.Visible = true;
            tbContraLogin.Visible = false;
            tbContraRegistro.Visible = true;
            tbCorreoLogin.Visible = false;
            tbCorreoRegistro.Visible = true;
            bAceptarLogin.Visible = false;
            bAceptarRegistro.Visible = true;
            labelCuenta.Visible = false;
            bRegistrate.Visible = false;
            bAgregarCiudad.Visible = false;
        }

        private void bAceptarRegistro_Click(object sender, EventArgs e)
        {
            labelLogIn.Visible = true;
            labelRegistro.Visible = false;
            tbContraLogin.Visible = true;
            tbContraRegistro.Visible = false;
            tbCorreoLogin.Visible = true;
            tbCorreoRegistro.Visible = false;
            bAceptarLogin.Visible = true;
            bAceptarRegistro.Visible = false;
            labelCuenta.Visible = true;
            bRegistrate.Visible = true;
            bAgregarCiudad.Visible = false;
        }

        private void bAgregarCiudad_Click(object sender, EventArgs e)
        {
            IProxy proxy = new Proxy();
            if(textBox1.Text == "")
            {
                MessageBox.Show("Favor de escribir la ciudad");
            }
            else
            {
                string ciudad = textBox1.Text;
                var response = proxy.weather("rome");
                MessageBox.Show($"Ciudad: {response.name}\nTemp min: {response.main.temp_min}\nTemp max: {response.main.temp_max}");
                textBox1.Text = "";
            }
        }

        private void bAceptarLogin_Click(object sender, EventArgs e)
        {
            if(tbContraLogin.Text == "" && tbCorreoLogin.Text == "")
            {
                MessageBox.Show("Usuario ó contraseña incorrectos");
            }
            else
            {
                tbCorreoLogin.Text = "";
                tbContraLogin.Text = "";
                labelLogIn.Visible = false;
                labelRegistro.Visible = false;
                tbContraLogin.Visible = false;
                tbContraRegistro.Visible = false;
                tbCorreoLogin.Visible = false;
                tbCorreoRegistro.Visible = false;
                bAceptarLogin.Visible = false;
                bAceptarRegistro.Visible = false;
                labelCuenta.Visible = false;
                bRegistrate.Visible = false;
                bAgregarCiudad.Visible = true;
                labelContrasena.Visible = false;
                labelCorreo.Visible = false;
                bRegresar.Visible = true;
                textBox1.Visible = true;
            }
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            labelLogIn.Visible = true;
            labelRegistro.Visible = false;
            tbContraLogin.Visible = true;
            tbContraRegistro.Visible = false;
            tbCorreoLogin.Visible = true;
            tbCorreoRegistro.Visible = false;
            bAceptarLogin.Visible = true;
            bAceptarRegistro.Visible = false;
            labelCuenta.Visible = true;
            bRegistrate.Visible = true;
            bAgregarCiudad.Visible = false;
            labelContrasena.Visible = true;
            labelCorreo.Visible = true;
            bRegresar.Visible = false;
            textBox1.Visible = false;
        }
    }
}
