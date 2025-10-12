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
    public partial class Problema4 : Form
    {
        List<double> ventas = new List<double>();

        public Problema4()
        {
            InitializeComponent();
            txtCant.KeyDown += TxtCant_KeyDown;
        }
        private void TxtCant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarVenta();
                e.SuppressKeyPress = true;
            }
        }
        private void AgregarVenta()
        {
            if (ventas.Count >= NumVen.Value)
            {
                MessageBox.Show("Ya estan tdas las Ventas seleccionadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (double.TryParse(txtCant.Text, out double importe))
            {
                ventas.Add(importe);
                ltsCantidad.Items.Add(importe);
                txtCant.Clear();
                txtCant.Focus();
                if (ventas.Count == NumVen.Value)
                {
                    MessageBox.Show("Has ingresado todas las ventas , ahora Importe", "informacon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bntImporte_Click(object sender, EventArgs e)
        {
            if (ventas.Count == 0)
            {
                MessageBox.Show("No hay importes ingresados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<double> importesRa = ventas.Where(v => v >= 75 && v <= 215).ToList();

            if (importesRa.Count == 0)
            {
                MessageBox.Show("No hay importes dentro del rango de $75 a $215.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DgbCompleto.DataSource = ventas.Where(v => v >= 75 && v <= 215).Select(v => new { Importe = v }).ToList();
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            List<double> importesOrdenados = ventas.Where(v => v >= 75 && v <= 215).OrderBy(v => v).ToList();

            if (importesOrdenados.Count == 0)
            {
                MessageBox.Show("No hay importes dentro del rango de $75 a $215.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DgbOrdenado.DataSource = importesOrdenados.Select(v => new { Importe = v }).ToList();
        }
        //no me deja quitarlos
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void NumVen_ValueChanged(object sender, EventArgs e) { }

        private void txtCant_TextChanged(object sender, EventArgs e) { }

        private void ltsCantidad_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ventas.Clear();
            ltsCantidad.Items.Clear();
            DgbCompleto.DataSource = null;
            DgbOrdenado.DataSource = null;
            txtCant.Clear();
            NumVen.Value = 0;
            txtCant.Focus();
            MessageBox.Show("El formulario ha sido reiniciado.", "Refrescar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
