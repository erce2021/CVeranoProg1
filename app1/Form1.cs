using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
{
    public partial class DateTimePickerForm : Form
    {
        public DateTimePickerForm()
        {
            InitializeComponent();
        }

        private void DateTimePickerForm_Load(object sender, EventArgs e)
        {
            llegadaDateTimePicker.MinDate = DateTime.Today;
            llegadaDateTimePicker.MaxDate = DateTime.Today.AddYears(1);
        }

        private void LlegadaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaLlegada = llegadaDateTimePicker.Value;

            if (fechaLlegada.DayOfWeek == DayOfWeek.Friday ||
                fechaLlegada.DayOfWeek == DayOfWeek.Saturday ||
                fechaLlegada.DayOfWeek == DayOfWeek.Sunday)
                textBox1.Text = fechaLlegada.AddDays(3).ToLongDateString();
            else
                textBox1.Text = fechaLlegada.AddDays(2).ToLongDateString();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void SalidaLabel_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
