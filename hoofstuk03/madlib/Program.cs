/* madlib
 * 
 * 2024 - 2025 Patrick Lanove
 * Electronica/ICT - Programming Principles
 * 
 * Hoofdstuk 3, oefening 1
 */

namespace _03_madlib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string naam;
            Console.WriteLine("Geef een naam");
            naam = Console.ReadLine();

            string znw;
            Console.WriteLine("Geef een zelfstandig naamwoord");
            znw = Console.ReadLine();

            string adj;
            Console.WriteLine("Geef een adjectief");
            adj = Console.ReadLine();

            string werkwoord;
            Console.WriteLine("Geef een werkwoord");
            werkwoord = Console.ReadLine();

            Console.WriteLine("Hier komt het!");
            Console.WriteLine($"Op een dag ging {naam} naar de AP Hogeschool. Hij zag daar een {adj} {znw} en vond dat zo grappig dat hij begon te {werkwoord}.");
        }
    }
}