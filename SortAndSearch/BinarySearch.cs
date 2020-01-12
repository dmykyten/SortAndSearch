using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSearch
{
    class BinarySearch
    {
        private int[] arr;
        private int requestedValue;
        public BinarySearch(int[] arr)
        {
            this.arr = arr;
        }
        private int? Split(int startPoint, int endPoint)
        { 
            int middle = (int)Math.Round((double)(startPoint + endPoint) / 2, MidpointRounding.AwayFromZero);
            if (requestedValue < arr[middle] && middle != 0)
            {
                return Split(startPoint, middle - 1);
            }
            if (requestedValue > arr[middle] && middle != endPoint)
            {
                return Split(middle + 1, endPoint);
            }
            if (requestedValue == arr[middle])
            {
                return middle;
            }
            else
            {
                Console.WriteLine("Not found");
                return new int?();
            }
        }
        public int? FindValueIndex(int requestedValue)
        {
            this.requestedValue = requestedValue;
            return Split(0, arr.Length - 1);
        }
    }
}
