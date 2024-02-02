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

namespace Vista
{
    public partial class FormEquipos : Form
    {
        public FormEquipos()
        {
            InitializeComponent();
        }

        // Metodo para asignarle los datos al dgv.
        public void ArmarGrillaEquipos()
        {
            dgvEquipos.DataSource = null;
            dgvEquipos.DataSource = ControladoraEquipos.Instancia.RecuperarEquiposConDetalles();
            dgvEquipos.Refresh();
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            FormEquipo formEquipo = new FormEquipo();
            formEquipo.ShowDialog();
            ArmarGrillaEquipos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.CurrentRow != null)
            {
                var EquipoEliminar = (Equipo)dgvEquipos.CurrentRow.DataBoundItem;

                var mensaje = ControladoraEquipos.Instancia.EliminarEquipo(EquipoEliminar);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ArmarGrillaEquipos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar a un equipo de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormEquipos_Load(object sender, EventArgs e)
        {
            dgvEquipos.AutoGenerateColumns = false;
            ArmarGrillaEquipos();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.CurrentRow is not null)
            {
                var EquipodeReporte = (Equipo)dgvEquipos.CurrentRow.DataBoundItem;
                FormReporteEquipo frm = new FormReporteEquipo(EquipodeReporte);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("debe seleccionar un equipo para el reporte");
            }
        }
    }
}
