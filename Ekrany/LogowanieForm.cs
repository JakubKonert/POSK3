using POSK3.Klasy;
using System;
using System.Windows.Forms;

namespace POSK3.Ekrany
{
    public partial class LogowanieForm : Form
    {
        public LogowanieForm()
        {
            InitializeComponent();
        }

        private void ZalogujButtom_Click(object sender, EventArgs e)
        {
            if (Logowanie.czyZalogowano(LoginTextBox.Text, HasłoTextBox.Text))
            {
                this.Visible = false;
                new LiniaProdukcyjnaForm(this).ShowDialog();        
            }
            else { MessageBox.Show("Wprowadzono błędne dane"); }
        }

        private void LogowanieForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            var klawisz = e.KeyChar;
            if (klawisz == 'q')
                this.Close();
        }

        private void LogowanieForm_Load(object sender, EventArgs e)
        {

        }
    }
}
