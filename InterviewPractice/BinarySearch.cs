using System;

namespace binary_search
{
    public class BinarySearch
    {
        public static int FindNumber(int[] numbers, int search) {
            var closest = -1;
            var found = FindNumber(numbers, search, 0, numbers.Length - 1, closest);
            Console.WriteLine($"Searched for {search} in {String.Join(",", numbers)}, found {found}.");
            return found;
        }

        public static int FindNumber(int[] numbers, int search, int start, int end, int closest) {
            var middle = (end + start) / 2;
            if (end < start) { // nothing found :(
                return closest;
            }
            if (numbers[middle] == search) {
                return search;
            } else if (search < numbers[middle]) {
                return FindNumber(numbers, search, start, middle - 1, closest);
            } else {
                closest = numbers[middle];
                return FindNumber(numbers, search, middle + 1, end, closest);
            }
        }
    }
}
