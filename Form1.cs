using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase
{
    public partial class Form1 : Form
    {
        private List<Producto> Productos = new List<Producto>();
        private int edit_indice = -1;

        private void actualizarGrid()
        {
            dgvlistado.DataSource = null;
            dgvlistado.DataSource = Productos;
        }

        private void reseteo()
        {
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtmarca.Clear();
            txtprecio.Clear();
            txtstock.Clear();
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dgvlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvglistado_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvlistado.SelectedRows[0];
            int posicion = dgvlistado.Rows.IndexOf(selected);
            edit_indice = posicion;

            Producto product = Productos[posicion];
            txtnombre.Text = product.Nombre;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Producto product = new Producto();
            product.Nombre = txtnombre.Text;
            product.Description = txtdescripcion.Text;
            product.Marca = txtmarca.Text;
            product.Precio = float.Parse( txtprecio.Text);
            product.Stock = int.Parse(txtstock.Text);

            if (edit_indice > -1)
            {
                Productos[edit_indice] = product;
                edit_indice = -1;

            }
            else
            {
                Productos.Add(product);
            }
            actualizarGrid();
            reseteo();
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1)
            {
                Productos.RemoveAt(edit_indice);
                edit_indice = -1;
                reseteo();
                actualizarGrid();

            }
            else
            {
                MessageBox.Show("Dar doble click sobre elemento seleccionar y borrar ");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
