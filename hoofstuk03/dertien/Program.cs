/* dertien
 * 
 * 2024 - 2025 Patrick Lanove
 * Electronica/ICT - Programming Principles
 * 
 * Hoofdstuk 3, oefening 2
 */

namespace dertien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int doosGrootte = 8;
            int aantalEieren = 124; // ook getest met 324
            int aantalDozen = aantalEieren / doosGrootte;
            int aantalRest = aantalEieren % doosGrootte;

            string bericht = $"{aantalEieren} eieren passen in {aantalDozen} dozen van {doosGrootte}. Daarbij zal je nog {aantalRest} eieren over hebben.";
            Console.WriteLine(bericht);
        }
    }
}