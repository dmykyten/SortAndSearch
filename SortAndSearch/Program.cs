using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSearch
{
    class Program
    {
        public static int[] GenerateArray(int size)                                 
        {
            if (size <= 0)
            {
                Console.Write("incorrect size");
                throw new ArgumentException();
            }
            int[] result = new int[size];
            Random random = new Random();
            for (int i = 0; i != result.Length; i++)
                result[i] = random.Next(size + 1);
            return result;
        }
        public static void PrintToConsole(int[] arr)                                //method to print array 
        {
            foreach(var value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Sort.\nPrint size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //var watch1 = System.Diagnostics.Stopwatch.StartNew();                 //playing with Stopwatch
            int[] unsorted = GenerateArray(size);
            //watch1.Stop();
            //var elapsedTime = watch1.Elapsed.TotalSeconds.ToString("0.###");
            //Console.WriteLine(elapsedTime);
            Console.WriteLine("Unsorted generated array.\n-----------------------");
            PrintToConsole(unsorted);
            Console.WriteLine("-----------------------");
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            MergeSort obj1 = new MergeSort(unsorted);                               //sorting
            int[] sorted = obj1.Sort();
            Console.WriteLine("Sorted generated array.\n-----------------------");
            PrintToConsole(sorted);
            Console.WriteLine("-----------------------\nSearch.");
            BinarySearch obj2 = new BinarySearch(sorted);
            Console.Write("Print value:");
            int? index = obj2.FindValueIndex(int.Parse(Console.ReadLine()));
            if (index != null)
                Console.Write("\nFound at index:" + index);
            //watch.Stop();
            //var elapsedTime1 = watch.Elapsed.TotalSeconds.ToString("0.###");
            //Console.WriteLine(elapsedTime);
            Console.ReadKey();
        }
    }
}
