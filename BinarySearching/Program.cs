using System;

namespace BinarySearching
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[50];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(-100, 100);
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            try
            {
                Console.WriteLine(bsearch(arr, 3, 0, arr.Length));
                Console.WriteLine(bsearch(new[] { -1, -1, 0, 1, 1, 3, 3, 3, 4, 5, 6, 7, 7, 7, 7, 8, 8 }, 7, 0, 17));
                Console.WriteLine(bsearch(null, 7, 0, 17));
            }
            catch (Exception e)
            {
                Console.WriteLine("System.ArgumentNullException: Значение не может быть неопределенным.");
            }
            Console.ReadKey();
        }

        private static int? bsearch(int[] array, int x, int left, int right)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (x >= array[array.Length - 1])
                return null;
            if (x < array[0])
                return 0;
            int middleResult = 0;
            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (x < array[middle])
                {
                    right = middle - 1;
                }
                else if (x >= array[middle])
                {
                    left = middle + 1;
                }
                middleResult = left;
            }
            return middleResult;
        }
    }
}
