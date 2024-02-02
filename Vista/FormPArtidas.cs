using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormPArtidas : Form
    {
        public FormPArtidas()
        {
            InitializeComponent();
        }
        private void ActualizarGrilla()
        {
            dgvPartidas.DataSource = null;
            dgvPartidas.DataSource = ControladoraPartidas.Instancia.RecuperarPartidasConDetalles();
        }
        private void FormPArtidas_Load(object sender, EventArgs e)
        {
            dgvPartidas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
