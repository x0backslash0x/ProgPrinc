/* tekening
 *
 * 2024 - 2025 Patrick Lanove
 * Electronica/ICT - Programming Principles
 *
 * Hoofdstuk x, oefening x
 */

namespace tekening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // teken lijn 1 (4 rode blokjes)
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("-");
            Console.Write("-");
            Console.Write("-");
            Console.Write("-");
            Console.WriteLine("-");

            // teken lijn 2 & 3 (1 rood blokje, 3 groene blokjes en terug 1 rood blokje)
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("-");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-");

            // teken lijn 4 (4 rode blokjes)
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("-");
            Console.Write("-");
            Console.Write("-");
            Console.Write("-");
            Console.WriteLine("-");

            // console kleur terug naar origineel
            Console.ResetColor();
        }
    }
}
