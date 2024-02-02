namespace Vista
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnJugadores = new Button();
            btnEquipos = new Button();
            btnSimulacion = new Button();
            btnHistorial = new Button();
            btnFinTorneo = new Button();
            SuspendLayout();
            // 
            // btnJugadores
            // 
            btnJugadores.BackColor = SystemColors.Menu;
            btnJugadores.FlatStyle = FlatStyle.Popup;
            btnJugadores.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnJugadores.Location = new Point(112, 99);
            btnJugadores.Margin = new Padding(4, 3, 4, 3);
            btnJugadores.Name = "btnJugadores";
            btnJugadores.Size = new Size(164, 37);
            btnJugadores.TabIndex = 47;
            btnJugadores.Text = "Jugadores";
            btnJugadores.UseVisualStyleBackColor = false;
            btnJugadores.Click += btnJugadores_Click;
            // 
            // btnEquipos
            // 
            btnEquipos.BackColor = SystemColors.Menu;
            btnEquipos.FlatStyle = FlatStyle.Popup;
            btnEquipos.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquipos.Location = new Point(310, 99);
            btnEquipos.Margin = new Padding(4, 3, 4, 3);
            btnEquipos.Name = "btnEquipos";
            btnEquipos.Size = new Size(164, 37);
            btnEquipos.TabIndex = 58;
            btnEquipos.Text = "Equipos";
            btnEquipos.UseVisualStyleBackColor = false;
            btnEquipos.Click += btnEquipos_Click;
            // 
            // btnSimulacion
            // 
            btnSimulacion.BackColor = SystemColors.Menu;
            btnSimulacion.FlatStyle = FlatStyle.Popup;
            btnSimulacion.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSimulacion.Location = new Point(112, 163);
            btnSimulacion.Margin = new Padding(4, 3, 4, 3);
            btnSimulacion.Name = "btnSimulacion";
            btnSimulacion.Size = new Size(164, 37);
            btnSimulacion.TabIndex = 59;
            btnSimulacion.Text = "Simulacion";
            btnSimulacion.UseVisualStyleBackColor = false;
            btnSimulacion.Click += btnSimulacion_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = SystemColors.Menu;
            btnHistorial.FlatStyle = FlatStyle.Popup;
            btnHistorial.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistorial.ForeColor = SystemColors.ControlText;
            btnHistorial.Location = new Point(310, 163);
            btnHistorial.Margin = new Padding(4, 3, 4, 3);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(164, 37);
            btnHistorial.TabIndex = 60;
            btnHistorial.Text = "Historial de partidas";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnFinTorneo
            // 
            btnFinTorneo.BackColor = Color.Transparent;
            btnFinTorneo.FlatStyle = FlatStyle.Popup;
            btnFinTorneo.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinTorneo.Location = new Point(247, 271);
            btnFinTorneo.Margin = new Padding(4, 3, 4, 3);
            btnFinTorneo.Name = "btnFinTorneo";
            btnFinTorneo.Size = new Size(78, 30);
            btnFinTorneo.TabIndex = 61;
            btnFinTorneo.Text = "Salir";
            btnFinTorneo.UseVisualStyleBackColor = false;
            btnFinTorneo.Click += btnFinTorneo_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            BackgroundImage = Properties.Resources.League;
            ClientSize = new Size(590, 313);
            ControlBox = false;
            Controls.Add(btnFinTorneo);
            Controls.Add(btnHistorial);
            Controls.Add(btnSimulacion);
            Controls.Add(btnEquipos);
            Controls.Add(btnJugadores);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormHome";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Torneo";
            ResumeLayout(false);
        }

        #endregion
        private Button btnJugadores;
        private Button btnEquipos;
        private Button btnSimulacion;
        private Button btnHistorial;
        private Button btnFinTorneo;
    }
}