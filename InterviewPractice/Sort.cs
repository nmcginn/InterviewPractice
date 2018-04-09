using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPractice
{
    public class Sort<T> where T: IComparable
    {
        public static T[] SortArray(T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) >= 0)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        public static T[] MergeSort(T[] array, int left, int right)
        {
            if (left < right)
            {
                var middle = (left + (right - 1)) / 2;
                var leftArray = MergeSort(array, left, middle);
                var rightArray = MergeSort(array, middle + 1, right);
                var result = Merge(array, left, middle, right);
                return result;
            }
            return array;
        }

        private static T[] Merge(T[] array, int left, int middle, int right)
        {
            var n1 = middle - left + 1;
            var n2 = right - middle;
            // create temporary arrays for the left & right sides
            var leftArray = new T[n1];
            var rightArray = new T[n2];
            for (var x = 0; x < n1; x++)
            {
                leftArray[x] = array[left + x];
            }
            for (var x = 0; x < n2; x++)
            {
                rightArray[x] = array[middle + 1 + x];
            }
            // merge the 2 temporary arrays together
            var i = 0;
            var j = 0;
            var k = left;
            while (i < n1 && j < n2)
            {
                if (leftArray[i].CompareTo(rightArray[j]) != 1)
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            // copy the remaining left-hand elements
            while(i < n1)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }
            // copy the remaining right-hand elements
            while(j < n2)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
            return array;
        }
    }
}
