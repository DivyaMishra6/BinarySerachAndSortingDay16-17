using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAndSortingDay16_17
{
    public class Anagram
    {
        public static void CheckAnagram()
        {
            string str1 = "heater";
            string str2 = "rehept";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            String val1 = new string(ch1);
            String val2 = new string(ch2);

            Console.WriteLine(val1);
            Console.WriteLine(val2);

            if(val1 == val2)
            {
                Console.WriteLine("It is a Anagram");
            }
            else
            {
                Console.WriteLine("It is a not Anagram");
            }
        }

    }
}
