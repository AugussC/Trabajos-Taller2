namespace Practico_5
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
            panel1 = new Panel();
            textFoto = new TextBox();
            RbMujer = new RadioButton();
            RbHombre = new RadioButton();
            textSaldo = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textApellido = new TextBox();
            textNombre = new TextBox();
            BtnFoto = new Button();
            label5 = new Label();
            BtnGuardar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            OpenFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(textFoto);
            panel1.Controls.Add(RbMujer);
            panel1.Controls.Add(RbHombre);
            panel1.Controls.Add(textSaldo);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textApellido);
            panel1.Controls.Add(textNombre);
            panel1.Controls.Add(BtnFoto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(BtnGuardar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 254);
            panel1.TabIndex = 0;
            // 
            // textFoto
            // 
            textFoto.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textFoto.Location = new Point(164, 190);
            textFoto.Name = "textFoto";
            textFoto.Size = new Size(279, 23);
            textFoto.TabIndex = 15;
            // 
            // RbMujer
            // 
            RbMujer.AutoSize = true;
            RbMujer.BackColor = SystemColors.ActiveCaptionText;
            RbMujer.Checked = true;
            RbMujer.Font = new Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RbMujer.Location = new Point(269, 124);
            RbMujer.Name = "RbMujer";
            RbMujer.Size = new Size(59, 23);
            RbMujer.TabIndex = 14;
            RbMujer.TabStop = true;
            RbMujer.Text = "Mujer";
            RbMujer.UseVisualStyleBackColor = false;
            RbMujer.CheckedChanged += RbMujer_CheckedChanged;
            // 
            // RbHombre
            // 
            RbHombre.AutoSize = true;
            RbHombre.BackColor = SystemColors.ActiveCaptionText;
            RbHombre.Font = new Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RbHombre.Location = new Point(164, 124);
            RbHombre.Name = "RbHombre";
            RbHombre.Size = new Size(74, 23);
            RbHombre.TabIndex = 13;
            RbHombre.Text = "Hombre";
            RbHombre.UseVisualStyleBackColor = false;
            RbHombre.CheckedChanged += RbHombre_CheckedChanged;
            // 
            // textSaldo
            // 
            textSaldo.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSaldo.Location = new Point(164, 161);
            textSaldo.Name = "textSaldo";
            textSaldo.Size = new Size(279, 23);
            textSaldo.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(298, 91);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(124, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // textApellido
            // 
            textApellido.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textApellido.Location = new Point(164, 62);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(279, 23);
            textApellido.TabIndex = 10;
            // 
            // textNombre
            // 
            textNombre.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNombre.Location = new Point(164, 22);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(279, 23);
            textNombre.TabIndex = 9;
            // 
            // BtnFoto
            // 
            BtnFoto.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFoto.ForeColor = SystemColors.ActiveCaptionText;
            BtnFoto.Location = new Point(66, 190);
            BtnFoto.Name = "BtnFoto";
            BtnFoto.Size = new Size(78, 26);
            BtnFoto.TabIndex = 8;
            BtnFoto.Text = "foto";
            BtnFoto.UseVisualStyleBackColor = true;
            BtnFoto.Click += BtnFoto_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.Control;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(66, 154);
            label5.Name = "label5";
            label5.Size = new Size(78, 33);
            label5.TabIndex = 7;
            label5.Text = "Saldo:";
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = SystemColors.ButtonHighlight;
            BtnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            BtnGuardar.Image = (Image)resources.GetObject("BtnGuardar.Image");
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(574, 199);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(150, 50);
            BtnGuardar.TabIndex = 0;
            BtnGuardar.Text = "Agregar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.Control;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(66, 121);
            label4.Name = "label4";
            label4.Size = new Size(70, 33);
            label4.TabIndex = 6;
            label4.Text = "Sexo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(66, 88);
            label3.Name = "label3";
            label3.Size = new Size(210, 33);
            label3.TabIndex = 5;
            label3.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(66, 55);
            label2.Name = "label2";
            label2.Size = new Size(98, 33);
            label2.TabIndex = 4;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(66, 22);
            label1.Name = "label1";
            label1.Size = new Size(92, 33);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(419, 217);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._6347611;
            pictureBox1.Location = new Point(516, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 181);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // OpenFileDialog1
            // 
            OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(801, 195);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnGuardar;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textApellido;
        private TextBox textNombre;
        private Button BtnFoto;
        private Label label5;
        private OpenFileDialog OpenFileDialog1;
        private TextBox textFoto;
        private RadioButton RbMujer;
        private RadioButton RbHombre;
        private TextBox textSaldo;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}
