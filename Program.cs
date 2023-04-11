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
            List<string> list = new List<string> { "Durga", "Khali", "Lakshmi", "Sarswati", "Parvati", "Gayatri" };
            Console.WriteLine("Unsorted List:");
            foreach (string s in list)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            List<string> sorted = MergeSortDemo.Sort(list);
            Console.WriteLine("Sorted List:");
            foreach (string s in sorted)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

        }
    }
}
