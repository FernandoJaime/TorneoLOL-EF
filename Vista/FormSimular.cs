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
    public partial class FormSimular : Form
    {
        public FormSimular()
        {
            InitializeComponent();
        }
        private bool ValidarIgualdad()
        {
            if (comboEquipo1.Text == comboEquipo2.Text)
            {
                return true;
            }
            return false;
        }
        private void LlenarCombos()
        {
            // Equipo1
            comboEquipo1.DataSource = null;
            comboEquipo1.DataSource = ControladoraEquipos.Instancia.RecuperarEquiposConDetalles();
            comboEquipo1.Name = "Nombre";

            // Equipo2
            comboEquipo2.DataSource = null;
            comboEquipo2.DataSource = ControladoraEquipos.Instancia.RecuperarEquiposConDetalles();
            comboEquipo2.Name = "Nombre";
        }
        private void btnDesiganr_Click(object sender, EventArgs e)
        {
            if (!ValidarIgualdad())
            {
                comboEquipo1.Enabled = false;
                comboEquipo2.Enabled = false;
                var Equipo1 = (Equipo)comboEquipo1.SelectedItem;
                var Equipo2 = (Equipo)comboEquipo2.SelectedItem;
                FormHabilidades Frm = new FormHabilidades(Equipo1, Equipo2);
                Frm.ShowDialog();
                btnSimularPartida.Enabled = true;
                btnDesiganr.Enabled = false;
                btnVolver.Enabled = false;
            }
            else
            {
                MessageBox.Show("Los equipos enfrentados son los mismos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormSimular_Load(object sender, EventArgs e)
        {
            comboEquipo1.Enabled = true;
            comboEquipo2.Enabled = true;
            LlenarCombos();
            btnDesiganr.Enabled = true;
            btnSimularPartida.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSimularPartida_Click(object sender, EventArgs e)
        {

            if (!ValidarIgualdad())
            {
                Partida Partida = new Partida();
                Partida.Equipo_1 = ControladoraEquipos.Instancia.RecuperarEquiposConDetalles().FirstOrDefault(x => x.Nombre == comboEquipo1.Text);
                Partida.Equipo_2 = ControladoraEquipos.Instancia.RecuperarEquiposConDetalles().FirstOrDefault(x => x.Nombre == comboEquipo2.Text);
                Partida.SimularPartida();
                var mensaje = ControladoraPartidas.Instancia.AgregarPartida(Partida);
                lbGanador.Text = "El ganador de la partida es: " + Partida.Ganador.Nombre;
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los equipos enfrentados son los mismos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnSimularPartida.Enabled = false;
            btnDesiganr.Enabled = false;
            btnVolver.Enabled = true;
        }
    }
}