namespace Vista
{
    partial class FormJugadores
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnAgregarJugador = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            btnModificar = new Button();
            dgvJugadores = new DataGridView();
            NickName = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Nacionalidad = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Tiene_Equipo = new DataGridViewCheckBoxColumn();
            Experiencia = new DataGridViewTextBoxColumn();
            Equipo = new DataGridViewTextBoxColumn();
            Veces_MVP = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarJugador
            // 
            btnAgregarJugador.FlatStyle = FlatStyle.Popup;
            btnAgregarJugador.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarJugador.Location = new Point(13, 464);
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
            btnEliminar.Location = new Point(107, 464);
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
            btnVolver.Location = new Point(773, 464);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 30);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(201, 464);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 30);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // dgvJugadores
            // 
            dgvJugadores.AccessibleRole = AccessibleRole.None;
            dgvJugadores.AllowUserToAddRows = false;
            dgvJugadores.AllowUserToDeleteRows = false;
            dgvJugadores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvJugadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Columns.AddRange(new DataGridViewColumn[] { NickName, Nombre, Nacionalidad, Edad, Tiene_Equipo, Experiencia, Equipo, Veces_MVP });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvJugadores.DefaultCellStyle = dataGridViewCellStyle5;
            dgvJugadores.Location = new Point(12, 72);
            dgvJugadores.Margin = new Padding(4, 3, 4, 3);
            dgvJugadores.MultiSelect = false;
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvJugadores.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvJugadores.RowHeadersVisible = false;
            dgvJugadores.RowTemplate.Height = 25;
            dgvJugadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJugadores.Size = new Size(848, 376);
            dgvJugadores.TabIndex = 0;
            // 
            // NickName
            // 
            NickName.DataPropertyName = "Nickname";
            NickName.HeaderText = "NickName";
            NickName.Name = "NickName";
            NickName.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Nacionalidad
            // 
            Nacionalidad.DataPropertyName = "Nacionalidad";
            Nacionalidad.HeaderText = "Nacionalidad";
            Nacionalidad.Name = "Nacionalidad";
            Nacionalidad.ReadOnly = true;
            // 
            // Edad
            // 
            Edad.DataPropertyName = "Edad";
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            // 
            // Tiene_Equipo
            // 
            Tiene_Equipo.DataPropertyName = "TieneEquipo";
            Tiene_Equipo.HeaderText = "Tiene_equipo";
            Tiene_Equipo.Name = "Tiene_Equipo";
            Tiene_Equipo.ReadOnly = true;
            Tiene_Equipo.Resizable = DataGridViewTriState.True;
            Tiene_Equipo.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Experiencia
            // 
            Experiencia.DataPropertyName = "Experiencia";
            Experiencia.HeaderText = "Experiencia";
            Experiencia.Name = "Experiencia";
            Experiencia.ReadOnly = true;
            // 
            // Equipo
            // 
            Equipo.DataPropertyName = "EquipoAsociado";
            Equipo.HeaderText = "Equipo";
            Equipo.Name = "Equipo";
            Equipo.ReadOnly = true;
            // 
            // Veces_MVP
            // 
            Veces_MVP.DataPropertyName = "VecesMVP";
            Veces_MVP.HeaderText = "MVP";
            Veces_MVP.Name = "Veces_MVP";
            Veces_MVP.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.BackgroundImage = Properties.Resources.Lolito;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(12, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 60);
            button1.TabIndex = 17;
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(93, 23);
            label7.Name = "label7";
            label7.Size = new Size(88, 23);
            label7.TabIndex = 18;
            label7.Text = "Jugadores";
            // 
            // FormJugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(872, 510);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(btnModificar);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregarJugador);
            Controls.Add(dgvJugadores);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormJugadores";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormJugadores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregarJugador;
        private Button btnEliminar;
        private Button btnVolver;
        private Button btnModificar;
        private DataGridView dgvJugadores;
        private DataGridViewTextBoxColumn NickName;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Nacionalidad;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewCheckBoxColumn Tiene_Equipo;
        private DataGridViewTextBoxColumn Experiencia;
        private DataGridViewTextBoxColumn Equipo;
        private DataGridViewTextBoxColumn Veces_MVP;
        private Button button1;
        private Label label7;
    }
}