namespace Vista
{
    partial class FormSetChamp
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
            btnAceptar = new Button();
            numDaño = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            numVida = new NumericUpDown();
            lblVida = new Label();
            lblDaño = new Label();
            label3 = new Label();
            comboRol = new ComboBox();
            txtNombreChamp = new TextBox();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numDaño).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVida).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.Menu;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(181, 218);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(84, 29);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // numDaño
            // 
            numDaño.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numDaño.Location = new Point(71, 102);
            numDaño.Margin = new Padding(4, 3, 4, 3);
            numDaño.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numDaño.Name = "numDaño";
            numDaño.Size = new Size(175, 23);
            numDaño.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 110);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 47;
            label1.Text = "Daño:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 165);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 48;
            label2.Text = "Vida:";
            // 
            // numVida
            // 
            numVida.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numVida.Location = new Point(71, 157);
            numVida.Margin = new Padding(4, 3, 4, 3);
            numVida.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numVida.Name = "numVida";
            numVida.Size = new Size(175, 23);
            numVida.TabIndex = 49;
            // 
            // lblVida
            // 
            lblVida.AutoSize = true;
            lblVida.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVida.Location = new Point(122, 135);
            lblVida.Margin = new Padding(4, 0, 4, 0);
            lblVida.Name = "lblVida";
            lblVida.Size = new Size(47, 15);
            lblVida.TabIndex = 50;
            lblVida.Text = "lblVida";
            // 
            // lblDaño
            // 
            lblDaño.AutoSize = true;
            lblDaño.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDaño.Location = new Point(122, 84);
            lblDaño.Margin = new Padding(4, 0, 4, 0);
            lblDaño.Name = "lblDaño";
            lblDaño.Size = new Size(51, 15);
            lblDaño.TabIndex = 51;
            lblDaño.Text = "lblDaño";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(80, 31);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 52;
            label3.Text = "Nombre del campeon:";
            // 
            // comboRol
            // 
            comboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRol.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboRol.FormattingEnabled = true;
            comboRol.Location = new Point(313, 127);
            comboRol.Name = "comboRol";
            comboRol.Size = new Size(126, 23);
            comboRol.TabIndex = 53;
            comboRol.SelectedIndexChanged += comboRol_SelectedIndexChanged;
            // 
            // txtNombreChamp
            // 
            txtNombreChamp.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreChamp.Location = new Point(213, 23);
            txtNombreChamp.Name = "txtNombreChamp";
            txtNombreChamp.Size = new Size(152, 23);
            txtNombreChamp.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(278, 135);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 55;
            label4.Text = "Rol:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.BackgroundImage = Properties.Resources.Lolito;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(56, 43);
            button1.TabIndex = 56;
            button1.UseVisualStyleBackColor = false;
            // 
            // FormSetChamp
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(450, 259);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtNombreChamp);
            Controls.Add(comboRol);
            Controls.Add(label3);
            Controls.Add(lblDaño);
            Controls.Add(lblVida);
            Controls.Add(numVida);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numDaño);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormSetChamp";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormSetChamp_Load;
            ((System.ComponentModel.ISupportInitialize)numDaño).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVida).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAceptar;
        private NumericUpDown numDaño;
        private Label label1;
        private Label label2;
        private NumericUpDown numVida;
        private Label lblVida;
        private Label lblDaño;
        private Label label3;
        private ComboBox comboRol;
        private TextBox txtNombreChamp;
        private Label label4;
        private Button button1;
    }
}