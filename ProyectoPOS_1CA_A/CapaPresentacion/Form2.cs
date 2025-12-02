using iTextSharp.text;
using iTextSharp.text.pdf;
using ProyectoPOS_1CA_A.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace ProyectoPOS_1CA_A.CapaPresentacion
{
    public partial class Form2 : Form


    {

        int IdVentaCargada = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarUltimaVenta();
        }
        private void CargarUltimaVenta()
        {
            using (SqlConnection cn = new SqlConnection(Conexion.cadena))
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT TOP 1 Id FROM Venta ORDER BY Id DESC", cn);

                IdVentaCargada = Convert.ToInt32(cmd.ExecuteScalar());
            }
            CargarDatosVenta();
            CargarDetalleVenta();
        }
        private void CargarDatosVenta()
        {
            using (SqlConnection cn = new SqlConnection(Conexion.cadena))
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand(@"
                    SELECT 
                        v.Id AS NumeroVenta,
                        v.Fecha,
                        c.Nombre AS Cliente,
                        tp.Nombre AS TipoPago,
                        v.MontoTotal
                    FROM Venta v
                    INNER JOIN Cliente c ON c.Id = v.Id_Cliente
                    INNER JOIN TipoPago tp ON tp.Id = v.Id_TipoPago
                    WHERE v.Id = @IdVenta", cn);

                cmd.Parameters.AddWithValue("@IdVenta", IdVentaCargada);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtNumeroFactura.Text = dr["NumeroVenta"].ToString();
                    txtFecha.Text = Convert.ToDateTime(dr["Fecha"]).ToString("dd/MM/yyyy hh:mm tt");
                    txtCliente.Text = dr["Cliente"].ToString();
                    txtTipoPago.Text = dr["TipoPago"].ToString();
                    txtTotal.Text = "$" + dr["MontoTotal"].ToString();
                }


            }
        }
        private void CargarDetalleVenta()
        {
            using (SqlConnection cn = new SqlConnection(Conexion.cadena))
            {
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        p.Nombre AS Producto,
                        dv.Cantidad,
                        dv.PrecioUnitario,
                        dv.SubTotal
                    FROM DetalleVenta dv
                    INNER JOIN Producto p ON p.Id = dv.Id_Producto
                    WHERE dv.Id_Venta = @IdVenta", cn);

                da.SelectCommand.Parameters.AddWithValue("@IdVenta", IdVentaCargada);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDetalle.DataSource = dt;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = $"Factura_{txtNumeroFactura.Text}.pdf";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));
                    doc.Open();

                    // ---------- TÍTULO ----------
                    Paragraph titulo = new Paragraph("CAFETERÍA - FACTURA DE VENTA\n\n",
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titulo);

                    // ---------- DATOS GENERALES ----------
                    PdfPTable tablaDatos = new PdfPTable(2);
                    tablaDatos.WidthPercentage = 100;

                    tablaDatos.AddCell("Número de Venta:");
                    tablaDatos.AddCell(txtNumeroFactura.Text);

                    tablaDatos.AddCell("Fecha:");
                    tablaDatos.AddCell(txtFecha.Text);

                    tablaDatos.AddCell("Cliente:");
                    tablaDatos.AddCell(txtCliente.Text);

                    tablaDatos.AddCell("Tipo Pago:");
                    tablaDatos.AddCell(txtTipoPago.Text);

                    doc.Add(tablaDatos);
                    doc.Add(new Paragraph("\n"));

                    // ---------- DETALLE ----------
                    PdfPTable tabla = new PdfPTable(4);
                    tabla.WidthPercentage = 100;

                    tabla.AddCell("Producto");
                    tabla.AddCell("Cantidad");
                    tabla.AddCell("Precio Unitario");
                    tabla.AddCell("Subtotal");

                    foreach (DataGridViewRow row in dgvDetalle.Rows)
                    {
                        tabla.AddCell(row.Cells["Producto"].Value.ToString());
                        tabla.AddCell(row.Cells["Cantidad"].Value.ToString());
                        tabla.AddCell(row.Cells["PrecioUnitario"].Value.ToString());
                        tabla.AddCell(row.Cells["Subtotal"].Value.ToString());
                    }

                    doc.Add(tabla);
                    doc.Add(new Paragraph("\n"));

                    // ---------- TOTAL ----------
                    Paragraph total = new Paragraph(
                        $"TOTAL: ${lblTotal.Text}",
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)
                    );

                    total.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(total);

                    doc.Close();

                    MessageBox.Show("Factura generada con éxito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
