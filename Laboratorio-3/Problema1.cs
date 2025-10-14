using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3
{
    public partial class Problema1 : Form
    {
        public Problema1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMontoIni_TextChanged(object sender, EventArgs e)
        {

        }

        int s = 0;
        private void btnAbrirC_Click(object sender, EventArgs e)
        {
            s = Convert.ToInt32(txtMontoIni.Text);
            lstDepositos.Items.Add(s);
            btnAbrirC.Enabled = false;
            btnAbrirC.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int k = 0;
            k = Convert.ToInt32(txtSaldo.Text);
            if (rdbDepositos.Checked)
            {
                s = s + k;
                lstDepositos.Items.Add(k);
            }
            else if (rdbRetiros.Checked)
            {
                if (s < k)
                {
                    MessageBox.Show("Execede el limte de la cuenta, ingrese una menor cantidad.");
                    return;
                }
                 s = s - k;
                lstRetiros.Items.Add(k);
            }
            txtSaldoActual.Text = s.ToString();
        }

        private void txtSaldoActual_TextChanged(object sender, EventArgs e)
        {

        }
        private void lstRetiros_DoubleClick_1(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Desa eliminar el elemento seleccionado", "Confirmar", MessageBoxButtons.YesNo);

            if (x == DialogResult.Yes)
            {
                lstRetiros.Items.RemoveAt(lstRetiros.SelectedIndex);
            }
        }
    }
}