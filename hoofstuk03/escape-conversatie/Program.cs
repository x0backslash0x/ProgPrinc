/* escape-conversatie
 * 
 * 2024 - 2025 Patrick Lanove
 * Electronica/ICT - Programming Principles
 * 
 * Hoofdstuk 3, oefening 3
 */

namespace escape_conversatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string personage1 = "Alice";
            string personage2 = "Bob";

            string dialoog = $"{personage1}: \"Hoe gaat het met je?\"\n\t{personage2}: \"Goed, dank je! Hoe gaat het met jou?\"\n{personage1}: \"Ook goed, bedankt dat je het vraagt.\"";

            Console.WriteLine(dialoog);
        }
    }
}