namespace FormularioDatosUsuario
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbSexo = new Label();
            lbEdad = new Label();
            lbNombre = new Label();
            lbCiudad = new Label();
            label1 = new Label();
            tbNombre = new TextBox();
            NumUpDOwnEdad = new NumericUpDown();
            gbSexo = new GroupBox();
            rbFemenino = new RadioButton();
            rbMasculino = new RadioButton();
            cbTerminosyCondiciones = new CheckBox();
            btMostrarDatos = new Button();
            cbCiudad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)NumUpDOwnEdad).BeginInit();
            gbSexo.SuspendLayout();
            SuspendLayout();
            // 
            // lbSexo
            // 
            lbSexo.AutoSize = true;
            lbSexo.Font = new Font("Bodoni MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSexo.Location = new Point(12, 163);
            lbSexo.Name = "lbSexo";
            lbSexo.Size = new Size(79, 34);
            lbSexo.TabIndex = 2;
            lbSexo.Text = "Sexo:";
            lbSexo.Click += label1_Click_1;
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Font = new Font("Bodoni MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEdad.Location = new Point(12, 108);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(87, 34);
            lbEdad.TabIndex = 1;
            lbEdad.Text = "Edad:";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Bodoni MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(12, 47);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(119, 34);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre:";
            lbNombre.Click += label1_Click;
            // 
            // lbCiudad
            // 
            lbCiudad.AutoSize = true;
            lbCiudad.Font = new Font("Bodoni MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCiudad.Location = new Point(12, 214);
            lbCiudad.Name = "lbCiudad";
            lbCiudad.Size = new Size(107, 34);
            lbCiudad.TabIndex = 3;
            lbCiudad.Text = "Ciudad:";
            lbCiudad.Click += lbCiudad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 58);
            label1.Name = "label1";
            label1.Size = new Size(0, 24);
            label1.TabIndex = 4;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.Info;
            tbNombre.Location = new Point(137, 51);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(268, 30);
            tbNombre.TabIndex = 5;
            // 
            // NumUpDOwnEdad
            // 
            NumUpDOwnEdad.BackColor = Color.LemonChiffon;
            NumUpDOwnEdad.ImeMode = ImeMode.NoControl;
            NumUpDOwnEdad.Location = new Point(137, 112);
            NumUpDOwnEdad.Name = "NumUpDOwnEdad";
            NumUpDOwnEdad.ReadOnly = true;
            NumUpDOwnEdad.Size = new Size(268, 30);
            NumUpDOwnEdad.TabIndex = 9;
            NumUpDOwnEdad.TabStop = false;
            NumUpDOwnEdad.TextAlign = HorizontalAlignment.Right;
            NumUpDOwnEdad.UpDownAlign = LeftRightAlignment.Left;
            NumUpDOwnEdad.Click += Edad_Click;
            // 
            // gbSexo
            // 
            gbSexo.Controls.Add(rbFemenino);
            gbSexo.Controls.Add(rbMasculino);
            gbSexo.Location = new Point(137, 151);
            gbSexo.Name = "gbSexo";
            gbSexo.Size = new Size(240, 61);
            gbSexo.TabIndex = 10;
            gbSexo.TabStop = false;
            gbSexo.Enter += gpSexo_Enter;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.BackColor = Color.PeachPuff;
            rbFemenino.Location = new Point(126, 22);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(104, 28);
            rbFemenino.TabIndex = 1;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = false;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.BackColor = Color.LemonChiffon;
            rbMasculino.Location = new Point(16, 22);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(104, 28);
            rbMasculino.TabIndex = 0;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = false;
            // 
            // cbTerminosyCondiciones
            // 
            cbTerminosyCondiciones.AutoSize = true;
            cbTerminosyCondiciones.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cbTerminosyCondiciones.Location = new Point(21, 289);
            cbTerminosyCondiciones.Name = "cbTerminosyCondiciones";
            cbTerminosyCondiciones.Size = new Size(398, 25);
            cbTerminosyCondiciones.TabIndex = 11;
            cbTerminosyCondiciones.Text = "Acepta usted los terminos y condiciones?.";
            cbTerminosyCondiciones.UseVisualStyleBackColor = true;
            cbTerminosyCondiciones.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btMostrarDatos
            // 
            btMostrarDatos.BackColor = Color.CadetBlue;
            btMostrarDatos.FlatStyle = FlatStyle.Popup;
            btMostrarDatos.Location = new Point(107, 344);
            btMostrarDatos.Name = "btMostrarDatos";
            btMostrarDatos.Size = new Size(202, 29);
            btMostrarDatos.TabIndex = 12;
            btMostrarDatos.Text = "MOSTRAR DATOS";
            btMostrarDatos.UseVisualStyleBackColor = false;
            btMostrarDatos.Click += button1_Click;
            // 
            // cbCiudad
            // 
            cbCiudad.BackColor = Color.LemonChiffon;
            cbCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCiudad.FormattingEnabled = true;
            cbCiudad.Items.AddRange(new object[] { "Managua", "Leon", "San Juan", "Bilwi" });
            cbCiudad.Location = new Point(178, 218);
            cbCiudad.Name = "cbCiudad";
            cbCiudad.Size = new Size(151, 32);
            cbCiudad.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(435, 414);
            Controls.Add(cbCiudad);
            Controls.Add(btMostrarDatos);
            Controls.Add(cbTerminosyCondiciones);
            Controls.Add(gbSexo);
            Controls.Add(NumUpDOwnEdad);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Controls.Add(lbCiudad);
            Controls.Add(lbNombre);
            Controls.Add(lbEdad);
            Controls.Add(lbSexo);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Datos de usuario";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)NumUpDOwnEdad).EndInit();
            gbSexo.ResumeLayout(false);
            gbSexo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbNombre;
        private Label lbEdad;
        private Label lbSexo;
        private Label lbCiudad;
        private Label label1;
        private TextBox tbNombre;
        private NumericUpDown NumUpDOwnEdad;
        private GroupBox gbSexo;
        private RadioButton rbMasculino;
        private RadioButton rbFemenino;
        private CheckBox cbTerminosyCondiciones;
        private Button btMostrarDatos;
        private ComboBox cbCiudad;
    }
}
