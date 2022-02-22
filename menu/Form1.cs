using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class MenuPruebaForm : Form
    {
        public MenuPruebaForm()
        {
            InitializeComponent();
        }

        private void AcercaDeToolStripMenuItem_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Éste es un ejemplo\ndel uso de menús.",
            "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BorrarColor()
        {
            // borra todas las marcas de verificación
            negroToolStripMenuItem.Checked = false;
            azulToolStripMenuItem.Checked = false;
            rojoToolStripMenuItem.Checked = false;
            verdeToolStripMenuItem.Checked = false;
        }

        private void NegroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // restablece marcas de verificación para los MenuItems de color
             BorrarColor();
            
            // establece Color a Negro
            mostrarLabel.ForeColor = Color.Black;
            negroToolStripMenuItem.Checked = true;
        }

        private void MostrarLabel_Click(object sender, EventArgs e)
        {

        }

        private void AzulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarColor();

            // establece Color a Negro
            mostrarLabel.ForeColor = Color.Blue;
            azulToolStripMenuItem.Checked = true;
        }

        private void RojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarColor();

            // establece Color a Negro
            mostrarLabel.ForeColor = Color.Red;
            rojoToolStripMenuItem.Checked = true;
        }

        private void VerdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarColor();

            // establece Color a Negro
            mostrarLabel.ForeColor = Color.Green;
            verdeToolStripMenuItem.Checked = true;
        }
        private void BorrarFuente()
        {
            // borra todas las marcas de verificación
            timesToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            comicToolStripMenuItem.Checked = false;
        }

        private void TimesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarFuente();
            
            // establece fuente Times New Roman
            timesToolStripMenuItem.Checked = true;
            mostrarLabel.Font = new Font(
                "Times New Roman", 14, mostrarLabel.Font.Style);
        }

        private void CourierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarFuente();

            // establece fuente Courier
            courierToolStripMenuItem.Checked = true;
            mostrarLabel.Font = new Font(
                "Courier", 14, mostrarLabel.Font.Style);
        }

        private void ComicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarFuente();
            
            // establece fuente Comic Sans
            comicToolStripMenuItem.Checked = true;
            mostrarLabel.Font = new Font(
                "Comic Sans MS", 14, mostrarLabel.Font.Style);
        }

        private void NegritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            negritaToolStripMenuItem.Checked = !negritaToolStripMenuItem.Checked;
            mostrarLabel.Font = new Font(
            mostrarLabel.Font.FontFamily, 14,
            mostrarLabel.Font.Style ^ FontStyle.Bold);
        }

        private void CursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cursivaToolStripMenuItem.Checked = !cursivaToolStripMenuItem.Checked;
            mostrarLabel.Font = new Font(
            mostrarLabel.Font.FontFamily, 14,
            mostrarLabel.Font.Style ^ FontStyle.Italic);
        }
    }
}
