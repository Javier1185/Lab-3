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
{ public partial class Problema2 : Form
        {
            List<int> listaNumeros = new List<int>();
            public Problema2()
            {
                InitializeComponent();
            }

            private void Problema2_Load(object sender, EventArgs e)
            {
                if (dgvNum == null || textNum == null)
                {
                    MessageBox.Show("Error: falta dgvNumeros o txtNumero. Revisa los nombres en el diseñador (Properties -> (Name)).");
                    return;
                }

                dgvNum.AllowUserToAddRows = false;
                dgvNum.Rows.Clear();
                dgvNum.ColumnCount = 1; // Cambia a 1 columna
                dgvNum.Columns[0].HeaderText = "Números";
                dgvNum.AutoGenerateColumns = true;
                textNum.Clear();

            }
            private void btnIngresarNum_Click(object sender, EventArgs e)
            {
                if (int.TryParse(textNum.Text.Trim(), out int numero))
                {
                    listaNumeros.Add(numero);
                    ActualizarDataGV();
                    textNum.Clear();
                }
                else
                {
                    MessageBox.Show(" ingresar un número valido");
                }
            }

            private void ActualizarDataGV()
            {
                var bindingList = new BindingSource();
                bindingList.DataSource = listaNumeros.Select(x => new { Numero = x }).ToList();
                dgvNum.DataSource = bindingList;
            }

            private void btmEliminacionN_Click(object sender, EventArgs e)
            {
                if (int.TryParse(textNum.Text, out int numero))
                {
                    listaNumeros.RemoveAll(n => n == numero);
                    ActualizarDataGV();
                    textNum.Clear();
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido para eliminar.");
                }


            }

            private void btmAleatorio_Click(object sender, EventArgs e)
            {
                Random rnd = new Random();
                listaNumeros.Clear();
                for (int i = 0; i < 5; i++)
                {
                    listaNumeros.Add(rnd.Next(1, 100));
                }
                ActualizarDataGV();
            }

            private void dvgNum_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
        }
    }
       