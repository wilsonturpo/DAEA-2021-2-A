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
    public partial class PrincipalMDI : Form
    {
        public PrincipalMDI()
        {
            InitializeComponent();
        }

        private void mnuSisSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuManUsuarios_Click(object sender, EventArgs e)
        {
            manUsuario frmUsuario = new manUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();

        }

        private void mnuManProductos_Click(object sender, EventArgs e)
        {
            manProducto frmProducto = new manProducto();
            frmProducto.MdiParent = this;
            frmProducto.Show();

        }

        private void mnuManCategorias_Click(object sender, EventArgs e)
        {
            manCategorias frmCategoria = new manCategorias();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void mnuManProveedores_Click(object sender, EventArgs e)
        {
            manProveedores frmProveedor = new manProveedores();
            frmProveedor.MdiParent = this;
            frmProveedor.Show();
        }

        private void mnuManClientes_Click(object sender, EventArgs e)
        {
            manClientes frmCliente = new manClientes();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }
    }
}
