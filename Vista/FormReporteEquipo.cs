using Controlador;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace Vista
{
    public partial class FormReporteEquipo : Form
    {

        private Equipo EquipodeReporte;
        public FormReporteEquipo(Equipo Equipito)
        {
            InitializeComponent();
            EquipodeReporte = Equipito;
        }
        public FormReporteEquipo()
        {
            InitializeComponent();
        }
        private void CargarDatosIniciales()
        {
            txtNombre.Text = EquipodeReporte.Nombre;
            numGanadas.Value = EquipodeReporte.Ganadas;
            numJugadas.Value = EquipodeReporte.PartidasJugadas;
            numPerdidas.Value = EquipodeReporte.Perdidas;
            numPuntuacion.Value = EquipodeReporte.Puntuacion;
        }
        private void ActualizarGrillaEquipo()
        {
            dgvJugadoresdeEquipo.DataSource = null;
            dgvJugadoresdeEquipo.DataSource = EquipodeReporte.ListaJugadoresDeEquipo;
        }
        private void ActualizarGrillaPartidas()
        {
            dgvHistorialdeEquipo.DataSource = null;
            dgvHistorialdeEquipo.DataSource = ControladoraPartidas.Instancia.RecuperarPartidasDeEquipo(EquipodeReporte);
        }
        private void FormReporteEquipo_Load(object sender, EventArgs e)
        {
            dgvHistorialdeEquipo.AutoGenerateColumns = false;
            dgvJugadoresdeEquipo.AutoGenerateColumns = false;
            ActualizarGrillaEquipo();
            CargarDatosIniciales();
            ActualizarGrillaPartidas();
        }

        private void btnGuardarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog Guardar = new SaveFileDialog();
                Guardar.FileName = DateTime.Now.ToString("ddMMyyyhhmmss") + ".pdf";
                string PaginaHTML_Texto = Properties.Resources.CodigoReporte.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NOMBRE_EQUIPO", EquipodeReporte.Nombre);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@GANADAS", EquipodeReporte.Ganadas.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@PERDIDAS", EquipodeReporte.Perdidas.ToString());
                string filasJug = string.Empty;
                string filasParti = string.Empty;

                foreach (DataGridViewRow row in dgvJugadoresdeEquipo.Rows)
                {
                    filasJug += "<tr>";
                    filasJug += "<td>" + row.Cells["Nombre"].Value.ToString() + "</td>";
                    filasJug += "<td>" + row.Cells["Edad"].Value.ToString() + "</td>";
                    filasJug += "<td>" + row.Cells["Nickname"].Value.ToString() + "</td>";
                    filasJug += "<td>" + row.Cells["Nacionalidad"].Value.ToString() + "</td>";
                    filasJug += "<td>" + row.Cells["VecesMVP"].Value.ToString() + "</td>";
                    filasJug += "<td>" + row.Cells["Campeon"].Value.ToString() + "</td>";
                    filasJug += "</tr>";
                }

                foreach (DataGridViewRow row in dgvHistorialdeEquipo.Rows)
                {
                    filasParti += "<tr>";
                    filasParti += "<td>" + row.Cells["CodigoPartida"].Value.ToString() + "</td>";
                    filasParti += "<td>" + row.Cells["Equipo1"].Value.ToString() + "</td>";
                    filasParti += "<td>" + row.Cells["Equipo2"].Value.ToString() + "</td>";
                    filasParti += "<td>" + row.Cells["Ganador"].Value.ToString() + "</td>";
                    filasParti += "<td>" + row.Cells["Duracion"].Value.ToString() + "</td>";
                    filasParti += "<td>" + row.Cells["JugadorMVP"].Value.ToString() + "</td>";
                    filasParti += "</tr>";
                }

                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS_JUGADORES", filasJug);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS_PARTIDAS", filasParti);

                if (Guardar.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(Guardar.FileName, FileMode.Create))
                    {
                        //Creamos un nuevo documento y lo definimos como PDF
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        // Agregamos la imagen del banner al documento
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Lolito, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        //img.SetAbsolutePosition(10, 10);
                        pdfDoc.Add(img);

                        //pdfDoc.Add(new Phrase("Hola Mundo"));
                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }

                }

                MessageBox.Show("Reporte generado y guardado con exito!", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
