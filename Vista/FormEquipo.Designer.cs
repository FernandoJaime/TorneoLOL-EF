namespace Vista
{
    partial class FormEquipo
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
            btnGuardarEquipo = new Button();
            btnCancelarEquipo = new Button();
            label12 = new Label();
            txtNombreEquipo = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboJungla = new ComboBox();
            comboMid = new ComboBox();
            comboAdc = new ComboBox();
            comboSoporte = new ComboBox();
            comboTop = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnGuardarEquipo
            // 
            btnGuardarEquipo.FlatStyle = FlatStyle.Popup;
            btnGuardarEquipo.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarEquipo.Location = new Point(13, 293);
            btnGuardarEquipo.Margin = new Padding(4, 3, 4, 3);
            btnGuardarEquipo.Name = "btnGuardarEquipo";
            btnGuardarEquipo.Size = new Size(92, 30);
            btnGuardarEquipo.TabIndex = 7;
            btnGuardarEquipo.Text = "Guardar";
            btnGuardarEquipo.UseVisualStyleBackColor = true;
            btnGuardarEquipo.Click += btnGuardarEquipo_Click;
            // 
            // btnCancelarEquipo
            // 
            btnCancelarEquipo.BackColor = Color.Transparent;
            btnCancelarEquipo.FlatStyle = FlatStyle.Popup;
            btnCancelarEquipo.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarEquipo.Location = new Point(255, 293);
            btnCancelarEquipo.Margin = new Padding(4, 3, 4, 3);
            btnCancelarEquipo.Name = "btnCancelarEquipo";
            btnCancelarEquipo.Size = new Size(92, 30);
            btnCancelarEquipo.TabIndex = 8;
            btnCancelarEquipo.Text = "Cancelar";
            btnCancelarEquipo.UseVisualStyleBackColor = false;
            btnCancelarEquipo.Click += btnCancelarEquipo_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(75, 27);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(110, 15);
            label12.TabIndex = 45;
            label12.Text = "Nombre de equipo:";
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreEquipo.Location = new Point(193, 19);
            txtNombreEquipo.Margin = new Padding(4, 3, 4, 3);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(154, 23);
            txtNombreEquipo.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(62, 241);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 35;
            label6.Text = "Soporte:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(84, 201);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 37;
            label7.Text = "Adc:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(82, 160);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 39;
            label8.Text = "Mid:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(69, 119);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 41;
            label9.Text = "Jungla:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(85, 83);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 43;
            label10.Text = "Top:";
            // 
            // comboJungla
            // 
            comboJungla.DropDownStyle = ComboBoxStyle.DropDownList;
            comboJungla.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboJungla.FormattingEnabled = true;
            comboJungla.Location = new Point(133, 111);
            comboJungla.Margin = new Padding(4, 3, 4, 3);
            comboJungla.Name = "comboJungla";
            comboJungla.Size = new Size(154, 23);
            comboJungla.TabIndex = 3;
            // 
            // comboMid
            // 
            comboMid.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMid.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboMid.FormattingEnabled = true;
            comboMid.Location = new Point(133, 152);
            comboMid.Margin = new Padding(4, 3, 4, 3);
            comboMid.Name = "comboMid";
            comboMid.Size = new Size(154, 23);
            comboMid.TabIndex = 4;
            // 
            // comboAdc
            // 
            comboAdc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAdc.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboAdc.FormattingEnabled = true;
            comboAdc.Location = new Point(133, 193);
            comboAdc.Margin = new Padding(4, 3, 4, 3);
            comboAdc.Name = "comboAdc";
            comboAdc.Size = new Size(154, 23);
            comboAdc.TabIndex = 5;
            // 
            // comboSoporte
            // 
            comboSoporte.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSoporte.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboSoporte.FormattingEnabled = true;
            comboSoporte.Location = new Point(133, 233);
            comboSoporte.Margin = new Padding(4, 3, 4, 3);
            comboSoporte.Name = "comboSoporte";
            comboSoporte.Size = new Size(154, 23);
            comboSoporte.TabIndex = 6;
            // 
            // comboTop
            // 
            comboTop.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTop.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboTop.FormattingEnabled = true;
            comboTop.Location = new Point(133, 75);
            comboTop.Margin = new Padding(4, 3, 4, 3);
            comboTop.Name = "comboTop";
            comboTop.Size = new Size(154, 23);
            comboTop.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.BackgroundImage = Properties.Resources.Lolito;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(56, 43);
            button1.TabIndex = 46;
            button1.UseVisualStyleBackColor = false;
            // 
            // FormEquipo
            // 
            AcceptButton = btnGuardarEquipo;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            CancelButton = btnCancelarEquipo;
            ClientSize = new Size(358, 330);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(btnGuardarEquipo);
            Controls.Add(btnCancelarEquipo);
            Controls.Add(label12);
            Controls.Add(txtNombreEquipo);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(comboJungla);
            Controls.Add(comboMid);
            Controls.Add(comboAdc);
            Controls.Add(comboSoporte);
            Controls.Add(comboTop);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormEquipo";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormEquipo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGuardarEquipo;
        private Button btnCancelarEquipo;
        private Label label12;
        private TextBox txtNombreEquipo;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox comboJungla;
        private ComboBox comboMid;
        private ComboBox comboAdc;
        private ComboBox comboSoporte;
        private ComboBox comboTop;
        private Button button1;
    }
}