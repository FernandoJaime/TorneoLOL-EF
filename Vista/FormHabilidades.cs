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
    public partial class FormHabilidades : Form
    {
        private Equipo equipo1;
        private Equipo equipo2;

        public FormHabilidades(Equipo equipo1, Equipo equipo2)
        {
            InitializeComponent();
            this.equipo1 = equipo1;
            this.equipo2 = equipo2;
        }

        private void LlenarCombos()
        {
            // TOP
            cmbTopE1.DataSource = null;
            cmbTopE1.DataSource = ControladoraPartidas.Instancia.RecuperarHabilidadTop();
            cmbTopE1.Name = "Nombre";
            cmbTopE2.DataSource = null;
            cmbTopE2.DataSource = ControladoraPartidas.Instancia.RecuperarHabilidadTop();
            cmbTopE2.Name = "Nombre";

            // ADC
            cmbAdcE1.DataSource = null;
            cmbAdcE1.DataSource = ControladoraPartidas.Instancia.RecuperarHabilidadAdc();
            cmbAdcE1.Name = "Nombre";
            cmbAdcE2.DataSource = null;
            cmbAdcE2.DataSource = ControladoraPartidas.Instancia.RecuperarHabilidadAdc();
            cmbAdcE2.Name = "Nombre";

            // MID
            cmbMidE1.DataSource = null;
            cmbMidE1.DataSource = ControladoraPartidas.Instancia.RecuperarHabilidadMid();
            cmbMidE1.Name = "Nombre";
            cmbMidE2.DataSource = null;
            cmbMidE2.DataSource = ControladoraPartidas.Instancia.RecuperarHabilidadMid();
            cmbMidE2.Name = "Nombre";

            // JUNGLA
            cmbJunglaE1.DataSource = null;
            cmbJunglaE1.DataSource = ControladoraPartidas.Instancia.RecuperarHabilidadJungla();
            cmbJunglaE1.Name = "Nombre";
            cmbJunglaE2.DataSource = null;
            cmbJunglaE2.DataSource = ControladoraPartidas.Instancia.RecuperarHabilidadJungla();
            cmbJunglaE2.Name = "Nombre";

            // SOPORTE
            cmbSoporteE1.DataSource = null;
            cmbSoporteE1.DataSource = ControladoraPartidas.Instancia.RecuperarHabilidadSoporte();
            cmbSoporteE1.Name = "Nombre";
            cmbSoporteE2.DataSource = null;
            cmbSoporteE2.DataSource = ControladoraPartidas.Instancia.RecuperarHabilidadSoporte();
            cmbSoporteE2.Name = "Nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidarCampos();

            var jungla1 = (Habilidad)cmbJunglaE1.SelectedItem;
            var jungla2 = (Habilidad)cmbJunglaE2.SelectedItem;
            var adc1 = (Habilidad)cmbAdcE1.SelectedItem;
            var adc2 = (Habilidad)cmbAdcE2.SelectedItem;
            var mid1 = (Habilidad)cmbMidE1.SelectedItem;
            var mid2 = (Habilidad)cmbMidE2.SelectedItem;
            var soporte1 = (Habilidad)cmbSoporteE1.SelectedItem;
            var soporte2 = (Habilidad)cmbSoporteE2.SelectedItem;
            var top1 = (Habilidad)cmbTopE1.SelectedItem;
            var top2 = (Habilidad)cmbTopE2.SelectedItem;

            List<Jugador> ListaTotalDeJugadores = new List<Jugador>();
            ListaTotalDeJugadores.AddRange(equipo1.ListaJugadoresDeEquipo);
            ListaTotalDeJugadores.AddRange(equipo2.ListaJugadoresDeEquipo);
            //ControladoraPartidas.Instancia.ActualizarHabilidades(ListaTotalDeJugadores);
            equipo1.TransformaryAsignarHabilidades(jungla1, adc1, soporte1, mid1, top1);
            equipo2.TransformaryAsignarHabilidades(jungla2, adc2, soporte2, mid2, top2);



            Close();
        }

        private void FormHabilidades_Load(object sender, EventArgs e)
        {
            this.Text = "Designar habilidades a cada jugador segun su campeon";
            LlenarCombos();
        }

        private bool ValidarCampos()
        {
            return new[]
            {
                cmbTopE1.Text, cmbTopE2.Text, cmbAdcE1.Text, cmbAdcE2.Text,
                cmbJunglaE1.Text, cmbJunglaE2.Text, cmbMidE1.Text, cmbMidE2.Text,
                cmbSoporteE1.Text, cmbSoporteE2.Text

            }.Any(string.IsNullOrEmpty);
        }
    }
}
