namespace Vista
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            var OpenJugadores = new FormJugadores();
            OpenJugadores.ShowDialog();
        }

        private void btnFinTorneo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            var OpenEquipos = new FormEquipos();
            OpenEquipos.ShowDialog();
        }

        private void btnSimulacion_Click(object sender, EventArgs e)
        {
            var simulacion = new FormSimular();
            simulacion.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormPArtidas frm = new FormPArtidas();
            frm.ShowDialog();
        }
    }
}