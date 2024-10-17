/* rommelzin
 *
 * 2024 - 2025 Patrick Lanove
 * Electronica/ICT - Programming Principles
 *
 * Hoofdstuk x, oefening x
 */

namespace zommelzin
{
    internal class Program
    {
        static void Main()
        {
            string kleur;
            Console.WriteLine("Geef je favoriete kleur:");
            kleur = Console.ReadLine();

            string eten;
            Console.WriteLine("Geef je favoriete eten:");
            eten = Console.ReadLine();

            string auto;
            Console.WriteLine("Geef je favoriete auto");
            auto = Console.ReadLine();

            string boek;
            Console.WriteLine("Geef je favoriete boek");
            boek = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Je favoriete kleur is "+ eten +" . Je eet graag "+ auto +" . Je lievelingsfilm is "+ boek +" en je favoriete boek is "+ kleur);
        }
    }
}
