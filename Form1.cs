namespace Fase2_IsaccMestra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            if (txbcontrase�a.Text == "123")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Contrase�a incorrecta. Intente de nuevo");
            }
        }
    }
}