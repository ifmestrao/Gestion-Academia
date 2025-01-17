using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2_IsaccMestra
{
    public partial class Form2 : Form
    {
        private GestionEstudiantes estudiante;

        public Form2()
        {
            InitializeComponent();
        }

        public class GestionEstudiantes
        {
            public string Nombre { get; set; }
            public string Cedula { get; set; }
            public string Genero { get; set; }
            public string Instrumento { get; set; }
            public int Dias { get; set; }
            public decimal CostoPorClase { get; set; }
            public decimal TotalMatricula { get; private set; }

            public void CalcularCostoTotal()
            {
                TotalMatricula = Dias * CostoPorClase;
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text) || !txtid.Text.All(char.IsDigit))
            {
                MessageBox.Show("ID debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtnombre.Text) || !txtnombre.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Nombre debe contener solo letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbintrumento.SelectedItem == null)
            {
                MessageBox.Show("Seleccionar un instrumento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtclases.Text, out int dias) || dias <= 0)
            {
                MessageBox.Show("El número de clases debe ser un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!rdmasculino.Checked && !rdfemenino.Checked)
            {
                MessageBox.Show("Debe seleccionar un género.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (estudiante == null)
            {
                MessageBox.Show("Debe guardar los datos antes de calcular.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            estudiante.CalcularCostoTotal();

            Form3 form3 = new Form3(estudiante.Nombre, estudiante.Cedula, estudiante.Genero, estudiante.Instrumento, estudiante.Dias, estudiante.CostoPorClase, estudiante.TotalMatricula);
            form3.Show();
            this.Hide();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtid.Text) || !txtid.Text.All(char.IsDigit))
            {
                MessageBox.Show("ID debe contener solo números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtnombre.Text) || !txtnombre.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Nombre debe contener solo letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbintrumento.SelectedItem == null)
            {
                MessageBox.Show("Seleccionar un instrumento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtclases.Text, out int dias) || dias <= 0)
            {
                MessageBox.Show("El número de clases debe ser un valor numérico.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtcosto.Text, out decimal costoClase) || costoClase <= 0)
            {
                MessageBox.Show("El costo por clase debe ser un valor numérico.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdmasculino.Checked && !rdfemenino.Checked)
            {
                MessageBox.Show("Debe seleccionar un género.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            estudiante = new GestionEstudiantes
            {
                Nombre = txtnombre.Text,
                Cedula = txtid.Text,
                Genero = rdmasculino.Checked ? "Masculino" : "Femenino",
                Instrumento = cbintrumento.SelectedItem.ToString(),
                Dias = dias,
                CostoPorClase = costoClase
            };

            MessageBox.Show("Datos guardados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbintrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cbintrumento.SelectedItem.ToString())
            {
                case "Piano":
                    txtcosto.Text = "100000";
                    break;
                case "Guitarra":
                    txtcosto.Text = "80000";
                    break;
                case "Violín":
                    txtcosto.Text = "90000";
                    break;
                case "Batería":
                    txtcosto.Text = "85000";
                    break;
                case "Canto":
                    txtcosto.Text = "95000";
                    break;
                default:
                    txtcosto.Text = "0";
                    break;
            }
        }
    }
}

