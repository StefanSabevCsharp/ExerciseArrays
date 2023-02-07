using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            
            string command = Console.ReadLine();
            while (command != "Clone them!" || lenght <= 5)
            {
                int[] sequence = command.Split("!").Select(int.Parse).ToArray();
                int startIndex = 0;
                int bestSum = 0;
                int currentIndex = 0;
                int count = 0;

                for (int i = 0; i < sequence.Length; i++)
                {
                        startIndex = currentIndex;
                    // 1 1 0 1 1 
                    if (sequence[i] == 1)
                    {
                        currentIndex = sequence[i];
                        count = 0;
                        while (sequence[i] == 1 && i < sequence.Length)
                        {
                            count++;
                            i++;
                        }
                    }
                    
                }



                command = Console.ReadLine();

            }
            
        }
    }
}
