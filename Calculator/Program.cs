namespace Calculator
{
    internal class Program
    {
        /// <summary>
        /// Kysyy valitsemaan laskutyypin ja tarkistaa valinnan validiksi
        /// </summary>
        /// <returns>Palauttaa valinnan</returns>
        static int Choice1Check()
        {
            int choice1 = 0;
            while (true)
            {
                Console.Write("Valitse laskutoimitus: (1: Yhteenlasku, 2: Vähennyslasku, 3: Kertolasku, 4: Jakolasku)");
                string input = Console.ReadLine();
                if (int.TryParse(input, out choice1) && choice1 > 0 && choice1 < 5)
                    break;
                else
                    Console.WriteLine("Ei sopiva vaihtoetho. Syötä kokonaisluku 1-4.");
            }
            return choice1;
        }
        /// <summary>
        /// Kysyy ensimmäisen laskettavan luvun ja tarkistaa, että se on sopiva.
        /// </summary>
        /// <returns>Palauttaa ensimmäisen laskettavan luvun.</returns>
        static double Number1Check()
        {
            double number1 = 0;
            while (true)
            {
                Console.Write("Syötä ensimmäinen luku:");
                string input = Console.ReadLine();
                if (double.TryParse(input, out number1))
                    break;
                else
                    Console.WriteLine("Ei sopiva vaihtoetho. Syötä luku.");
            }
            return number1;
        }
        /// <summary>
        /// Kysyy toisen laskettavan luvun ja tarkistaa, että se on sopiva.
        /// </summary>
        /// <returns>Palauttaa ensimmäisen laskettavan luvun</returns>
        static double Number2Check()
        {
            double number2 = 0;
            while (true)
            {
                Console.Write("Syötä toinen luku:");
                string input = Console.ReadLine();
                if (double.TryParse(input, out number2))
                    break;
                else
                    Console.WriteLine("Ei sopiva vaihtoetho. Syötä luku.");
            }
            return number2;
        }
        /// <summary>
        /// Laskee yhteen annetut arvot.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Palauttaa yhteenlaskun tuloksen</returns>
        static double PlusLasku(double number1, double number2)
        {
            double calc1 = number1 + number2;
            return calc1;
        }
        /// <summary>
        /// Laskee vähennyslaskun annetuista arvoista.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Palauttaa vähennyslaksun tuloksen</returns>
        static double MinusLasku(double number1, double number2)
        {
            double calc2 = number1 - number2;
            return calc2;
        }
        /// <summary>
        /// Laskee kertolaskun annetuista arvoista.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Palauttaa kertolaskun tuloksen</returns>
        static double KertoLasku(double number1, double number2)
        {
            double calc3 = number1 * number2;
            return calc3;
        }
        /// <summary>
        /// Laskee jakolaskun annetuista arvoista.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Palauttaa jakolaskun tuloksen</returns>
        static double JakoLasku(double number1, double number2)
        {
            
            double calc4 = number1 / number2;

            return calc4;
        }
        /// <summary>
        /// Tarkistaa, minkä laskutyypin on valinnut ja valitsee ja tulostaa täten tuloksen. Myös tarkistaa, että ei voi jakaa nollalla.
        /// </summary>
        /// <param name="choice1"></param>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        static void TulostaTulos(int choice1, double number1, double number2)
        {
            if (choice1 == 1)
            {
                double calc1 = PlusLasku(number1, number2);
                Console.WriteLine($"Tulos: {number1} + {number2} = {calc1}");
            }
            else if (choice1 == 2)
            {
                double calc2 = MinusLasku(number1, number2);
                Console.WriteLine($"Tulos: {number1} - {number2} = {calc2}");
            }
            else if (choice1 == 3)
            {
                double calc3 = KertoLasku(number1, number2);
                Console.WriteLine($"Tulos: {number1} * {number2} = {calc3}");
            }
            else
            {
                double calc4 = JakoLasku(number1, number2);
                if (number2 != 0)
                {
                    Console.WriteLine($"Tulos: {number1} / {number2} = {calc4}");
                }
                else
                {
                    Console.WriteLine($"Virhe! Ei voi jakaa nollalla!");
                }
            }
        }
        /// <summary>
        /// Toteuttaa laskimen.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int choice1 = Choice1Check();
            double number1 = Number1Check();
            double number2 = Number2Check();
            TulostaTulos(choice1, number1, number2);

        }


    }
}
