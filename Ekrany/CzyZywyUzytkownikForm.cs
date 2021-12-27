using System;
using System.Windows.Forms;

namespace POSK3.Ekrany
{
    public partial class CzyZywyUzytkownikForm : Form
    {
        Form OknoRodzic;
        Form OknoGlowne;
        private int CzasLicznika = 0;
        public CzyZywyUzytkownikForm(Form OknoRodzic, Form OknoGlowne)
        {
            this.OknoRodzic = OknoRodzic;
            this.OknoGlowne = OknoGlowne;
            InitializeComponent();
        }

        private void AktywnyButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZywyUzytkownikTimer_Tick(object sender, EventArgs e)
        {
            CzasLicznika++;
            PozostalyCzasLabel.Text = $"Zostaniesz wylogowany za {15-CzasLicznika} sekund. Wciśnij przycisk, aby temu zapobiec.";
            if (CzasLicznika >= 15)
            {
                OknoGlowne.Close();
                OknoRodzic.Show();
                this.Close();
            }
        }
    }
}
