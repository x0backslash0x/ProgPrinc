/* demos04
 * 
 * 2024 - 2025 Patrick Lanove
 * Electronica/ICT - Programming Principles
 * 
 * Hoofdstuk 4, demo's
 */

namespace demos04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** 1. CASTING **/
            /** 1.1. NARROWING **/
            // informatie achter de comma gaat verloren
            int mijngetal = (int)3.5;

            double kommagetal = 13.8;
            int kommaNietWelkom = (int)kommagetal;

            // dit zal een fout geven
            /*double hoofdMeting;
            int secundaireMeting;
            hoofdMeting = 20.4;
            secundaireMeting = hoofdMeting;*/

            double hoofdMeting;
            int secundaireMeting;
            hoofdMeting = 20.4;
            secundaireMeting = (int)hoofdMeting;

            /** 1.2. Widening **/
            int hoofdMeting;
            double secundaireMeting;
            hoofdMeting = 20;
            secundaireMeting = hoofdMeting; //secundaireMeting krijgt 20.0

            //** 2. Parsing **//
            // een string naar een int omzetten
            int numVal = Int32.Parse("-105");
            Console.WriteLine(numVal);

            // een int naar een string omzetten
            int getal = 5;
            string getalAlsString = getal.ToString();

            /** 3. Conversie **/
            // meer code dan casting of parsing. Convert() is een zwarte doos
            int getal = Convert.ToInt32(3.2); //double to int
            double anderGetal = Convert.ToDouble(5); //int to double
            bool isWaar = Convert.ToBoolean(1); //int to bool
            int leeftijd = Convert.ToInt32("19"); //string to int
            int andereLeeftijd = Convert.ToInt32(anderGetal); //double to int
        }
    }
