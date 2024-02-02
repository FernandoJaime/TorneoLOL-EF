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
    public partial class FormJugadores : Form
    {
        public FormJugadores()
        {
            InitializeComponent();
        }
        private void CargarGrilla()
        {
            dgvJugadores.DataSource = null;
            dgvJugadores.DataSource = ControladoraJugadores.Instancia.RecuperarJugadores();
        }
        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            FormJugador formJugador = new FormJugador();
            formJugador.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvJugadores.CurrentRow != null)
            {
                var JugadorAEliminar = (Jugador)dgvJugadores.CurrentRow.DataBoundItem;
                if (!JugadorAEliminar.TieneEquipo)
                {
                    var mensaje = ControladoraJugadores.Instancia.EliminarJugador(JugadorAEliminar);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lo sentimos el Jugador que desea eliminar pertenece al equipo " + JugadorAEliminar.EquipoAsociado.Nombre);
                }
            }
            else
            {
                MessageBox.Show("Lo sentimos debe seleccionar una fila");
            }
            CargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvJugadores.CurrentRow != null)
            {
                var JugadoraModi = (Jugador)dgvJugadores.CurrentRow.DataBoundItem;
                FormJugador Formulario = new FormJugador(JugadoraModi);
                Formulario.ShowDialog();
                CargarGrilla();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormJugadores_Load(object sender, EventArgs e)
        {
            dgvJugadores.AutoGenerateColumns = false;
            CargarGrilla();
        }
    }
}