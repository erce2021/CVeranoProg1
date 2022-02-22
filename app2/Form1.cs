using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app2
{
    public partial class UsoDeFichasForm : Form
    {
        public UsoDeFichasForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mostrarLabel.ForeColor = Color.Black;
        }
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mostrarLabel.ForeColor = Color.Red;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            mostrarLabel.ForeColor = Color.Green;
        }
        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            mostrarLabel.Font = new Font(mostrarLabel.Font.Name, 12);
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            mostrarLabel.Font = new Font(mostrarLabel.Font.Name, 16);
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            mostrarLabel.Font = new Font(mostrarLabel.Font.Name, 20);
        }
        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            mostrarLabel.Text = "¡Hola!";
        }

        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            mostrarLabel.Text = "¡Adiós!";
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
         
            Application.Exit();
        }
    }
}
