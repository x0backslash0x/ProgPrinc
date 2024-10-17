/* woordslinger
 *
 * 2024 - 2025 Patrick Lanove
 * Electronica/ICT - Programming Principles
 *
 * Hoofdstuk x, oefening x
 */

namespace woordslinger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("blauw");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("groen"); 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("rood");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("geel");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("rood");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("blauw");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("groen");

            Console.ResetColor();
        }
    }
}
