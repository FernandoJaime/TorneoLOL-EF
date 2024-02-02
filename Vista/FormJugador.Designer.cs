namespace Vista
{
    partial class FormJugador
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
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEdad = new TextBox();
            comboHabilidad = new ComboBox();
            comboNacionalidad = new ComboBox();
            txtNombreJugador = new TextBox();
            txtNickname = new TextBox();
            label11 = new Label();
            btnCancelarJugador = new Button();
            btnGuardarJugador = new Button();
            lblCampeon = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 64);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 39;
            label5.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 225);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 37;
            label3.Text = "Habilidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 141);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 36;
            label2.Text = "Nacionalidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 104);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 35;
            label1.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.Location = new Point(73, 96);
            txtEdad.Margin = new Padding(4, 3, 4, 3);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(244, 23);
            txtEdad.TabIndex = 2;
            // 
            // comboHabilidad
            // 
            comboHabilidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboHabilidad.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboHabilidad.FormattingEnabled = true;
            comboHabilidad.Items.AddRange(new object[] { "Novato", "Veterano", "Profesional", "Experto" });
            comboHabilidad.Location = new Point(105, 217);
            comboHabilidad.Margin = new Padding(4, 3, 4, 3);
            comboHabilidad.Name = "comboHabilidad";
            comboHabilidad.Size = new Size(212, 23);
            comboHabilidad.TabIndex = 5;
            // 
            // comboNacionalidad
            // 
            comboNacionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboNacionalidad.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboNacionalidad.FormattingEnabled = true;
            comboNacionalidad.Items.AddRange(new object[] { "Argentina", "Brasil", "Canadá", "China", "Corea del Sur", "Dinamarca", "Estados Unidos", "Finlandia", "Francia", "Alemania", "Países Bajos", "Polonia", "Reino Unido", "Rumanía", "Suecia", "Taiwán" });
            comboNacionalidad.Location = new Point(125, 133);
            comboNacionalidad.Margin = new Padding(4, 3, 4, 3);
            comboNacionalidad.Name = "comboNacionalidad";
            comboNacionalidad.Size = new Size(192, 23);
            comboNacionalidad.TabIndex = 3;
            // 
            // txtNombreJugador
            // 
            txtNombreJugador.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreJugador.Location = new Point(82, 57);
            txtNombreJugador.Margin = new Padding(4, 3, 4, 3);
            txtNombreJugador.Name = "txtNombreJugador";
            txtNombreJugador.Size = new Size(228, 23);
            txtNombreJugador.TabIndex = 1;
            // 
            // txtNickname
            // 
            txtNickname.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNickname.Location = new Point(105, 176);
            txtNickname.Margin = new Padding(4, 3, 4, 3);
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(212, 23);
            txtNickname.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(17, 184);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 28;
            label11.Text = "Nickname:";
            // 
            // btnCancelarJugador
            // 
            btnCancelarJugador.BackColor = Color.Transparent;
            btnCancelarJugador.DialogResult = DialogResult.Cancel;
            btnCancelarJugador.FlatStyle = FlatStyle.Popup;
            btnCancelarJugador.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarJugador.Location = new Point(225, 277);
            btnCancelarJugador.Margin = new Padding(4, 3, 4, 3);
            btnCancelarJugador.Name = "btnCancelarJugador";
            btnCancelarJugador.Size = new Size(92, 30);
            btnCancelarJugador.TabIndex = 8;
            btnCancelarJugador.Text = "Cancelar";
            btnCancelarJugador.UseVisualStyleBackColor = false;
            btnCancelarJugador.Click += btnCancelarJugador_Click;
            // 
            // btnGuardarJugador
            // 
            btnGuardarJugador.FlatStyle = FlatStyle.Popup;
            btnGuardarJugador.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarJugador.Location = new Point(13, 277);
            btnGuardarJugador.Margin = new Padding(4, 3, 4, 3);
            btnGuardarJugador.Name = "btnGuardarJugador";
            btnGuardarJugador.Size = new Size(92, 30);
            btnGuardarJugador.TabIndex = 7;
            btnGuardarJugador.Text = "Guardar";
            btnGuardarJugador.UseVisualStyleBackColor = true;
            btnGuardarJugador.Click += btnGuardarJugador_Click;
            // 
            // lblCampeon
            // 
            lblCampeon.AutoSize = true;
            lblCampeon.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCampeon.Location = new Point(73, 23);
            lblCampeon.Margin = new Padding(4, 0, 4, 0);
            lblCampeon.Name = "lblCampeon";
            lblCampeon.Size = new Size(0, 15);
            lblCampeon.TabIndex = 40;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.BackgroundImage = Properties.Resources.Lolito;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(10, 9);
            button1.Name = "button1";
            button1.Size = new Size(56, 43);
            button1.TabIndex = 41;
            button1.UseVisualStyleBackColor = false;
            // 
            // FormJugador
            // 
            AcceptButton = btnGuardarJugador;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            CancelButton = btnCancelarJugador;
            ClientSize = new Size(327, 318);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(lblCampeon);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEdad);
            Controls.Add(comboHabilidad);
            Controls.Add(comboNacionalidad);
            Controls.Add(txtNombreJugador);
            Controls.Add(txtNickname);
            Controls.Add(label11);
            Controls.Add(btnCancelarJugador);
            Controls.Add(btnGuardarJugador);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormJugador";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormJugador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEdad;
        private ComboBox comboHabilidad;
        private ComboBox comboNacionalidad;
        private TextBox txtNombreJugador;
        private TextBox txtNickname;
        private Label label11;
        private Button btnCancelarJugador;
        private Button btnGuardarJugador;
        private Label lblCampeon;
        private Button button1;
    }
}