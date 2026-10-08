using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aguaportable 
{
    public partial class Form1 : Form
    {
        private object txtNombre;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double metros;

            // Validar nombre
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del usuario.");
                txtNombre.Focus();
                return;
            }

            // Validar metros cúbicos
            if (!double.TryParse(txtMetros.Text, out metros) || metros < 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de metros cúbicos.");
                txtMetros.Focus();
                return;
            }

            double total = 0;
            string tarifa = "";

            // Tarifas de ejemplo por tramos
            if (metros <= 10)
            {
                total = metros * 0.20;
                tarifa = "$0.20 por m³";
            }
            else if (metros <= 20)
            {
                total = (10 * 0.20) + ((metros - 10) * 0.30);
                tarifa = "$0.20 hasta 10 m³ + $0.30 por m³ adicional";
            }
            else if (metros <= 30)
            {
                total = (10 * 0.20) +
                        (10 * 0.30) +
                        ((metros - 20) * 0.40);

                tarifa = "$0.40 por m³ adicional después de 20 m³";
            }
            else
            {
                total = (10 * 0.20) +
                        (10 * 0.30) +
                        (10 * 0.40) +
                        ((metros - 30) * 0.50);

                tarifa = "$0.50 por m³ adicional después de 30 m³";
            }

            // Mostrar resultados
            object lblMetrosText = metros.ToString("0.00") + " m³";
           object lblTarifaText = tarifa;
            object lblTotalText = total.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           object txtNombre Clear();
           object txtMetros Clear();

            object lblMetrosText = "0.00 m³";
           object lblTarifaText = "0.00";
           object lblTotalText = "0.00";

            txtNombre.Focus();
        }

        private object Clear()
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    internal class txtMetros
    {
        internal static string Text;

        internal static void Focus()
        {
            throw new NotImplementedException();
        }
    }
}
