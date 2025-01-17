using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Fase2_IsaccMestra
{
    public partial class Form3 : Form
    {
        private string nombre;
        private string cedula;
        private string genero;
        private string instrumento;
        private int dias;
        private decimal costoClase;
        private decimal totalMatricula;

        public Form3(string nombre, string cedula, string genero, string instrumento, int dias, decimal costoClase, decimal totalMatricula)
        {
            InitializeComponent();

            this.nombre = nombre;
            this.cedula = cedula;
            this.genero = genero;
            this.instrumento = instrumento;
            this.dias = dias;
            this.costoClase = costoClase;
            this.totalMatricula = totalMatricula;
            MostrarReporte();
        }

        private void MostrarReporte()
        {
            txestudiante.Text = nombre;
            txnumeroid.Text = cedula;
            txgenero.Text = genero;
            txcurso.Text = instrumento;
            txnumclases.Text = dias.ToString();
            txcostoclases.Text = costoClase.ToString("C");
            txtotal.Text = totalMatricula.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ingresoform = new Form2();
            this.Close();
            ingresoform.Show();
        }
    }
}
