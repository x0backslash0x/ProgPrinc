/* system-information
 * 
 * 2024 - 2025 Patrick Lanove
 * Electronica/ICT - Programming Principles
 * 
 * Hoofdstuk 3, oefening 4
 */

namespace system_informatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int procCount = System.Environment.ProcessorCount;
            long workingSet = System.Environment.WorkingSet;
            string machineName = System.Environment.MachineName;
            string userName = System.Environment.UserName;
            bool isArch64 = System.Environment.Is64BitOperatingSystem;
            double workingSetMB = workingSet / Math.Pow(1024, 2); //1048576
            double workingSetGB = workingSet / Math.Pow(1024, 3); //1073741824
            // double values are not yet rounded

            Console.WriteLine($"Systeeminformatie voor {userName} op {machineName}:");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"\tAantal processors: {procCount}");
            Console.WriteLine($"\t64-bit besturingssysteem: {isArch64}");
            Console.WriteLine($"\tHuidige geheugengebruik: {workingSetMB} MB ({workingSetGB} GB)"); // resultaat moet afgerond worden tot 2 decimalen
            Console.WriteLine("--------------------------------------------------------");
        }
    }
}