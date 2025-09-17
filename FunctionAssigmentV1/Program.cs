namespace FunctionAssigmentV1
{
    internal class Program
    {
       /// <summary>
       /// Kysyy käyttäjän nimeä ja tarkistaa että ei ole tyhjä
       /// </summary>
       /// <returns>Palauttaa käyttäjän antaman nimen</returns>
        static string KysyNimi()
        {
            string name = "";
            while (true)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    break;
                else
                    Console.WriteLine("Name cannot be empty.");
            }

            return name;

        }
        /// <summary>
        /// Kysyy käyttäjän ikää ja tarkistaa sen postiiviseksi.
        /// </summary>
        /// <returns>Palauttaa positiivisen luvun.</returns>
        static int KysyIka()
        {
            int age = 0;
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out age) && age > 0)
                    break;
                else
                    Console.WriteLine("Please enter a positive integer.");
            }
            return age;
        }
        /// <summary>
        /// Tulostaa Käyttäjän nimen ja iän
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        static void TulostaNimiJaIka(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }
        /// <summary>
        /// Tarkistaa onko käyttäjä täysi-ikäinen
        /// </summary>
        /// <param name="age"></param>
        /// <returns>Palauttaa arvon</returns>
        static bool TarkistaTaysiIkainen (int age)
        {
        return age >= 18;
        }
        /// <summary>
        /// Vertailee käyttäjän nimeä nimeen "Matti"
        /// </summary>
        /// <param name="name"></param>
        /// <param name="compareTo"></param>
        static void compareName(string name, string compareTo)
        {
            if (name.Equals(compareTo, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"Your name matches '{compareTo}' (case-insensitive).");

            if (name.Equals(compareTo))
                Console.WriteLine($"Your name is exactly '{compareTo}' (case-sensitive).");
        }
        static void Main(string[] args)
        {
       
            string name = KysyNimi();
            int age = KysyIka();
            TulostaNimiJaIka(name, age);
            bool isFullAge = TarkistaTaysiIkainen(age);
            if (isFullAge)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            { 
                Console.WriteLine("You are not an adult."); 
            }

            compareName(name, "Matti");


        }
    }
}