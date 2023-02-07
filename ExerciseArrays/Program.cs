using System;
using System.Linq;

namespace ExerciseArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] people = new int[wagons];
            int totalPeople = 0;
            for (int i = 0; i < wagons; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                totalPeople += people[i];
            }
            Console.WriteLine(string.Join(" ",people));
            Console.WriteLine(totalPeople);
        }
    }
}
