using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSearch
{
    public class MergeSort
    {
        private int[] unsorted;
        public MergeSort(int[] unsorted)
        {
            this.unsorted = unsorted;
        }
        int[] Merge(int[] leftHalf,int[] rightHalf)
        {
            int[] merged = new int[leftHalf.Length + rightHalf.Length];
            int leftIter = 0, rightIter = 0;
            while (leftIter < leftHalf.Length || rightIter < rightHalf.Length)
            {
                bool leftFinished = leftIter == leftHalf.Length;
                bool rightFinished = rightIter == rightHalf.Length;

                if (!leftFinished && (rightFinished || leftHalf[leftIter] <= rightHalf[rightIter]))
                {
                    merged[leftIter + rightIter] = leftHalf[leftIter];
                    leftIter++;
                }
                else
                
                if(!rightFinished && (leftFinished || leftHalf[leftIter] >= rightHalf[rightIter]))
                {
                    merged[leftIter + rightIter] = rightHalf[rightIter];
                    rightIter++;
                }
            }
            return merged;
        }
        int[] Split(int startPoint, int endPoint)
        {
            if (endPoint > startPoint)
            {
                int middle = (int)Math.Floor((double)(startPoint + endPoint) / 2);
                return Merge(Split(startPoint, middle),Split(middle + 1, endPoint));
            }
            else
            {
                int[] arr = new int[1];
                arr[0] = unsorted[startPoint];
                return arr;
            }

        }
        public int[] Sort()
        {
            return Split(0, unsorted.Length - 1); 
        }
    }
}
