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
            IProxy proxy = new Proxy();
            string ciudad = textBox1.Text;
            var response = proxy.weather(ciudad);
            Console.WriteLine($"Ciudad: {response.name}");
            Console.WriteLine($"Temp min: {response.main.temp_min}");
            Console.WriteLine($"Temp max: {response.main.temp_max}");
            MessageBox.Show($"Ciudad: {response.name}\nTemp min: {response.main.temp_min}\nTemp max: {response.main.temp_max}");
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
        }
    }
}
