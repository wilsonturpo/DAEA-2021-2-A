using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
        private int n = 0;
		public Form1()
		{
			InitializeComponent();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnBuscar.Enabled = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Obtenemos los valores
            String codigo = txtCodigo.Text;
            String dni = txtDni.Text;
            String nombres = txtNombres.Text;
            String apellidos = txtApellidos.Text;
            String direccion = txtDireccion.Text;
            String telefono = txtTelefono.Text;
            String email = txtEmail.Text;
            DateTime fechaNac = dtpFechaNac.Value;
            String departamento = txtDepartamento.Text;
            String cargo = txtCargo.Text;

            //Agregamos los valores al datagridview
            dgvUsuarios.Rows.Add(codigo,dni,nombres,apellidos,direccion,telefono,email,fechaNac, departamento, cargo);

            //Limpiamos los txt
            txtCodigo.Text = "";
            txtNombres.Text="";
            txtDni.Text="";
            txtApellidos.Text="";
            txtDireccion.Text="";
            txtTelefono.Text="";
            txtEmail.Text="";
            //dtpFechaNac.Value=new DateTime();
            txtDepartamento.Text="";
            txtCargo.Text="";
        }

        //Obtenemos el evento de click en una fila del dgvUsuarios
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            n = e.RowIndex;
            if (n!=-1)
            {
                //Asignamos los valores para la edición
                txtCodigo.Text = (String)dgvUsuarios.Rows[n].Cells[0].Value;
                txtDni.Text = (String)dgvUsuarios.Rows[n].Cells[1].Value;
                txtNombres.Text = (String)dgvUsuarios.Rows[n].Cells[2].Value;
                txtApellidos.Text = (String)dgvUsuarios.Rows[n].Cells[3].Value; 
                txtDireccion.Text = (String)dgvUsuarios.Rows[n].Cells[4].Value;
                txtTelefono.Text = (String)dgvUsuarios.Rows[n].Cells[5].Value;
                txtEmail.Text = (String)dgvUsuarios.Rows[n].Cells[6].Value;
                dtpFechaNac.Value = (DateTime)dgvUsuarios.Rows[n].Cells[7].Value;
                txtDepartamento.Text = (String)dgvUsuarios.Rows[n].Cells[8].Value;
                txtCargo.Text = (String)dgvUsuarios.Rows[n].Cells[9].Value;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (n!=1)
            {
                dgvUsuarios.Rows[n].Cells[0].Value = txtCodigo.Text;
                dgvUsuarios.Rows[n].Cells[1].Value = txtDni.Text;
                dgvUsuarios.Rows[n].Cells[2].Value = txtNombres.Text;
                dgvUsuarios.Rows[n].Cells[3].Value = txtApellidos.Text;
                dgvUsuarios.Rows[n].Cells[4].Value = txtDireccion.Text;
                dgvUsuarios.Rows[n].Cells[5].Value = txtTelefono.Text;
                dgvUsuarios.Rows[n].Cells[6].Value = txtEmail.Text;
                dgvUsuarios.Rows[n].Cells[7].Value = dtpFechaNac.Value;
                dgvUsuarios.Rows[n].Cells[8].Value = txtDepartamento.Text;
                dgvUsuarios.Rows[n].Cells[9].Value = txtCargo.Text;
            }
            //Limpiamos los txt
            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtDni.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            //dtpFechaNac.Value=new DateTime();
            txtDepartamento.Text = "";
            txtCargo.Text = "";

            //Habilitamos los botones respectivos
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnBuscar.Enabled = false;
            btnAgregar.Enabled = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (n!=1)
            {
                dgvUsuarios.Rows.RemoveAt(n);
            }
            //Limpiamos los txt
            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtDni.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            //dtpFechaNac.Value=new DateTime();
            txtDepartamento.Text = "";
            txtCargo.Text = "";

            //Habilitamos los botones respectivos
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnBuscar.Enabled = false;
            btnAgregar.Enabled = true;
        }
    }
}
