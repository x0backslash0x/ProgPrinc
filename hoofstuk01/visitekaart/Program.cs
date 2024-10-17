/* visitekaart
 *
 * 2024 - 2025 Patrick Lanove
 * Electronica/ICT - Programming Principles
 *
 * Hoofdstuk 1, oefening 2
 */

namespace visitekaart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string voornaam;
            Console.WriteLine("Wat is je voornaam?");
            voornaam = Console.ReadLine();

            string achternaam;
            Console.WriteLine("Wat is je achternaam?");
            achternaam = Console.ReadLine();

            string adres;
            Console.WriteLine("Waar woon je?");
            adres = Console.ReadLine();

            string hobby;
            Console.WriteLine("Wat is je hobby?");
            hobby = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Goed. Hier volgt je visitekaartje");
            Console.WriteLine("");
            Console.WriteLine("Naam: " + voornaam + " " + achternaam);
            Console.WriteLine("Adres: " + adres);
            Console.WriteLine("Hobby: " + hobby);

        }
    }
}
