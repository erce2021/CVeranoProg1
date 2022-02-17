using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmventana : Form
    {
        

        public frmventana()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbop.Items.Clear();
            cmbop.Items.Add("Sumar");
            cmbop.Items.Add("Restar");

            listadvance.Items.Clear();
            listadvance.Items.Add("Multiplicacion");
            listadvance.Items.Add("Division");
            listadvance.TabIndex = 0;

            cmbop.Enabled = true;
            listadvance.Enabled = true;
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Txtnum2_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void Cmbop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn1.Checked == true)
            {
                cmbop.Enabled = true;
                listadvance.Enabled = false;


            }

        }

        private void Rbtn2_CheckedChanged(object sender, EventArgs e)
        {

            cmbop.Enabled = false;
            listadvance.Enabled = true;
            listadvance.SelectedIndex = 0;
        }

        private void Listadvance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, r;
            n1 = Convert.ToDouble(txtnum1.Text);
            n2 = Convert.ToDouble(txtnum2.Text);

            if (cmbop.Enabled == true)
            {
                if (cmbop.SelectedItem.ToString() == "Sumar") r = n1 + n2;
                else r = n1 - n2;
                MessageBox.Show("El resultado es " + r.ToString(), "Respuesta");
            }

            if (listadvance.Enabled == true)
            {
                if (listadvance.SelectedItem.ToString() == "Multiplicar") r = n1 * n2;
                else r = n1 / n2;
                MessageBox.Show("El resultado es " + r.ToString(), "Respuesta");
            }
        }
    }
}
