using ProyectoPOS_1CA_A.CapaEntidades;
using ProyectoPOS_1CA_A.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOS_1CA_A
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            //creo una instancia del formulario FrmProductos
            FrmProductos frm = new FrmProductos();
            //muestro el formulario
            frm.ShowDialog();
        }

        
        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            FrmCliente2 frm = new FrmCliente2();
            frm.ShowDialog();
        }

        private void btnVentaRapida_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();
            frm.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea Cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                this .Close();

            FrmLogin frm = new FrmLogin();
                 frm.ShowDialog();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Usuario: {SesionActual.NombreUsuario} - Rol: {SesionActual.Rol}";

            /// Control básico por rol
            //Con este codigo deshabilitamos un botón de prueba para el usuario cajero, por ejemplo que no pueda Registrar Cliente(ojo esto es solo prueba)
            switch (SesionActual.Rol)
            {
                case "Admin":
                    // todo habilitado
                    break;
                case "Cajero":
                    btnClientes.Enabled = false;
                    btnSalir.Enabled = false;
                    break;
                default:
                    btnClientes.Enabled = false;
                    btnSalir.Enabled = false;
                    break;

            }

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Usuario: {SesionActual.NombreUsuario} - Rol: {SesionActual.Rol}";

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();

        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambiarClave frm = new FrmCambiarClave();
            frm.ShowDialog();

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes();
            frm.ShowDialog();
        }
    }
}
