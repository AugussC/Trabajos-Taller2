using System;
using System.Windows.Forms;

namespace Practico_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int desde = int.Parse(TextDesde.Text);
            int hasta = int.Parse(TextHasta.Text);

            if (desde > hasta)
            {
                MessageBox.Show("El valor 'Desde' debe ser menor o igual al valor 'Hasta'.");
                return;
            }

            Limpiar();
            for (int i = desde; i <= hasta; i++)
            {
                lstNumeros.Items.Add(i);
                chartNumeros.Series["Series1"].Points.AddXY(i, i);
            }
        }

        private void btnPares_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int desde = int.Parse(TextDesde.Text);
            int hasta = int.Parse(TextHasta.Text);

            if (desde > hasta)
            {
                MessageBox.Show("El valor 'Desde' debe ser menor o igual al valor 'Hasta'.");
                return;
            }

            Limpiar();
            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 == 0)
                {
                    lstNumeros.Items.Add(i);
                    chartNumeros.Series["Series1"].Points.AddXY(i, i);
                }
            }
        }

        private void btnImpares_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int desde = int.Parse(TextDesde.Text);
            int hasta = int.Parse(TextHasta.Text);

            if (desde > hasta)
            {
                MessageBox.Show("El valor 'Desde' debe ser menor o igual al valor 'Hasta'.");
                return;
            }

            Limpiar();
            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 != 0)
                {
                    lstNumeros.Items.Add(i);
                    chartNumeros.Series["Series1"].Points.AddXY(i, i);
                }
            }
        }

        private void btnPrimos_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int desde = int.Parse(TextDesde.Text);
            int hasta = int.Parse(TextHasta.Text);

            if (desde > hasta)
            {
                MessageBox.Show("El valor 'Desde' debe ser menor o igual al valor 'Hasta'.");
                return;
            }

            Limpiar();
            for (int i = desde; i <= hasta; i++)
            {
                if (EsPrimo(i))
                {
                    lstNumeros.Items.Add(i);
                    chartNumeros.Series["Series1"].Points.AddXY(i, i);
                }
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(TextDesde.Text) || string.IsNullOrWhiteSpace(TextHasta.Text))
            {
                MessageBox.Show("Debe ingresar un valor en ambos campos.");
                return false;
            }

            if (!int.TryParse(TextDesde.Text, out _) || !int.TryParse(TextHasta.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
                return false;
            }

            return true;
        }

        private void Limpiar()
        {
            lstNumeros.Items.Clear();
            chartNumeros.Series["Series1"].Points.Clear();
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}
