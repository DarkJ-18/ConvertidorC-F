using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertidor
{
    public partial class Form1 : Form
    {
        Temperatura temperatura = new Temperatura();

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            temperatura.setGrados(double.Parse(txtgradosc.Text));

            lbltotal.Text = "Grados Fahrenheit: " + temperatura.convertir().ToString();
            lbltotal.Visible = true;
        }
    }
}
