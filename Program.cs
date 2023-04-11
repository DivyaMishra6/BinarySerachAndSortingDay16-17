using BinarySearchAndSortingDay16_17;

namespace BinarySearchAndSortingDay
{
    public class Program
    {
        public static void Main(string[] args)
        {
             Console.WriteLine("!!Welcome to Binary Search Tree and Sorting !!");

            //BubbleSort.DisplayBubble();
            //.DisplayInsertion();
            //Anagram.CheckAnagram();
            // PrimeNumber obj = new PrimeNumber();
            //obj.prime();

            //PrimeAnagramPalindrom obj = new PrimeAnagramPalindrom();
            // obj.prime();
            //SearchFromFile.Check(@"C:\Users\HP\source\repos\BinarySearchAndSortingDay16&17\BinarySearchAndSortingDay16&17");

            //MergeSort
            //List<string> list = new List<string> { "Durga", "Khali", "Lakshmi", "Sarswati", "Parvati", "Gayatri" };
            //Console.WriteLine("Unsorted List:");
            //foreach (string s in list)
            //{
            //    Console.Write(s + " ");
            //}
            //Console.WriteLine();

            //List<string> sorted = MergeSortDemo.Sort(list);
            //Console.WriteLine("Sorted List:");
            //foreach (string s in sorted)
            //{
            //    Console.Write(s + " ");
            //}
            //Console.WriteLine();

            //Generic 

            SortingWithGeneric<int> obj = new SortingWithGeneric<int>();
            int[] arr = new int[7] { 10, 22, 45, 88, 56, 77, 87 };
            obj.DisplayBubble(arr);
            int val = obj.BinarySearch(arr, 56);
            if (val == -1)
            {
                Console.WriteLine("Value not found in array.");
            }
            else
            {
                Console.WriteLine($"Value found at index {val}.");
            }


        }

    }
    
}
