using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    ///Find Majority Element
    /// </summary>
    public class MajorityElementFinder
    {
        public int? FindMajorityElement(int[] nums)
        {
            // Step 1: Find a candidate for majority element
            int? majority = FindCandidate(nums);

            if (majority != null)
            {
                int count = 0;
                foreach (int n in nums)
                {
                    if (n == majority)
                    {
                        count++;
                    }
                }

                //Is Majority element appears more than ⌊n / 2⌋ times
                return count > nums.Length / 2 ? majority : null;
            }
            return null; // No majority element found
        }

        public int FindCandidate(int[] nums)
        {
            int majority = 0;
            int count = 0;
            foreach (int i in nums)
            {
                if (count == 0)
                {
                    majority = i;
                    count++;
                }
                else
                {
                    if (majority == i)
                        count++;
                    else
                        count--;
                }
            }

            return majority;
        }
    }

    /// <summary>
    /// Find Duplicate String
    /// </summary>
    public static class DuplicateString
    {
        public static string str1 = "aaaalluuuuqwerrreettll";
        public static int getNum = 0;
        public static int MyProperty { get; set; }
        static DuplicateString()
        {

        }

        public static void DuplicateUsingLinq()
        {
            var duplicates = str1.GroupBy(c => c)
                                 .Where(g => g.Count() > 1)
                                 .Select(g => g.Key);
            var duplicates2 = str1.GroupBy(c => c).Where(g => g.Count() > 1);
            // Print out the duplicate characters
            Console.WriteLine("Duplicate characters in '{0}': {1}", str1, string.Join(", ", duplicates));

        }
        public static void DuplicateUsingDictionary()
        {
            string str1 = "aaaalluuuuqwerrreettll";
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            // Count occurrences of each character
            foreach (char c in str1)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 0;
                }
            }

            // Find characters with counts > 1 (duplicates)
            List<char> duplicates1 = new List<char>();
            foreach (var pair in charCounts)
            {
                if (pair.Value > 1)
                {
                    duplicates1.Add(pair.Key);
                }
            }

            // Print out the duplicate characters
            Console.WriteLine("Duplicate characters in '{0}': {1}", str1, string.Join(", ", duplicates1));


        }

        public static void DuplicateUsingNormalDT()
        {
            string str1 = "aaaalluuuuqwerrreettll";
            int count = 0;
            Dictionary<char,int> arrayList = new Dictionary<char, int>();
           
            for (int i = 0; i < str1.Length; i++)
            {
                if (arrayList.ContainsKey(str1[i])) { continue; }
                for (int j = i + 1; j < str1.Length; j++)
                {
                    if (str1[i] == str1[j])
                    {
                        count++;
                    }
                }
                arrayList.Add(str1[i], count);
                count = 0;
            }
            Console.WriteLine(string.Join(", ", arrayList));
        }

        //Find Duplicate char and remove and return only unique elements
        public static string Duplicate()
        {
            string duplicateString = "aaaalluuuuqwerrreettll";
            HashSet<char> uniqueElements = new HashSet<char>(duplicateString);
           // StringBuilder stringBuilder = new StringBuilder();

            //foreach (char c in duplicateString)
            //{
            //    if (!uniqueElements.Contains(c))
            //    {
            //        uniqueElements.Add(c);
            //        stringBuilder.Append(c);
            //    }
            //}

            return uniqueElements.ToString();
         }
    }

    /// <summary>
    /// Singleton implementation
    /// TODO - Transient objects:  are created every time they are needed, and then discarded when they're no longer needed.
    /// TODO - Scoped objects are created and used within a particular scope, such as a specific web request.
    /// </summary>
    public class Singlerone
    {
        private static readonly object _lock = new object();
        private static Singlerone instance;
        private Singlerone()
        {

        }

        public Singlerone MyProperty
        {
            get
            {
                lock (_lock)
                {
                    if (instance != null)
                    {
                        instance = new Singlerone();
                    }
                    return instance;
                }
            }
        }
        //public static Singlerone GetInstance()
        //{
        //    lock (_lock)
        //    {
        //        if (instance != null)
        //        {
        //            instance = new Singlerone();
        //        }
        //        return instance;
        //    }
        //}
    }

    /// <summary>
    /// Find TwoSum in arrray 
    /// </summary>
    public class TwoSumClass
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int compl = target - nums[i];
                if (result.ContainsKey(compl))
                {
                    return new int[] { result[compl], i };
                }
                if (!result.ContainsKey(compl))
                {
                    result.Add(nums[i], i);
                }
            }
            return null;
        }

        public static int[] TwoSumRecursive(int[] nums, int target)
        {
            int start = 0;
            return TwoSumRecursiveMethod(nums, target, start);
        }

        public static int[] TwoSumRecursiveMethod(int[] nums, int target, int start)
        {
            if (start >= nums.Length - 1)
            {
                return new int[0];
            }

            int comp = target - nums[start];
            for (int i = start + 1; i < nums.Length; i++)
            {
                if (comp == nums[i])
                {
                    return new int[] { start, i };
                }
                //if (nums[start] + nums[i] == target)
                //{
                //    return new int[] { start, i };
                //}
            }
            return TwoSumRecursiveMethod(nums, target, start + 1);
        }

        public static int[] TwoSumNormal(int[] nums, int target)
        {

            int l = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[0];
        }
    }

    /// <summary>
    /// Remove Duplicates from Sorted Array
    /// </summary>
    public class DuplicateNumber
    {
        //Remove Duplicates from Sorted Array
        //nums = [0,0,1,1,1,2,2,3,3,4]
        public static void DuplicateEle()
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4, 6, 6, 5, 5, 8, 8, 7, 7 };
            int[] uniqueArray1 = nums.Distinct().ToArray();
            string[] str = { "A", "AA", "AA", "A", "BBB", "bbb", "DDD", "DDD", "CC", "CC" };

            HashSet<int> hashSet = new HashSet<int>(nums);
            int[] sortedArr = hashSet.OrderBy(x => x).ToArray();

            HashSet<string> hashSet2 = new HashSet<string>(str);
            string[] sortedArr2 = hashSet2.OrderBy(x => x).ToArray();

            int[] uniqueArray2 = new int[hashSet.Count];
            hashSet.CopyTo(uniqueArray2);

            // Print the original array
            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", nums));

            // Print the array with duplicates removed
            Console.WriteLine("Array with duplicates removed:");
            Console.WriteLine(string.Join(", ", uniqueArray1));
        }


        public static int RemoveDuplicate(int[] arr)
        {
            int j = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    arr[j] = arr[i];
                    j++;
                }
            }

            return j;
        }

        public static int RemoveDuplicate1(int[] arr)
        {

            int j = 1;
            int[] k = new int[j];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    arr[j] = arr[i];
                    j++;
                }
            }

            return j;
        }

        /// <summary>
        /// Find Sum of Event numbers
        /// </summary>
        /// <returns></returns>
        public static int SumOfEvenNumber()
        {
            int[] sum = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int i = 0;
            int sumOfEven = 0;

            while (i < sum.Length)
            {
                if (sum[i] % 2 == 0)
                {
                    sumOfEven += sum[i];
                }
                i++;
            }

            // OR Using Linq
            int result = sum.Where(n => n % 2 == 0).Sum();

            return sumOfEven;
        }

        /// <summary>
        /// Palindrome String
        /// TODO : Need to implement using Recursive Method 
        /// </summary>
        /// <returns></returns>
        public static bool IsPal()
        {
            string s1 = "gadag";
            int left = 0;
            int right = s1.Length - 1;
            while (left < right)
            {
                if (s1[left] != s1[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }

    #region Generics Concepts
    /// <summary>
    /// This generic class you can pass any type of employee and it will perform as per the employee
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class NewClass<T> where T : Employee
    {
        private T _employee;

        public NewClass(T employee)
        {
            _employee = employee;
        }

        public void PerformWork()
        {
            // Access properties and methods of T (Employee type)
            Console.WriteLine($"Employee: {_employee.Name}, Salary: {_employee.Salary}");

            // Access specific methods based on T's type
            if (_employee is Manager)
            {
                // Example: ManageTeam method specific to Manager
                ((Manager)(object)_employee).ManageTeam();
            }
            else if (_employee is Developer)
            {
                // Example: Code method specific to Developer
                ((Developer)(object)_employee).Code();
            }
        }
    }


    // Base class for all employees
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    // Different types of employees
    public class Manager : Employee
    {
        public void ManageTeam()
        {
            // ManageTeam implementation
        }
    }

    public class Developer : Employee
    {
        public void Code()
        {
            // Code implementation
        }
    }
    #endregion Generics Concepts

    public class MyClass
    {
        static string str = "dahidhsdoishdoihf";
        string val = str.ChangeStrign();
    }

    public static class EXtensionMethod
    {
        public static string ChangeStrign(this string str)
        {
            if(str.Length > 0)
            {
                return str.ToUpper();
            }

            return "Given string Length should be greater the zero";
        }
    }
}
