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
            int B = 494;   // B4
            int Ab = 831;  // G#5/Ab5
            int A5 = 880;  // A5
            // Define the following notes in a lower register (one octave down)
            int G = 392;   // G4
            int Eb = 311;  // D#4/Eb4
            int Bb = 233;  // A#3/Bb3
            int D = 294;   // D4
            int C = 261;   // C4
            int F = 349;   // F4
            int E = 329;   // E4

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
