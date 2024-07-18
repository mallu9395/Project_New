using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 2, 7, 11, 15 };
            //int target = 26;
            //int[] result = TwoSum(nums, target);
            //int[] resultRec = TwoSumRecursive(nums, target);
            //int[] resultNormal = TwoSumNormal(nums, target);

            ////Just for Practice
            //int numbers = 10;
            //int numbers1 = 10;
            //int numbers2 = 10;
            //int numbers3 = 10;
            //Console.WriteLine("VAl1: {0}", numbers++);// 10
            //Console.WriteLine("VAl1: {0}", numbers1--);// 10
            //Console.WriteLine("Val 2: {0}", ++numbers2);//11
            //Console.WriteLine("Val 3: {0}", --numbers3);//9
            //Console.WriteLine(numbers); // 11
            //Console.WriteLine(numbers1); // 9
            //Console.WriteLine(numbers2); // 11
            //Console.WriteLine(numbers3); // 9

            ////Palindrome
            //string x = "gadagg";
            //Console.WriteLine("Is Palindrome: {0}", IsPalindrome(x));

            ////Remove Duplicates from Sorted Array
            //int[] duplicateArr = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //int noDuplicateArr = RemoveDuplicate(duplicateArr);
            //Console.WriteLine("Removed Duplicate: {0}", noDuplicateArr);
            //string s1 = "String";
            //Console.WriteLine(s1.Substring(1));
            //StringBuilder name = new StringBuilder("AppleA");
            //Duplicate(name);
            //string str = "Gadag";
            //Program.IsPalindrome(str);
            //var instance = Singlerone.GetInstance();
            //IsPalindrome();
            //DuplicateString.
            ClassB classB = new ClassB();
            ClassB classc = new ClassB("1", "2");
            Console.ReadLine();
        }

        /// <summary>
        /// How to inherit BaseClass Constructor
        /// </summary>
        public class ClassA
        {
            public const int val = 15;
            public ClassA(string str, string str1)
            {

            }
            public ClassA(string str, string str1, string str2)
            {

            }

            public ClassA()
            {

            }
        }

        public class ClassB : ClassA
        {
            public static string str12;
            public static string str13;
            public ClassB(string str, string str1) : base(str12="", str13 = "")
            {

            }
            public ClassB(string str, string str1, string str2) : base(str = "",str1 = "",str2 = "")
            {

            }

            public ClassB() : base()
            {
                
            }

           

            //public static string Duplicate(StringBuilder name)
            //{
            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        for (int j = i + 1; j < name.Length - 1; j++)
            //        {
            //            if (name[i] == name[j])
            //            {
            //                name.RemoveAt(j);
            //            }
            //        }
            //    }

            //    return name;
            //} 


           

            

            
        }
    }
}
