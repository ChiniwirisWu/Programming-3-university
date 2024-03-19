using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perro_guau_guau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perro perrito = new Perro("Perro", "chiwawa", "0.4 metros");
            perrito.Nombre = "Sleepy cat";
            perrito.Altura = "0.1 metros";
            perrito.Raza = "Gato ";

            textResult.Text = perrito.comer("Atunes");
        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
