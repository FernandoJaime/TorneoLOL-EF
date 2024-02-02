namespace Vista
{
    partial class FormEquipos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            dgvEquipos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Partidas_Jugadas = new DataGridViewTextBoxColumn();
            Victorias = new DataGridViewTextBoxColumn();
            Perdidas = new DataGridViewTextBoxColumn();
            Puntuacion = new DataGridViewTextBoxColumn();
            btnAgregarJugador = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            btnReporte = new Button();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // dgvEquipos
            // 
            dgvEquipos.AllowUserToAddRows = false;
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Partidas_Jugadas, Victorias, Perdidas, Puntuacion });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvEquipos.DefaultCellStyle = dataGridViewCellStyle11;
            dgvEquipos.Location = new Point(13, 69);
            dgvEquipos.Margin = new Padding(4, 3, 4, 3);
            dgvEquipos.MultiSelect = false;
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvEquipos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvEquipos.RowHeadersVisible = false;
            dgvEquipos.RowTemplate.Height = 25;
            dgvEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipos.Size = new Size(776, 390);
            dgvEquipos.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Partidas_Jugadas
            // 
            Partidas_Jugadas.DataPropertyName = "PartidasJugadas";
            Partidas_Jugadas.HeaderText = "Partidas_Jugadas";
            Partidas_Jugadas.Name = "Partidas_Jugadas";
            Partidas_Jugadas.ReadOnly = true;
            // 
            // Victorias
            // 
            Victorias.DataPropertyName = "Ganadas";
            Victorias.HeaderText = "Victorias";
            Victorias.Name = "Victorias";
            Victorias.ReadOnly = true;
            // 
            // Perdidas
            // 
            Perdidas.DataPropertyName = "Perdidas";
            Perdidas.HeaderText = "Derrotas";
            Perdidas.Name = "Perdidas";
            Perdidas.ReadOnly = true;
            // 
            // Puntuacion
            // 
            Puntuacion.DataPropertyName = "Puntuacion";
            Puntuacion.HeaderText = "Puntuacion";
            Puntuacion.Name = "Puntuacion";
            Puntuacion.ReadOnly = true;
            // 
            // btnAgregarJugador
            // 
            btnAgregarJugador.FlatStyle = FlatStyle.Popup;
            btnAgregarJugador.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarJugador.Location = new Point(13, 474);
            btnAgregarJugador.Margin = new Padding(4, 3, 4, 3);
            btnAgregarJugador.Name = "btnAgregarJugador";
            btnAgregarJugador.Size = new Size(86, 30);
            btnAgregarJugador.TabIndex = 7;
            btnAgregarJugador.Text = "Agregar";
            btnAgregarJugador.UseVisualStyleBackColor = true;
            btnAgregarJugador.Click += btnAgregarJugador_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(107, 474);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 30);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Transparent;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(701, 474);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 30);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnReporte
            // 
            btnReporte.FlatStyle = FlatStyle.Popup;
            btnReporte.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReporte.Location = new Point(200, 474);
            btnReporte.Name = "btnReporte";
            btnReporte.RightToLeft = RightToLeft.No;
            btnReporte.Size = new Size(86, 30);
            btnReporte.TabIndex = 11;
            btnReporte.Text = "Ver reporte";
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += btnReporte_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(94, 20);
            label7.Name = "label7";
            label7.Size = new Size(71, 23);
            label7.TabIndex = 20;
            label7.Text = "Equipos";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.BackgroundImage = Properties.Resources.Lolito;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(13, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 60);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = false;
            // 
            // FormEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 521);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(btnReporte);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregarJugador);
            Controls.Add(dgvEquipos);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormEquipos";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormEquipos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEquipos;
        private Button btnAgregarJugador;
        private Button btnEliminar;
        private Button btnVolver;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Partidas_Jugadas;
        private DataGridViewTextBoxColumn Victorias;
        private DataGridViewTextBoxColumn Perdidas;
        private DataGridViewTextBoxColumn Puntuacion;
        private Button btnReporte;
        private Label label7;
        private Button button1;
    }
}