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
            static void tekenRoodBlokje(string spacer)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(spacer);
            }

            static void tekenGroenBlokje(string spacer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(spacer);
            }

            static void tekenRodeLijn(string spacer)
            {
                for (int i = 0; i < 4; i++)
                {
                    tekenRoodBlokje(spacer);
                }
                Console.WriteLine("");
            }

            static void tekenRoodGroeneLijn(string spacer)
            {
                tekenRoodBlokje(spacer);
                tekenGroenBlokje(spacer);
                tekenGroenBlokje(spacer);
                tekenRoodBlokje(spacer);
                Console.WriteLine("");
            }

            // teken lijn 1 (4 rode blokjes)
            tekenRodeLijn("-");

            // teken lijn 2 & 3 (1 rood blokje, 3 groene blokjes en terug 1 rood blokje)
            for (int i = 0; i < 2; i++)
            {
                tekenRoodGroeneLijn("-");
            }

            // teken lijn 4 (4 rode blokjes)
            tekenRodeLijn("-");

            // console kleur terug naar origineel
            Console.ResetColor();
        }
    }
}
