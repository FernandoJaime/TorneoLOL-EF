namespace Vista
{
    partial class FormReporteEquipo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            txtNombre = new TextBox();
            numJugadas = new NumericUpDown();
            numPerdidas = new NumericUpDown();
            numPuntuacion = new NumericUpDown();
            numGanadas = new NumericUpDown();
            dgvHistorialdeEquipo = new DataGridView();
            CodigoPartida = new DataGridViewTextBoxColumn();
            JugadorMVP = new DataGridViewTextBoxColumn();
            Equipo1 = new DataGridViewTextBoxColumn();
            Equipo2 = new DataGridViewTextBoxColumn();
            Ganador = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            dgvJugadoresdeEquipo = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Nickname = new DataGridViewTextBoxColumn();
            Nacionalidad = new DataGridViewTextBoxColumn();
            VecesMvp = new DataGridViewTextBoxColumn();
            Campeon = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnVolver = new Button();
            btnGuardarReporte = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numJugadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPerdidas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPuntuacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGanadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialdeEquipo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvJugadoresdeEquipo).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(184, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // numJugadas
            // 
            numJugadas.Enabled = false;
            numJugadas.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numJugadas.Location = new Point(395, 22);
            numJugadas.Name = "numJugadas";
            numJugadas.ReadOnly = true;
            numJugadas.Size = new Size(120, 23);
            numJugadas.TabIndex = 1;
            // 
            // numPerdidas
            // 
            numPerdidas.Enabled = false;
            numPerdidas.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numPerdidas.Location = new Point(615, 78);
            numPerdidas.Name = "numPerdidas";
            numPerdidas.ReadOnly = true;
            numPerdidas.Size = new Size(120, 23);
            numPerdidas.TabIndex = 2;
            // 
            // numPuntuacion
            // 
            numPuntuacion.Enabled = false;
            numPuntuacion.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numPuntuacion.Location = new Point(395, 79);
            numPuntuacion.Name = "numPuntuacion";
            numPuntuacion.ReadOnly = true;
            numPuntuacion.Size = new Size(120, 23);
            numPuntuacion.TabIndex = 3;
            // 
            // numGanadas
            // 
            numGanadas.Enabled = false;
            numGanadas.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numGanadas.Location = new Point(615, 22);
            numGanadas.Name = "numGanadas";
            numGanadas.ReadOnly = true;
            numGanadas.Size = new Size(120, 23);
            numGanadas.TabIndex = 4;
            // 
            // dgvHistorialdeEquipo
            // 
            dgvHistorialdeEquipo.AccessibleRole = AccessibleRole.None;
            dgvHistorialdeEquipo.AllowUserToAddRows = false;
            dgvHistorialdeEquipo.AllowUserToDeleteRows = false;
            dgvHistorialdeEquipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistorialdeEquipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorialdeEquipo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialdeEquipo.Columns.AddRange(new DataGridViewColumn[] { CodigoPartida, JugadorMVP, Equipo1, Equipo2, Ganador, Duracion });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistorialdeEquipo.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorialdeEquipo.Location = new Point(495, 159);
            dgvHistorialdeEquipo.MultiSelect = false;
            dgvHistorialdeEquipo.Name = "dgvHistorialdeEquipo";
            dgvHistorialdeEquipo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHistorialdeEquipo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHistorialdeEquipo.RowTemplate.Height = 25;
            dgvHistorialdeEquipo.Size = new Size(519, 271);
            dgvHistorialdeEquipo.TabIndex = 5;
            // 
            // CodigoPartida
            // 
            CodigoPartida.DataPropertyName = "CodigoPartida";
            CodigoPartida.HeaderText = "CodigoDePartida";
            CodigoPartida.Name = "CodigoPartida";
            CodigoPartida.ReadOnly = true;
            // 
            // JugadorMVP
            // 
            JugadorMVP.DataPropertyName = "JugadorMVP";
            JugadorMVP.HeaderText = "JugadorMVP";
            JugadorMVP.Name = "JugadorMVP";
            JugadorMVP.ReadOnly = true;
            // 
            // Equipo1
            // 
            Equipo1.DataPropertyName = "Equipo_1";
            Equipo1.HeaderText = "Equipo 1";
            Equipo1.Name = "Equipo1";
            Equipo1.ReadOnly = true;
            // 
            // Equipo2
            // 
            Equipo2.DataPropertyName = "Equipo_2";
            Equipo2.HeaderText = "Equipo 2";
            Equipo2.Name = "Equipo2";
            Equipo2.ReadOnly = true;
            // 
            // Ganador
            // 
            Ganador.DataPropertyName = "Ganador";
            Ganador.HeaderText = "Ganador";
            Ganador.Name = "Ganador";
            Ganador.ReadOnly = true;
            // 
            // Duracion
            // 
            Duracion.DataPropertyName = "Duracion";
            Duracion.HeaderText = "Duracion";
            Duracion.Name = "Duracion";
            Duracion.ReadOnly = true;
            // 
            // dgvJugadoresdeEquipo
            // 
            dgvJugadoresdeEquipo.AccessibleRole = AccessibleRole.None;
            dgvJugadoresdeEquipo.AllowUserToAddRows = false;
            dgvJugadoresdeEquipo.AllowUserToDeleteRows = false;
            dgvJugadoresdeEquipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvJugadoresdeEquipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvJugadoresdeEquipo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadoresdeEquipo.Columns.AddRange(new DataGridViewColumn[] { Nombre, Edad, Nickname, Nacionalidad, VecesMvp, Campeon });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvJugadoresdeEquipo.DefaultCellStyle = dataGridViewCellStyle5;
            dgvJugadoresdeEquipo.Location = new Point(5, 160);
            dgvJugadoresdeEquipo.MultiSelect = false;
            dgvJugadoresdeEquipo.Name = "dgvJugadoresdeEquipo";
            dgvJugadoresdeEquipo.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvJugadoresdeEquipo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvJugadoresdeEquipo.RowTemplate.Height = 25;
            dgvJugadoresdeEquipo.Size = new Size(484, 271);
            dgvJugadoresdeEquipo.TabIndex = 6;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Edad
            // 
            Edad.DataPropertyName = "Edad";
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            // 
            // Nickname
            // 
            Nickname.DataPropertyName = "Nickname";
            Nickname.HeaderText = "Nickname";
            Nickname.Name = "Nickname";
            Nickname.ReadOnly = true;
            // 
            // Nacionalidad
            // 
            Nacionalidad.DataPropertyName = "Nacionalidad";
            Nacionalidad.HeaderText = "Nacionalidad";
            Nacionalidad.Name = "Nacionalidad";
            Nacionalidad.ReadOnly = true;
            // 
            // VecesMvp
            // 
            VecesMvp.DataPropertyName = "VecesMVP";
            VecesMvp.HeaderText = "VecesMvp";
            VecesMvp.Name = "VecesMvp";
            VecesMvp.ReadOnly = true;
            // 
            // Campeon
            // 
            Campeon.DataPropertyName = "ChampAsociado";
            Campeon.HeaderText = "Campeon";
            Campeon.Name = "Campeon";
            Campeon.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(549, 81);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 7;
            label1.Text = "Perdidas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(549, 26);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 8;
            label2.Text = "Ganadas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(319, 81);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 9;
            label3.Text = "Puntuación";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(327, 26);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 10;
            label4.Text = "Jugadas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(119, 60);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 11;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(495, 136);
            label6.Name = "label6";
            label6.Size = new Size(134, 19);
            label6.TabIndex = 12;
            label6.Text = "Partidas del equipo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(5, 136);
            label7.Name = "label7";
            label7.Size = new Size(146, 19);
            label7.TabIndex = 13;
            label7.Text = "Jugadores del equipo";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Transparent;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(5, 442);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(68, 31);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardarReporte
            // 
            btnGuardarReporte.BackColor = SystemColors.Menu;
            btnGuardarReporte.FlatStyle = FlatStyle.Popup;
            btnGuardarReporte.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarReporte.Location = new Point(885, 441);
            btnGuardarReporte.Name = "btnGuardarReporte";
            btnGuardarReporte.Size = new Size(123, 32);
            btnGuardarReporte.TabIndex = 15;
            btnGuardarReporte.Text = "Guardar Reporte";
            btnGuardarReporte.UseVisualStyleBackColor = false;
            btnGuardarReporte.Click += btnGuardarReporte_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.BackgroundImage = Properties.Resources.Lolito;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(933, 8);
            button1.Name = "button1";
            button1.Size = new Size(81, 67);
            button1.TabIndex = 16;
            button1.UseVisualStyleBackColor = false;
            // 
            // FormReporteEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1020, 481);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(btnGuardarReporte);
            Controls.Add(btnVolver);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvJugadoresdeEquipo);
            Controls.Add(dgvHistorialdeEquipo);
            Controls.Add(numGanadas);
            Controls.Add(numPuntuacion);
            Controls.Add(numPerdidas);
            Controls.Add(numJugadas);
            Controls.Add(txtNombre);
            Name = "FormReporteEquipo";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormReporteEquipo_Load;
            ((System.ComponentModel.ISupportInitialize)numJugadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPerdidas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPuntuacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGanadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialdeEquipo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvJugadoresdeEquipo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private NumericUpDown numJugadas;
        private NumericUpDown numPerdidas;
        private NumericUpDown numPuntuacion;
        private NumericUpDown numGanadas;
        private DataGridView dgvHistorialdeEquipo;
        private DataGridView dgvJugadoresdeEquipo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Nickname;
        private DataGridViewTextBoxColumn Nacionalidad;
        private DataGridViewTextBoxColumn VecesMvp;
        private DataGridViewTextBoxColumn Campeon;
        private Button btnVolver;
        private Button btnGuardarReporte;
        private DataGridViewTextBoxColumn CodigoPartida;
        private DataGridViewTextBoxColumn JugadorMVP;
        private DataGridViewTextBoxColumn Equipo1;
        private DataGridViewTextBoxColumn Equipo2;
        private DataGridViewTextBoxColumn Ganador;
        private DataGridViewTextBoxColumn Duracion;
        private Button button1;
    }
}