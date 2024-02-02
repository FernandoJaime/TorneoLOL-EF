namespace Vista
{
    partial class FormPArtidas
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
            dgvPartidas = new DataGridView();
            Equipo1 = new DataGridViewTextBoxColumn();
            Equipo2 = new DataGridViewTextBoxColumn();
            CodigoPartida = new DataGridViewTextBoxColumn();
            Ganador = new DataGridViewTextBoxColumn();
            Mvp = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPartidas).BeginInit();
            SuspendLayout();
            // 
            // dgvPartidas
            // 
            dgvPartidas.AllowUserToAddRows = false;
            dgvPartidas.AllowUserToDeleteRows = false;
            dgvPartidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPartidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidas.Columns.AddRange(new DataGridViewColumn[] { Equipo1, Equipo2, CodigoPartida, Ganador, Mvp, Duracion });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPartidas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPartidas.Location = new Point(12, 69);
            dgvPartidas.MultiSelect = false;
            dgvPartidas.Name = "dgvPartidas";
            dgvPartidas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPartidas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPartidas.RowHeadersVisible = false;
            dgvPartidas.RowTemplate.Height = 25;
            dgvPartidas.Size = new Size(776, 338);
            dgvPartidas.TabIndex = 0;
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
            // CodigoPartida
            // 
            CodigoPartida.DataPropertyName = "CodigoPartida";
            CodigoPartida.HeaderText = "Codigo de Partida";
            CodigoPartida.Name = "CodigoPartida";
            CodigoPartida.ReadOnly = true;
            // 
            // Ganador
            // 
            Ganador.DataPropertyName = "Ganador";
            Ganador.HeaderText = "Ganador";
            Ganador.Name = "Ganador";
            Ganador.ReadOnly = true;
            // 
            // Mvp
            // 
            Mvp.DataPropertyName = "JugadorMVP";
            Mvp.HeaderText = "JugadorMVP";
            Mvp.Name = "Mvp";
            Mvp.ReadOnly = true;
            // 
            // Duracion
            // 
            Duracion.DataPropertyName = "Duracion";
            Duracion.HeaderText = "Duracion";
            Duracion.Name = "Duracion";
            Duracion.ReadOnly = true;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Transparent;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(713, 422);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 29);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(93, 20);
            label7.Name = "label7";
            label7.Size = new Size(74, 23);
            label7.TabIndex = 22;
            label7.Text = "Partidas";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.BackgroundImage = Properties.Resources.Lolito;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(12, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 60);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = false;
            // 
            // FormPArtidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 462);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(btnVolver);
            Controls.Add(dgvPartidas);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormPArtidas";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormPArtidas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPartidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPartidas;
        private Button btnVolver;
        private DataGridViewTextBoxColumn Equipo1;
        private DataGridViewTextBoxColumn Equipo2;
        private DataGridViewTextBoxColumn CodigoPartida;
        private DataGridViewTextBoxColumn Ganador;
        private DataGridViewTextBoxColumn Mvp;
        private DataGridViewTextBoxColumn Duracion;
        private Label label7;
        private Button button1;
    }
}