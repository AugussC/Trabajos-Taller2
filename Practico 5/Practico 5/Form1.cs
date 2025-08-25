using Microsoft.VisualBasic.ApplicationServices;
using Practico_5.Properties;
using System.Windows.Forms;

namespace Practico_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGrid();
            InicializarFormulario();

            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void RbHombre_CheckedChanged(object sender, EventArgs e)
        {
            if (RbHombre.Checked)
            {
                pictureBox1.Image = Properties.Resources.images; // Nombre del recurso
            }
        }

        private void RbMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RbMujer.Checked)
            {
                pictureBox1.Image = Properties.Resources._6347611; // Nombre del recurso
            }
        }



        // Inicializar valores por defecto
        private void InicializarFormulario()
        {
            this.Text = "Formulario con Grid";

            OpenFileDialog1.Filter = "Archivos Imagenes|*.jpg;*.bmp;*.png";
        }

        // Configuración del DataGridView
        private void ConfigurarDataGrid()
        {
            dataGridView1.Columns.Clear(); 


            // Columna Nombre
            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView1.Columns.Add(colNombre);

            // Columna Apellido
            DataGridViewTextBoxColumn colApellido = new DataGridViewTextBoxColumn();
            colApellido.Name = "Apellido";
            colApellido.HeaderText = "Apellido";
            colApellido.DefaultCellStyle.Font = new Font("Verdana", 12, FontStyle.Italic);
            dataGridView1.Columns.Add(colApellido);

            // Columna Sexo
            DataGridViewTextBoxColumn colSexo = new DataGridViewTextBoxColumn();
            colSexo.Name = "Sexo";
            colSexo.HeaderText = "Sexo";
            dataGridView1.Columns.Add(colSexo);

            // Columna Saldo
            DataGridViewTextBoxColumn colSaldo = new DataGridViewTextBoxColumn();
            colSaldo.Name = "Saldo";
            colSaldo.HeaderText = "Saldo";
            colSaldo.ValueType = typeof(decimal);           // <- importante
            colSaldo.DefaultCellStyle.Format = "N2";        // o "C2" si querés moneda
            dataGridView1.Columns.Add(colSaldo);


            // Columna Foto (imagen)
            DataGridViewImageColumn colFoto = new DataGridViewImageColumn();
            colFoto.Name = "Foto";
            colFoto.HeaderText = "Foto";
            colFoto.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns.Add(colFoto);


            // Columna Eliminar (botón)
            DataGridViewButtonColumn colEliminar = new DataGridViewButtonColumn();
            colEliminar.Name = "Eliminar";
            colEliminar.HeaderText = "Acción";
            colEliminar.Text = "Eliminar";
            colEliminar.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(colEliminar);

            dataGridView1.RowTemplate.Height = 50;
        }
        private void BtnFoto_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string source = OpenFileDialog1.FileName;
                string archivo = ObtenerNombreArchivo(source);

                string carpetaFotos = Application.StartupPath + @"\Fotos\";
                string destino = Path.Combine(carpetaFotos, archivo);

                // Verificar si la carpeta existe, si no, crearla
                if (!Directory.Exists(carpetaFotos))
                {
                    Directory.CreateDirectory(carpetaFotos);
                }

                File.Copy(source, destino, true);

                textFoto.Text = destino;
                pictureBox1.Image = Image.FromFile(destino);
            }
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = FormatearTexto(textNombre.Text);
            string apellido = FormatearTexto(textApellido.Text);
            string sexo = RbHombre.Checked ? "Masculino" : "Femenino";
            decimal saldo = decimal.TryParse(textSaldo.Text, out var s) ? s : 0m;
            Image foto = pictureBox1.Image;

            int rowIndex = dataGridView1.Rows.Add(nombre, apellido, sexo, saldo, foto);

            PintarFilaPorSaldo(rowIndex);     
            
        }

        private void PintarFilaPorSaldo(int rowIndex)
        {
            var row = dataGridView1.Rows[rowIndex];

            if (row.Cells["Saldo"].Value != null &&
                decimal.TryParse(row.Cells["Saldo"].Value.ToString(), out var val) &&
                val < 50m)
            {
                row.DefaultCellStyle.BackColor = Color.LightCoral;
                row.DefaultCellStyle.SelectionBackColor = Color.IndianRed; // <- clave
                row.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            else
            {
                // reset si querés
                row.DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.SelectionBackColor;
                row.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.SelectionForeColor;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Sexo"].Index)
            {
                var valorSexo = dataGridView1.Rows[e.RowIndex].Cells["Sexo"].Value?.ToString();

                if (valorSexo == "Masculino")
                {
                    RbHombre.Checked = true;
                }
                else if (valorSexo == "Femenino")
                {
                    RbMujer.Checked = true;
                }
            }
        }



        // Evento para botón Eliminar dentro del DataGrid
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

       

        // --- FUNCIONES AUXILIARES ---

        // Obtener nombre del archivo desde la ruta
        private string ObtenerNombreArchivo(string ruta)
        {
            return Path.GetFileName(ruta);
        }

        // Formatear texto: primera letra mayúscula, resto minúscula
        private string FormatearTexto(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return "";
            texto = texto.ToLower();
            return char.ToUpper(texto[0]) + texto.Substring(1);
        }
    }
}
    