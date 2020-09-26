using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numHeads = 0, numTails = 0;
            double percentHeads, percentTails;

            for (int i = 1; i <= 8; i++)
            {
                char toss;
                Console.Write("Toss number " + i + ":");
                toss = Console.ReadKey().KeyChar;
                if (toss == 'h')
                {
                    numHeads++;
                }
                else if (toss == 't')
                {
                    numTails++;
                }
                else
                {
                    Console.WriteLine("Please enter either h or t");
                }
                Console.WriteLine();
            }
            percentHeads = (double)(numHeads * 100) / 8;
            percentTails = (double)(numTails * 100) / 8;

            Console.WriteLine("Number of heads: " + numHeads);
            Console.WriteLine("Number of Tails: " + numTails);
            Console.WriteLine("Percent heads: " + percentHeads);
            Console.WriteLine("Percent Tails: " + percentTails);
        }
    }
}
