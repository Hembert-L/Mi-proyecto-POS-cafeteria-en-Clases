using System;
using ProyectoPOS_1CA_A.CapaEntidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Printing;

namespace ProyectoPOS_1CA_A.CapaPresentacion
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        public static List<Cliente> listaClientes = new List<Cliente>();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            if (!listaClientes.Any())
            {
                listaClientes.Add(new Cliente
                {
                    Id = 1,
                    Nombre = "Juan Perez",
                    Apellido = "Lopez",
                    Telefono = "72136177",
                    Estado = true
                });

                listaClientes.Add(new Cliente
                {
                    Id = 2,
                    Nombre = "Maria Gomez",
                    Apellido = "Ramirez",
                    Telefono = "72245188",
                    Estado = true
                });

                listaClientes.Add(new Cliente
                {
                    Id = 3,
                    Nombre = "Carlos Sanchez",
                    Apellido = "Diaz",
                    Telefono = "72354199",
                    Estado = true
                });
            }
            RefrescarGrid();
        }
        private void RefrescarGrid()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaClientes;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!long.TryParse(txtPhone.Text, out _))
            {
                MessageBox.Show("El número de teléfono debe contener solo dígitos.");
                return;
            }

            Regex soloLetras = new Regex("^[a-zA-Z]+$");

            if (!soloLetras.IsMatch(txtNombre.Text) || !soloLetras.IsMatch(txtApellido.Text))
            {
                MessageBox.Show("El nombre y apellido deben contener solo letras.");
                return;
            }

            // Crear objeto cliente y asignar Id incremental manualmente
            int nuevoId = listaClientes.Any() ? listaClientes.Max(x => x.Id) + 1 : 1;
            var c = new Cliente
            {
                Id = nuevoId,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtPhone.Text,
                Estado = chkEstado.Checked
            };

            // Agregar el cliente a la lista
            listaClientes.Add(c);
            RefrescarGrid();
            // Limpiar los campos de entrada
            LimpiarCampos();

        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtPhone.Clear();
            chkEstado.Checked = false;
            txtNombre.Focus();
            txtPhone.Focus();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow == null) return;

            // Cargar los datos del cliente seleccionado en los controles
            txtId.Text = dgvClientes.CurrentRow.Cells["Id"].Value.ToString();
            txtNombre.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();
            txtPhone.Text = dgvClientes.CurrentRow.Cells["Telefono"].Value.ToString();
            chkEstado.Checked = (bool)dgvClientes.CurrentRow.Cells["Estado"].Value;


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int Id))
            {
                MessageBox.Show("Por favor, seleccione un cliente válido para eliminar.");
                return;
            }
            var clienteAEliminar = listaClientes.FirstOrDefault(x => x.Id == Id);
            if (clienteAEliminar == null)
            {
                MessageBox.Show("Cliente no encontrado.");
                return;
            }

            if (MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listaClientes.Remove(clienteAEliminar);
                RefrescarGrid();
                LimpiarCampos();
            }
            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //valida que el Id sea entero
            if (!int.TryParse(txtId.Text, out int Id))
            {
                MessageBox.Show("Por favor, seleccione un cliente válido para editar.");
                return;
            }
            var clienteAEditar = listaClientes.FirstOrDefault(x => x.Id == Id);
            if (clienteAEditar == null)
            {
                MessageBox.Show("Cliente no encontrado.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            if (!long.TryParse(txtPhone.Text, out _))
            {
                MessageBox.Show("El número de teléfono debe contener solo dígitos.");
                return;
            }
            Regex soloLetras = new Regex("^[a-zA-Z]+$");
            if (!soloLetras.IsMatch(txtNombre.Text) || !soloLetras.IsMatch(txtApellido.Text))
            {
                MessageBox.Show("El nombre y apellido deben contener solo letras.");
                return;
            }
            // Actualizar los datos del cliente
            clienteAEditar.Nombre = txtNombre.Text;
            clienteAEditar.Apellido = txtApellido.Text;
            clienteAEditar.Telefono = txtPhone.Text;
            clienteAEditar.Estado = chkEstado.Checked;
            MessageBox.Show("Cliente actualizado correctamente.", "Éxito",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarGrid();
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea volver al menú principal?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow == null) return;

            // Cargar los datos del cliente seleccionado en los controles
            txtId.Text = dgvClientes.CurrentRow.Cells["Id"].Value.ToString();
            txtNombre.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();
            txtPhone.Text = dgvClientes.CurrentRow.Cells["Telefono"].Value.ToString();
            chkEstado.Checked = (bool)dgvClientes.CurrentRow.Cells["Estado"].Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}


    





