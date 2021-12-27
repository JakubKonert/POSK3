

namespace POSK3.Klasy
{
    public static class Logowanie
    {
        private static string Login = "Admin";
        private static string Haslo = "Password";

        public static bool czyZalogowano(string LoginWprowadzony, string HasloWprowadzone)
        {
            if ((Login == LoginWprowadzony) && (Haslo == HasloWprowadzone)) return true;
            return false;
        }
    }
}
