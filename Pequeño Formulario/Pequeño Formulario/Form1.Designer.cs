namespace Pequeño_Formulario
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
            LNya = new Label();
            LModificar = new Label();
            LDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            TGuardar = new Button();
            TEliminar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            TTelefono = new TextBox();
            LTelefono = new Label();
            LTarjetas = new Label();
            ChkNaranja = new CheckBox();
            ChkVisa = new CheckBox();
            ChkMaster = new CheckBox();
            BSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(27, 71);
            LNya.Name = "LNya";
            LNya.Size = new Size(107, 15);
            LNya.TabIndex = 0;
            LNya.Text = "Nombre y Apellido";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.BackColor = Color.Transparent;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(208, 71);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(61, 15);
            LModificar.TabIndex = 1;
            LModificar.Text = " Modificar";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(27, 125);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 2;
            LDni.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(27, 166);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(27, 206);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre";
            LNombre.Click += LNombre_Click;
            // 
            // TDni
            // 
            TDni.Location = new Point(94, 125);
            TDni.Name = "TDni";
            TDni.Size = new Size(175, 23);
            TDni.TabIndex = 5;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(94, 163);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(175, 23);
            TApellido.TabIndex = 6;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(94, 206);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(175, 23);
            TNombre.TabIndex = 7;
            // 
            // TGuardar
            // 
            TGuardar.Image = Properties.Resources.Captura3;
            TGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            TGuardar.Location = new Point(296, 313);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(108, 61);
            TGuardar.TabIndex = 8;
            TGuardar.Text = "Guardar";
            TGuardar.TextAlign = ContentAlignment.MiddleRight;
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += TGuardar_Click;
            // 
            // TEliminar
            // 
            TEliminar.Image = Properties.Resources.Captura4;
            TEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            TEliminar.Location = new Point(410, 313);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(107, 61);
            TEliminar.TabIndex = 9;
            TEliminar.Text = "Eliminar";
            TEliminar.TextAlign = ContentAlignment.MiddleRight;
            TEliminar.UseVisualStyleBackColor = true;
            TEliminar.Click += TEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(164, 25);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 10;
            label1.Text = "Nuevo Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconoMujer;
            pictureBox1.Location = new Point(374, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 163);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Location = new Point(374, 191);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(55, 19);
            RBVaron.TabIndex = 12;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += RbMujer_CheckedChanged;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Checked = true;
            RBMujer.Location = new Point(510, 191);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(56, 19);
            RBMujer.TabIndex = 13;
            RBMujer.TabStop = true;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RbVaron_CheckedChanged;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(94, 247);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(175, 23);
            TTelefono.TabIndex = 15;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(27, 247);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(53, 15);
            LTelefono.TabIndex = 14;
            LTelefono.Text = "Telefono";
            // 
            // LTarjetas
            // 
            LTarjetas.AutoSize = true;
            LTarjetas.Location = new Point(25, 295);
            LTarjetas.Name = "LTarjetas";
            LTarjetas.Size = new Size(100, 15);
            LTarjetas.TabIndex = 16;
            LTarjetas.Text = "Tarjeta de Credito";
            // 
            // ChkNaranja
            // 
            ChkNaranja.AutoSize = true;
            ChkNaranja.Location = new Point(164, 291);
            ChkNaranja.Name = "ChkNaranja";
            ChkNaranja.Size = new Size(67, 19);
            ChkNaranja.TabIndex = 17;
            ChkNaranja.Text = "Naranja";
            ChkNaranja.UseVisualStyleBackColor = true;
            // 
            // ChkVisa
            // 
            ChkVisa.AutoSize = true;
            ChkVisa.Location = new Point(164, 316);
            ChkVisa.Name = "ChkVisa";
            ChkVisa.Size = new Size(47, 19);
            ChkVisa.TabIndex = 18;
            ChkVisa.Text = "Visa";
            ChkVisa.UseVisualStyleBackColor = true;
            // 
            // ChkMaster
            // 
            ChkMaster.AutoSize = true;
            ChkMaster.Location = new Point(164, 341);
            ChkMaster.Name = "ChkMaster";
            ChkMaster.Size = new Size(85, 19);
            ChkMaster.TabIndex = 19;
            ChkMaster.Text = "Mastercard";
            ChkMaster.UseVisualStyleBackColor = true;
            // 
            // BSalir
            // 
            BSalir.Image = Properties.Resources.Captura5;
            BSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BSalir.Location = new Point(523, 313);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(107, 63);
            BSalir.TabIndex = 20;
            BSalir.Text = "Salir";
            BSalir.TextAlign = ContentAlignment.MiddleRight;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 377);
            Controls.Add(BSalir);
            Controls.Add(ChkMaster);
            Controls.Add(ChkVisa);
            Controls.Add(ChkNaranja);
            Controls.Add(LTarjetas);
            Controls.Add(TTelefono);
            Controls.Add(LTelefono);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(TEliminar);
            Controls.Add(TGuardar);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TDni);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Controls.Add(LDni);
            Controls.Add(LModificar);
            Controls.Add(LNya);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNya;
        private Label LModificar;
        private Label LDni;
        private Label LApellido;
        private Label LNombre;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private Button TGuardar;
        private Button TEliminar;
        private Label label1;
        private PictureBox pictureBox1;
        private RadioButton RBVaron;
        private RadioButton RBMujer;
        private TextBox TTelefono;
        private Label LTelefono;
        private Label LTarjetas;
        private CheckBox ChkNaranja;
        private CheckBox ChkVisa;
        private CheckBox ChkMaster;
        private Button BSalir;
    }
}
