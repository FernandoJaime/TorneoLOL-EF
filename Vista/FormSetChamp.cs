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
    public partial class FormSetChamp : Form
    {
        private Jugador eljugador;
        public FormSetChamp(Jugador player)
        {
            InitializeComponent();
            eljugador = player;
        }

        // Validaciones.
        public bool CamposVacios()
        {
            if (txtNombreChamp.Text == "" || comboRol.Text == "")
            {
                return true;
            }
            return false;
        }
        private void txtNombreChamp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es una letra ni una tecla de control, cancelar el evento KeyPress para evitar que se ingrese el carácter.
                e.Handled = true;
                MessageBox.Show("No puedes ingresar numeros ni caracteres especiales en este campo.", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                MessageBox.Show("Debe completar todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Campeon campeon = new Campeon();
                campeon.Nombre = txtNombreChamp.Text;
                campeon.PuntosDeVida = (int)numVida.Value;
                campeon.DañoAtaque = (int)numDaño.Value;
                campeon.RolChamp = (Rol)comboRol.SelectedItem;
                campeon.AsignarValoresIniciales();
                eljugador.ChampAsociado = campeon;
                eljugador.ChampAsociado.IdRol = campeon.RolChamp.IdRol;
                if (ControladoraJugadores.Instancia.ExisteCampeon(eljugador.ChampAsociado) == false)
                {
                    var mensaje = ControladoraJugadores.Instancia.AgregarJugador(eljugador);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Ya existe un campeon con este nomnbre, cambielo!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void FormSetChamp_Load(object sender, EventArgs e)
        {
            CargarComborol();
        }
        private void CargarComborol()
        {
            comboRol.DataSource = null;
            comboRol.DataSource = ControladoraJugadores.Instancia.RecuperarRoles();
            comboRol.Name = "Nombre";
        }
        private void comboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Indice = comboRol.SelectedIndex;
            switch (Indice)
            {
                case 0:
                    lblVida.Text = "(700-1400)";
                    lblDaño.Text = "(300-400)";
                    numDaño.Minimum = 300;
                    numDaño.Maximum = 400;
                    numVida.Minimum = 700;
                    numVida.Maximum = 1400;
                    numDaño.Value = 350;
                    numVida.Value = 1050;
                    break;
                case 1:
                    lblVida.Text = "(1200-2100)";
                    lblDaño.Text = "(150-250)";
                    numDaño.Minimum = 150;
                    numDaño.Maximum = 250;
                    numVida.Minimum = 1200;
                    numVida.Maximum = 2100;
                    numDaño.Value = 200;
                    numVida.Value = 1650;
                    break;
                case 2:
                    lblVida.Text = "(850-1600)";
                    lblDaño.Text = "(200-300)";
                    numDaño.Minimum = 200;
                    numDaño.Maximum = 300;
                    numVida.Minimum = 850;
                    numVida.Maximum = 1600;
                    numDaño.Value = 250;
                    numVida.Value = 1250;
                    break;
                case 3:
                    lblVida.Text = "(1500-2500)";
                    lblDaño.Text = "(50-150)";
                    numDaño.Minimum = 50;
                    numDaño.Maximum = 150;
                    numVida.Minimum = 1500;
                    numVida.Maximum = 2500;
                    numDaño.Value = 100;
                    numVida.Value = 2000;
                    break;
                case 4:
                    lblVida.Text = "(1000-2000)";
                    lblDaño.Text = "(250-350)";
                    numDaño.Minimum = 250;
                    numDaño.Maximum = 350;
                    numVida.Minimum = 1000;
                    numVida.Maximum = 2000;
                    numDaño.Value = 300;
                    numVida.Value = 1500;
                    break;
            }
        }
    }
}