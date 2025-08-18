using Microsoft.VisualBasic.ApplicationServices;

namespace Pequeño_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void TGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TDni.Text))
            {
                MessageBox.Show("Debe completar todos los campos",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(TDni.Text, out _))
            {
                MessageBox.Show("El DNI debe contener solo números",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validación: Nombre y Apellido solo letras
            if (!EsSoloLetras(TNombre.Text) || !EsSoloLetras(TApellido.Text))
            {
                MessageBox.Show("El Nombre y Apellido deben contener solo letras",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Confirmación para registrar nuevo cliente
            DialogResult ask = MessageBox.Show("¿Desea ingresar un nuevo cliente?",
                                       "Confirmar Inserción",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
               
                MessageBox.Show($"El Cliente: {TNombre.Text} {TApellido.Text} se insertó correctamente",
                                "Guardar",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                
                LModificar.Text = TApellido.Text + " " + TNombre.Text;

                
                TNombre.Clear();
                TApellido.Clear();
                TDni.Clear();
                TNombre.Focus();
            }
        }

        
        private bool EsSoloLetras(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && c != ' ') return false;
            }
            return true;
        }

        private void TEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show($"Está a punto de eliminar al Cliente: {TNombre.Text} {TApellido.Text}",
                                        "Confirmar Eliminación",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Exclamation,
                                        MessageBoxDefaultButton.Button2);

            if (ask == DialogResult.Yes)
            {
                // Mensaje de confirmación
                MessageBox.Show($"El Cliente: {TNombre.Text} {TApellido.Text} se eliminó correctamente",
                                "Eliminar",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Limpiar campos y label
                TNombre.Clear();
                TApellido.Clear();
                TDni.Clear();
                LModificar.Text = "";
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

      
        private void RbVaron_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.iconoMujer;
        }

        private void RbMujer_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.IconoHombre;
            
        }

        
        
    }
}
