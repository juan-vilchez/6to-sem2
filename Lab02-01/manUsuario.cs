using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = textBox1.Text;
            string nombre = textBox2.Text;
            string telefono = textBox3.Text;
            string direccion = textBox4.Text;
            string fecha = dateTimePicker1.Text;
            string apellido = textBox6.Text;
            string email = textBox7.Text;

            dataGridView1.Rows.Add(dni, nombre, apellido,direccion, email, telefono, fecha);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
    }
}
