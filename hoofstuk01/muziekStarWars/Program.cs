/* muziekStarWars
 *
 * 2024 - 2025 Patrick Lanove
 * Electronica/ICT - Programming Principles
 *
 * Hoofdstuk 1, oefening 7 (eigen uitbreiding)
 * 
 * Dit programma probeert het intro muziekje uit Star Wars na te spelen dmv beep deuntjes
 */

namespace muziekStarWars
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main()
        {
            // Helper function to wrap Console.Beep
            static void Beep(int frequency, int duration)
            {
                Console.Beep(frequency, duration);
            }

            // Define the notes in Hz
            int A = 440;   // A4
            int Bb = 466;  // A#4/Bb4
            int B = 494;   // B4
            int C = 523;   // C5
            int D = 587;   // D5
            int Eb = 622;  // D#5/Eb5
            int E = 659;   // E5
            int F = 698;   // F5
            int G = 784;   // G5
            int Ab = 831;  // G#5/Ab5
            int A5 = 880;  // A5

            // Note durations
            int half = 500;
            int quarter = 250;
            int eighth = 125;
            int dottedQuarter = 375;
            int whole = 1000;

            // Start of the Star Wars Main Title theme //

            // First phrase
            Beep(G, half);
            Beep(G, half);
            Beep(G, half);
            Beep(Eb, dottedQuarter);
            Beep(Bb, eighth);
            Beep(G, half);
            Beep(Eb, dottedQuarter);
            Beep(Bb, eighth);
            Beep(G, whole);

            Thread.Sleep(quarter); // Pause

            // Second phrase
            Beep(D, half);
            Beep(D, half);
            Beep(D, half);
            Beep(Eb, dottedQuarter);
            Beep(Bb, eighth);
            Beep(G, half);
            Beep(Eb, dottedQuarter);
            Beep(Bb, eighth);
            Beep(G, whole);

            Thread.Sleep(quarter); // Pause

            // Third phrase
            Beep(G, half);
            Beep(G, half);
            Beep(F, half);
            Beep(E, dottedQuarter);
            Beep(Eb, eighth);
            Beep(Bb, half);
            Beep(D, dottedQuarter);
            Beep(Bb, eighth);
            Beep(G, whole);
        }
    }
}
