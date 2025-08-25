using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; 

namespace Proyecto_Restaurante
{
    public partial class frmRestaurante : Form
    {
        public frmRestaurante()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Hamburguesa", 40, cantidad * 40);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Cupcake", 10, cantidad * 10);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Pollo frito", 45, cantidad * 45);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Ensalada", 30, cantidad * 30);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Panqueques", 35, cantidad * 35);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Taco", 25, cantidad * 25);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Pizza", 20, cantidad * 20);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Papas fritas", 10, cantidad * 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                suma += (int)fila.Cells[3].Value;


            }
            txtTotal.Text = suma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
