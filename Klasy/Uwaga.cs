using System;
using System.Windows.Forms;
using System.Drawing;

namespace POSK3.Klasy
{
    static class Uwaga
    {
        private const int prawdopodobienstwoOstrzezenia = 15;
        private const int prawdopodobienstwoPrawieOstrzezenia = 15;
        private const int iloscOstrzezen = 4;
        private const int iloscPrawieOstrzezen = 4;
        private static Random losoweZdarzenie = new Random(DateTime.Now.Millisecond);

        public static bool CzyOstrzegac()
        {
            var szansa = losoweZdarzenie.Next(1, 100);
            if (szansa <= prawdopodobienstwoOstrzezenia) return true;
            else return false;
        }

        public static bool CzyPrawieOstrzegac()
        {
            var szansa = losoweZdarzenie.Next(1, 60);
            if (szansa <= prawdopodobienstwoPrawieOstrzezenia) return true;
            else return false;
        }

        public static int LosoweZdarzenie()
        {
            int szansa = losoweZdarzenie.Next(1, iloscOstrzezen);
            return szansa;
        }

        public static int LosowePrawieZdarzenie()
        {
            int szansa = losoweZdarzenie.Next(1, iloscPrawieOstrzezen);
            return szansa;
        }

        public static void OstrzezenieInfo(Label infoLabel)
        {
            infoLabel.Text = "Nie jest git!";
            infoLabel.ForeColor = Color.Red;
        }

        public static void PrawieOstrzezenieInfo(Label infoLabel)
        {
            if (infoLabel.ForeColor != Color.Red)
            {
                infoLabel.Text = "Uwaga!";
                infoLabel.ForeColor = Color.Yellow;
            }
        }

        public static void BrakOstrzezenieInfo(Label infoLabel)
        {
            infoLabel.Text = "Jest git!";
            infoLabel.ForeColor = Color.Green;
        }
    }
}
