using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;

namespace POOHerencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor1 = new Vendedor();
            vendedor1.Apellido = txtApellidos.Text;
            vendedor1.Nombre= txtNombres.Text;
            vendedor1.Documento= txtDocumento.Text;
            vendedor1.Tipo = cboTipo.Text;
            vendedor1.TipoContrato = cboTipoContrato.Text;

            vendedor1.calcularSueldo(750);

            dgvVendedores.Rows.Insert(0, vendedor1.Tipo, vendedor1.Apellido, vendedor1.Nombre, vendedor1.Documento, vendedor1.Sueldo);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
