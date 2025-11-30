using ProyectoPOS_1CA_A.CapaEntidades;
using ProyectoPOS_1CA_A.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoPOS_1CA_A.CapaPresentacion
{
    
    public partial class FrmCliente2 : Form


    {
        int clienteId = 0; //Variable para almacenar el ID del cliente
        ClienteBLL bll = new ClienteBLL();
        public FrmCliente2()
        {
            InitializeComponent();
        }

        private void FrmCliente2_Load(object sender, EventArgs e)
        {
            CargarDatos();
            Limpiar();

        }

        void Limpiar()
        {
            txtNombre.Clear();
            txtDui.Clear();
            txtBuscar.Clear();
            txtTelefono.Clear();
            chkEstado.Checked = true;
            txtCorreo.Clear();
            txtNombre.Focus();

            clienteId=0; //Reiniciar el ID del cliente 0= nuevo registro
        }

        public void CargarDatos()
        {
            dvgCliente2.DataSource = bll.Listar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dvgCliente2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                Cliente2 c = new Cliente2
                {
                    Id = clienteId,
                    Nombre = txtNombre.Text,
                    Dui = txtDui.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Estado = chkEstado.Checked
                };
                int id = bll.Guardar(c);
                MessageBox.Show("Cliente guardado con exito., ", "Notificación",MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDatos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dvgCliente2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            clienteId = Convert.ToInt32(dvgCliente2.CurrentRow.Cells["Id"].Value);
            txtNombre.Text = dvgCliente2.CurrentRow.Cells["Nombre"].Value.ToString();
            txtDui.Text = dvgCliente2.CurrentRow.Cells["Dui"].Value.ToString();
            txtTelefono.Text = dvgCliente2.CurrentRow.Cells["Telefono"].Value.ToString();
            txtCorreo.Text = dvgCliente2.CurrentRow.Cells["Correo"].Value.ToString();
            chkEstado.Checked = Convert.ToBoolean(dvgCliente2.CurrentRow.Cells["Estado"].Value);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteId == 0)
            {



                MessageBox.Show("Seleccione un cliente para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
               
            }

            if (MessageBox.Show("¿Esta seguro de eliminar el cliente seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            {
                bll.Eliminar(clienteId);
                CargarDatos();
                Limpiar();
            }
        }

        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dvgCliente2.DataSource = bll.Buscar(txtBuscar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
