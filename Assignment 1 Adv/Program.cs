namespace Assignment_1_Adv
{
    internal class Program
    {


        static void Main(string[] args)
        {
            #region Question 1
            /* Improvements of the optimized version over the original
             1- Early Termination:

             Original Bubble Sort: The original Bubble Sort always performs n passes (where n is the number of elements)
            , even if the list gets sorted before completing all passes.
             Optimized Bubble Sort: The optimized version uses a swapped flag to detect if any swaps were made during a pass.
            If no swaps are made, the algorithm terminates early, indicating the list is already sorted.
            
             
             2-Bidirectional Passes:

             Original Bubble Sort: Moves elements in only one direction (from the beginning to the end of the list) in each pass.
             Optimized Bubble Sort: Moves elements in both directions, alternating between forward and backward passes. 
            This helps in moving large elements towards the end and small elements towards the start more quickly, reducing the number of passes required.
             
            3-Reduced Range of Comparison:

            Original Bubble Sort: Reduces the range of comparison by one after each complete pass.
            Optimized Bubble Sort: Adjusts the range of comparison more effectively by using start and end pointers, 
            which dynamically shrink the range based on the last swapped positions.
             */

            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            OptimizedBubbleSort(arr);

            Console.WriteLine("Sorted array is: ");
            PrintArray(arr);
            #endregion

            #region Question 2
            Range<int> intRange = new Range<int>(5, 15);
            Console.WriteLine("Is 10 in range? " + intRange.IsInRange(10)); // True
            Console.WriteLine("Is 20 in range? " + intRange.IsInRange(20)); // False
            Console.WriteLine("Length of range: " + intRange.Length()); // 10

  
            Range<double> doubleRange = new Range<double>(1.5, 4.5);
            Console.WriteLine("Is 3.0 in range? " + doubleRange.IsInRange(3.0)); // True
            Console.WriteLine("Is 5.0 in range? " + doubleRange.IsInRange(5.0)); // False
            Console.WriteLine("Length of range: " + doubleRange.Length()); // 3.0
            #endregion
        }
        #region Question 1
        static void OptimizedBubbleSort(int[] arr)
        {
            int n = arr.Length;
            int start = 0;
            int end = n - 1;
            bool swapped = true;

            while (swapped)
            {
                swapped = false;

                
                for (int i = start; i < end; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;

                
                swapped = false;

                
                end--;

                
                for (int i = end; i > start; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        Swap(arr, i, i - 1);
                        swapped = true;
                    }
                }

                
                start++;
            }
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //d
        }
        #endregion
    }
}

