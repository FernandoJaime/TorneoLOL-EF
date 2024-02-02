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
    public partial class FormEquipo : Form
    {
        public FormEquipo()
        {
            InitializeComponent();
        }
        private void CargarCombosDeJugadores()
        {
            //ADC
            comboAdc.DataSource = null;
            comboAdc.DataSource = ControladoraJugadores.Instancia.RecuperarPorRol("Adc");
            comboAdc.Name = "Nickname";
            //JUNGLA
            comboJungla.DataSource = null;
            comboJungla.DataSource = ControladoraJugadores.Instancia.RecuperarPorRol("Jungla");
            comboJungla.Name = "Nickname";
            //MID
            comboMid.DataSource = null;
            comboMid.DataSource = ControladoraJugadores.Instancia.RecuperarPorRol("Mid");
            comboMid.Name = "Nickname";
            //SOPORTE
            comboSoporte.DataSource = null;
            comboSoporte.DataSource = ControladoraJugadores.Instancia.RecuperarPorRol("Soporte");
            comboSoporte.Name = "Nickname";
            //TOP
            comboTop.DataSource = null;
            comboTop.DataSource = ControladoraJugadores.Instancia.RecuperarPorRol("Top");
            comboTop.Name = "Nickname";
        }

        // Metodo para verificar que al inscribir equipos, no dejen campos vacios.
        public bool CamposVaciosEquipo()
        {
            if (comboAdc.Text == "" || comboSoporte.Text == "" || comboJungla.Text == "" || comboMid.Text == "" || comboTop.Text == "" || txtNombreEquipo.Text == "")
            {
                return true;
            }
            return false;
        }

        private void FormEquipo_Load(object sender, EventArgs e)
        {
            this.Text = "Inscripcion de equipo";
            CargarCombosDeJugadores();
        }

        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            if (CamposVaciosEquipo() == false)
            {
                var equipo1 = new Equipo();
                equipo1.Nombre = txtNombreEquipo.Text;

                var mensaje = ControladoraEquipos.Instancia.AgregarEquipo(equipo1);
                if (mensaje == "El equipo " + equipo1.Nombre + ", se ha agregado con éxito!")
                {
                    // Obtener jugadores seleccionados
                    var top = (Jugador)comboTop.SelectedItem;
                    var mid = (Jugador)comboMid.SelectedItem;
                    var adc = (Jugador)comboAdc.SelectedItem;
                    var jg = (Jugador)comboJungla.SelectedItem;
                    var supp = (Jugador)comboSoporte.SelectedItem;

                    // Asignar jugadores al equipo
                    equipo1.AgregarJugadores(top, mid, adc, supp, jg);

                    // Actualizar jugadores en la base de datos
                    ControladoraJugadores.Instancia.ActualizarEquipo(equipo1.ListaJugadoresDeEquipo);

                    // Asignar equipo a los jugadores
                    top.EquipoAsociado = equipo1;
                    mid.EquipoAsociado = equipo1;
                    adc.EquipoAsociado = equipo1;
                    jg.EquipoAsociado = equipo1;
                    supp.EquipoAsociado = equipo1;

                    // Actualizar jugadores en la base de datos nuevamente
                    ControladoraJugadores.Instancia.ActualizarEquipo(equipo1.ListaJugadoresDeEquipo);
                }
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                MessageBox.Show("Hay uno o más campos vacíos", "Incompleto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelarEquipo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
