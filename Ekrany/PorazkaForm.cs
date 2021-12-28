using System;
using System.Windows.Forms;

namespace POSK3.Ekrany
{
    public partial class PorazkaForm : Form
    {
        private int CzasWylogowanie = 0;
        Form OknoRodzic;
        Form OknoGlowne;
        public PorazkaForm(Form OknoRodzic, Form OknoGlowne)
        {
            this.OknoRodzic = OknoRodzic;
            this.OknoGlowne = OknoGlowne;

            InitializeComponent();

        }

        private void LicznikTimer_Tick(object sender, EventArgs e)
        {
            CzasWylogowanie++;
            OdliczanieWylogowaniaLabel.Text = $"Wylogowanie z systemu nastąpi za {10 - CzasWylogowanie}";
            if (CzasWylogowanie >= 10)
            {

                OknoRodzic.Visible = true;
                this.Close();
            }
        }

        private void PorazkaForm_Load(object sender, EventArgs e)
        {
            OknoGlowne.Close();
        }
    }
}
