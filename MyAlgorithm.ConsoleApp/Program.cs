using System;

namespace MyAlgorithm.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ascending order");
            int[] data = { 5, 4, 2, 1, 3 };
            int[] numbers = MyAlgorithms.MyAlgorithms.SelectionSort(data);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
