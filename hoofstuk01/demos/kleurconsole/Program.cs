/* kleurconsole
 *
 * 2024 - 2025 Patrick Lanove
 * Electronica/ICT - Programming Principles
 *
 * Hoofdstuk 1, demo 2
 */

namespace kleurconsole
{
    internal class Program
{
    static void Main()
    {
        // code om de kleuren in de console te veranderen
        Console.WriteLine("Tekst in de standaard kleur");
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Zwart met gele achtergrond");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Rood met gele achtergrond");

        //kleur resetten
        Console.ResetColor();
        Console.WriteLine("Het programma sluit nu af");
    }
}
}