using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine()
                .Split();
            string[] array2 = Console.ReadLine()
                .Split();

            for (int i = 0; i < array1.Length; i++)
            {
                
                for (int j = 0; j < array2.Length; j++)
                {
                    
                    if (array2[j] == array1[i] )
                    {
                        Console.Write(array2[j] + " ");
                    }

                }

            }
        }
    }
}
