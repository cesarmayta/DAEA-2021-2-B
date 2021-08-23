using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLAB01_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string codigo = lbkCodigo.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string fecha = dtpFechaNac.Text;
            string departamento = cmbDepartamento.Text;

            dgvUsuarios.Rows.Add(codigo, dni, nombre, apellidos,direccion,telefono,email,fecha,departamento);
        }
    }
}
