namespace SzyfrCezara
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Litery = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Console.WriteLine("Wpisz słowo Dużymi literamo do zaszyfrwrowania");
            string słowo = Console.ReadLine();
            char[] szyfr = słowo.ToCharArray();

            char[] Wiadomość = new char[szyfr.Length];

            int i;
            for (i = 0; i < szyfr.Length; i++)
            {
                char Sekret = szyfr[i];
                int index = Array.IndexOf(Litery, Sekret);
                int Pozycja = (index += 3) % 26;
                char MOC = Litery[Pozycja];
                Wiadomość[i] = MOC;
            }

            string Tajnesłowo = String.Join("", Wiadomość);
            Console.WriteLine(Tajnesłowo);


            char[] Litera = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Console.WriteLine("Wpisz słowo Dużymi literamo do odszyfrwrowania");
            string Słowo = Console.ReadLine();
            char[] deszyfr = Słowo.ToCharArray();

            char[] Maraton = new char[deszyfr.Length];

            int a;
            for (a = 0; a < deszyfr.Length; a++)
            {
                char sekret = deszyfr[a];
                int dex = Array.IndexOf(Litera, sekret);
                int Pozycje = (dex -= 3) % 26;
                char MANTO = Litera[Pozycje];
                Maraton[a] = MANTO;
            }

            string Odtajnionesłowo = String.Join("", Maraton);
            Console.Write(Odtajnionesłowo);
        }
    }
}
