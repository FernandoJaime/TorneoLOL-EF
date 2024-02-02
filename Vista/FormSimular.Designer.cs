namespace Vista
{
    partial class FormSimular
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
            lbGanador = new Label();
            comboEquipo2 = new ComboBox();
            label13 = new Label();
            comboEquipo1 = new ComboBox();
            btnSimularPartida = new Button();
            btnVolver = new Button();
            btnDesiganr = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbGanador
            // 
            lbGanador.AutoSize = true;
            lbGanador.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbGanador.Location = new Point(113, 197);
            lbGanador.Margin = new Padding(4, 0, 4, 0);
            lbGanador.Name = "lbGanador";
            lbGanador.Size = new Size(72, 19);
            lbGanador.TabIndex = 34;
            lbGanador.Text = "Ganador:";
            // 
            // comboEquipo2
            // 
            comboEquipo2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEquipo2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboEquipo2.FormattingEnabled = true;
            comboEquipo2.Location = new Point(330, 63);
            comboEquipo2.Margin = new Padding(4, 3, 4, 3);
            comboEquipo2.Name = "comboEquipo2";
            comboEquipo2.Size = new Size(200, 23);
            comboEquipo2.TabIndex = 33;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(257, 63);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(50, 23);
            label13.TabIndex = 32;
            label13.Text = "- VS -";
            // 
            // comboEquipo1
            // 
            comboEquipo1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEquipo1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboEquipo1.FormattingEnabled = true;
            comboEquipo1.Location = new Point(32, 65);
            comboEquipo1.Margin = new Padding(4, 3, 4, 3);
            comboEquipo1.Name = "comboEquipo1";
            comboEquipo1.Size = new Size(208, 23);
            comboEquipo1.TabIndex = 31;
            // 
            // btnSimularPartida
            // 
            btnSimularPartida.FlatStyle = FlatStyle.Popup;
            btnSimularPartida.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSimularPartida.Location = new Point(13, 186);
            btnSimularPartida.Margin = new Padding(4, 3, 4, 3);
            btnSimularPartida.Name = "btnSimularPartida";
            btnSimularPartida.Size = new Size(92, 30);
            btnSimularPartida.TabIndex = 30;
            btnSimularPartida.Text = "Simular";
            btnSimularPartida.UseVisualStyleBackColor = true;
            btnSimularPartida.Click += btnSimularPartida_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Transparent;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(461, 245);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(92, 30);
            btnVolver.TabIndex = 37;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnDesiganr
            // 
            btnDesiganr.BackColor = SystemColors.Menu;
            btnDesiganr.FlatStyle = FlatStyle.Popup;
            btnDesiganr.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDesiganr.Location = new Point(217, 122);
            btnDesiganr.Margin = new Padding(4, 3, 4, 3);
            btnDesiganr.Name = "btnDesiganr";
            btnDesiganr.Size = new Size(136, 35);
            btnDesiganr.TabIndex = 38;
            btnDesiganr.Text = "Designar habilidades";
            btnDesiganr.UseVisualStyleBackColor = false;
            btnDesiganr.Click += btnDesiganr_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.BackgroundImage = Properties.Resources.Lolito;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(248, 12);
            button1.Name = "button1";
            button1.Size = new Size(70, 50);
            button1.TabIndex = 47;
            button1.UseVisualStyleBackColor = false;
            // 
            // FormSimular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(558, 279);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(btnDesiganr);
            Controls.Add(btnVolver);
            Controls.Add(lbGanador);
            Controls.Add(comboEquipo2);
            Controls.Add(label13);
            Controls.Add(comboEquipo1);
            Controls.Add(btnSimularPartida);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormSimular";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormSimular_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbGanador;
        private ComboBox comboEquipo2;
        private Label label13;
        private ComboBox comboEquipo1;
        private Button btnSimularPartida;
        private Button btnVolver;
        private Button btnDesiganr;
        private Button button1;
    }
}