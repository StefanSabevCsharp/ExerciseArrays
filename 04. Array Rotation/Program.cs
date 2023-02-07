using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            

            for (int i = 0; i < num.Length; i++)
            {
                bool isTop = true;

                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[j] >= num[i])
                    {
                        isTop = false;
                        break;
                    }

                }
                if (isTop)
                {
                    Console.Write($"{num[i] } ");
                }

            }
        }
    }
}
