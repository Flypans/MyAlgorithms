using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetPackageTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 30, 50, 9, 8, 2, 3 };
            int[] results = DulAlgorithm.Algorithm.SelectionSort(numbers);

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
