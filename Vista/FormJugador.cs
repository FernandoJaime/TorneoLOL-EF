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
    public partial class FormJugador : Form
    {
        private bool Modificar = false;
        private Jugador Jugador1;
        private Jugador JugadorModi;
        public FormJugador()
        {
            InitializeComponent();
        }
        public FormJugador(Jugador jugador1)
        {
            InitializeComponent();
            this.JugadorModi = jugador1;
            Modificar = true;
        }

        // Validaciones.
        public bool CamposVaciosJugador()
        {
            if (txtEdad.Text == "" || txtNickname.Text == "" || txtNombreJugador.Text == "" || comboHabilidad.Text == "" || comboNacionalidad.Text == "")
            {
                return true;
            }
            return false;
        }
        public bool VerificarEdad()
        {
            int ed = int.Parse(txtEdad.Text);
            if (ed > 15 && ed < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es un número ni una tecla de control, cancelar el evento KeyPress para evitar que se ingrese el carácter.
                e.Handled = true;
                MessageBox.Show("No puedes ingresar letras en este campo", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtNombreJugador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es una letra ni una tecla de control, cancelar el evento KeyPress para evitar que se ingrese el carácter.
                e.Handled = true;
                MessageBox.Show("No puedes ingresar numeros ni caracteres especiales en este campo.", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Form Load.
        private void FormJugador_Load(object sender, EventArgs e)
        {
            if (Modificar)
            {
                this.Text = "Modificar Jugador";
                txtNickname.Enabled = false;
                txtNombreJugador.Text = JugadorModi.Nombre;
                txtEdad.Text = JugadorModi.Edad.ToString();
                txtNickname.Text = JugadorModi.Nickname;
                comboHabilidad.Text = JugadorModi.Experiencia;
                comboNacionalidad.Text = JugadorModi.Nacionalidad;
                lblCampeon.Text = "Campeon del jugador: " + JugadorModi.ChampAsociado.RolChamp.Nombre;
            }
            else this.Text = "Agregar Jugador";
        }

        // Boton guardar.
        private void btnGuardarJugador_Click(object sender, EventArgs e)
        {
            if (CamposVaciosJugador())
            {
                MessageBox.Show("Debe completar todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!VerificarEdad())
            {
                MessageBox.Show("Lo sentimos el jugador no cuenta con la edad para participar del torneo..", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (Modificar)
            {
                JugadorModi.Nickname = txtNickname.Text;
                JugadorModi.Nacionalidad = comboNacionalidad.Text;
                JugadorModi.Edad = int.Parse(txtEdad.Text);
                JugadorModi.Nombre = txtNombreJugador.Text;
                JugadorModi.Experiencia = comboHabilidad.Text;
                var mensaje = ControladoraJugadores.Instancia.ModificarJugador(JugadorModi);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {

                Jugador1 = new Jugador();
                Jugador1.Nickname = txtNickname.Text;
                Jugador1.Nacionalidad = comboNacionalidad.Text;
                Jugador1.Edad = int.Parse(txtEdad.Text);
                Jugador1.Nombre = txtNombreJugador.Text;
                Jugador1.Experiencia = comboHabilidad.Text;
                ControladoraJugadores.Instancia.AgregarJugador(Jugador1);
                if (ControladoraJugadores.Instancia.ExisteJugador(Jugador1))
                {
                    MessageBox.Show("Ya existe un jugador con este nickname.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    AbrirForm(Jugador1);
                    Close();
                }
            }

        }

        // Metodo para abrir el form de setear campeon.
        private void AbrirForm(Jugador jugador)
        {
            FormSetChamp formSetear = new FormSetChamp(jugador);
            formSetear.ShowDialog();
        }

        // Boton cancelar.
        private void btnCancelarJugador_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}