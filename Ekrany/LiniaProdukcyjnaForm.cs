using POSK3.Klasy;
using System;
using System.Windows.Forms;

namespace POSK3.Ekrany
{
    public partial class LiniaProdukcyjnaForm : Form
    {
        Form OknoRodzic;
        public LiniaProdukcyjnaForm(Form OknoRodzic)
        {
            this.OknoRodzic = OknoRodzic;
            InitializeComponent();

            PredWentInfoLabel.Text = "Poprawna Wartość";
            WykProcInfoLabel.Text = "Poprawna Wartość";
            TempProcInfoLabel.Text = "Poprawna Wartość";
        }

        private int licznik = 0;
        private int jakDlugoTempProc = 0;
        private int jakDlugoWykProc = 0;
        private int jakDlugoPredWiatr = 0;
        private bool przegrana = false;

        private bool czyOstrzeganoTemp = false;
        private bool czyOstrzeganoWyk = false;
        private bool czyOstrzeganoPred = false;

        private void WyjscieButton_Click(object sender, EventArgs e)
        {
            LosoweZdarzenieTimer.Enabled = false;
            OknoRodzic.Visible = true;
            this.Close();
        }

        private void JakDlugoPredTimer_Tick(object sender, EventArgs e)
        {
            jakDlugoPredWiatr++;
            if (!przegrana) ZepsutaLinia(jakDlugoPredWiatr);
        }

        private void LosoweZdarzenieTimer_Tick(object sender, EventArgs e)
        {
            licznik++;
            if (Uwaga.CzyOstrzegac())
            {
                switch (Uwaga.LosoweZdarzenie())
                {
                    case 1:
                        if (czyOstrzeganoTemp)
                        {
                            Uwaga.OstrzezenieInfo(TempProcInfoLabel);
                            if (!JakDlugoTempTimer.Enabled)
                            {
                                jakDlugoTempProc = 0;
                                JakDlugoTempTimer.Enabled = true;
                                JakDlugoTempTimer.Start();
                            }
                        }
                        break;
                    case 2:
                        if (czyOstrzeganoWyk)
                        {
                            Uwaga.OstrzezenieInfo(WykProcInfoLabel);
                            if (!JakDlugoWykTimer.Enabled)
                            {
                                jakDlugoWykProc = 0;
                                JakDlugoWykTimer.Enabled = true;
                                JakDlugoWykTimer.Start();
                            }
                        }
                        break;
                    case 3:
                        if (czyOstrzeganoPred)
                        {
                            Uwaga.OstrzezenieInfo(PredWentInfoLabel);
                            if (!JakDlugoPredTimer.Enabled)
                            {
                                jakDlugoPredWiatr = 0;
                                JakDlugoPredTimer.Enabled = true;
                                JakDlugoPredTimer.Start();
                            }
                        }
                        break;
                    default:
                        MessageBox.Show("Error, skonatkuj się z zarządzą programu");
                        break;
                }
            }
            if ((licznik >= 30) && (!przegrana) && (!Logika.czAktywnyStan))
            {
                Logika.czAktywnyStan = true;
                new CzyZywyUzytkownikForm(OknoRodzic, this).ShowDialog();
                licznik = 0;
            }
        }

        private void JakDlugoTempTimer_Tick(object sender, EventArgs e)
        {
            jakDlugoTempProc++;
            if (!przegrana) ZepsutaLinia(jakDlugoTempProc);
        }

        private void JakDlugoWykTimer_Tick(object sender, EventArgs e)
        {
            jakDlugoWykProc++;
            if (!przegrana) ZepsutaLinia(jakDlugoWykProc);
        }

        private void PredWentButton_Click(object sender, EventArgs e)
        {
            Uwaga.BrakOstrzezenieInfo(PredWentInfoLabel);
            JakDlugoPredTimer.Stop();
            JakDlugoPredTimer.Enabled = false;
            jakDlugoPredWiatr = 0;
            czyOstrzeganoPred = false;
        }

        private void WykProcButton_Click(object sender, EventArgs e)
        {
            Uwaga.BrakOstrzezenieInfo(WykProcInfoLabel);
            JakDlugoWykTimer.Stop();
            JakDlugoWykTimer.Enabled = false;
            jakDlugoWykProc = 0;
            czyOstrzeganoWyk = false;
        }

        private void TempProcButton_Click(object sender, EventArgs e)
        {
            Uwaga.BrakOstrzezenieInfo(TempProcInfoLabel);
            JakDlugoTempTimer.Stop();
            JakDlugoTempTimer.Enabled = false;
            jakDlugoTempProc = 0;
            czyOstrzeganoTemp = false;
        }

        private void PrzerwaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brak zezwolenia na przerwę.");
        }

        private void LosoweOstrzezenieTimer_Tick(object sender, EventArgs e)
        {
            if (Uwaga.CzyOstrzegac())
            {
                switch (Uwaga.LosowePrawieZdarzenie())
                {
                    case 1:
                        Uwaga.PrawieOstrzezenieInfo(PredWentInfoLabel);
                        czyOstrzeganoPred = true;
                        break;
                    case 2:
                        Uwaga.PrawieOstrzezenieInfo(TempProcInfoLabel);
                        czyOstrzeganoTemp = true;
                        break;
                    case 3:
                        Uwaga.PrawieOstrzezenieInfo(WykProcInfoLabel);
                        czyOstrzeganoWyk = true;
                        break;
                    default:
                        MessageBox.Show("Error, skonatkuj się z zarządzą programu");
                        break;
                }
            }
        }

        private void ZepsutaLinia(int jakDlugoOstrzegano)
        {
            if (jakDlugoOstrzegano >= 15)
            {
                if (this.Enabled)
                {
                    JakDlugoPredTimer.Stop();
                    JakDlugoPredTimer.Enabled = false;

                    JakDlugoWykTimer.Stop();
                    JakDlugoWykTimer.Enabled = false;

                    JakDlugoTempTimer.Stop();
                    JakDlugoTempTimer.Enabled = false;
                    przegrana = true;

                    new PorazkaForm(OknoRodzic, this).ShowDialog();
                }
            }
        }

        private void LiniaProdukcyjnaForm_Load(object sender, EventArgs e)
        {
            LosoweZdarzenieTimer.Enabled = true;
        }
    }
}
