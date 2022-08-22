using System;
using SeeSharpOne.Helpers;

namespace SeeSharpOne
{
    [Author("Maroš Čergeť")]
    [Receiver("VEEAM")]
    class Program
    {
        // process killing attributes
        private string trackedProcessName = null;
        private int specifiedTresholdInMinutes = 1;

        // program specific attributes
        private readonly char exitChar = 'q';


        static void Main(string[] args)
        {
            Console.WriteLine("Test 1");

            Console.ReadKey();
        }
    }
}
