using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()  // 10 20  1 1 1 2 3 11 333
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            int longestindexStart = 0;
            int longestindexLenght = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                int currentIndexStart = i -1;
                int currentLenght = 1;
                while (i < numbers.Length && numbers[i] == numbers[i -1])
                {
                    currentIndexStart++;
                    
                    i++;

                }
                if (currentIndexStart > longestindexStart)
                {
                    longestindexStart = currentIndexStart;
                    longestindexLenght = currentLenght;
                }
                

            }

        }
    }
}
