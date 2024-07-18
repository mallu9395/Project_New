using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
           {

            LinqQueriesExamples.OrderOperator();
            LinqQueriesExamples.AggregateAndRestrictionOP();
            MyClass myClass = new MyClass();

            //Generics Concepts
            Manager manager = new Manager { Name = "John", Salary = 80000 };
            Developer developer = new Developer { Name = "Jane", Salary = 60000 };
          
            // Using NewClass<T> with different types of employees
            NewClass<Manager> managerClass = new NewClass<Manager>(manager);
            NewClass<Developer> developerClass = new NewClass<Developer>(developer);

            // Perform work for manager and developer
            managerClass.PerformWork();
            developerClass.PerformWork();

            DuplicateString.Duplicate();
            DuplicateString.DuplicateUsingDictionary();
            DuplicateString.DuplicateUsingLinq();
            DuplicateString.DuplicateUsingNormalDT();
            DuplicateNumber.DuplicateEle();
            int[] array1 = { 2, 2, 1, 1, 1, 2,1, 2 };

            MajorityElementFinder finder = new MajorityElementFinder();

            int? majorityElement = finder.FindMajorityElement(array1);

            if (majorityElement != null)
            {
                Console.WriteLine($"Majority element in array1: {majorityElement}");
            }
            else
            {
                Console.WriteLine("No majority element found");
            }

            //int[] array1 = { 1, 2,2,2, 1, 3, 1,2 };

            //MajorityElementFinder finder = new MajorityElementFinder();

            //try
            //{
            //    int majorityElement = finder.FindMajorityElement(array1);
            //    Console.WriteLine($"Majority element in array1: {majorityElement}");
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Container<int> stringContainer = new Container<int>(1,2);
            //stringContainer.DisplayItemInfo();  // Output: Item Type: System.String

            ////Container<int> intContainer = new Container<int>(10); // Error: int does not satisfy 'where T : class' constraint
            ////intContainer.DisplayItemInfo();

            //DuplicateString.DuplicateUsingNormalDT();

            int val1;
            string val2;
            //Creating Tuples 
            Tuple<int, string, int, int, int, int, int, Tuple<string, string,string, string>> tuple = 
                new Tuple<int, string, int, int, int, int, int, Tuple<string, string, string, string>>(1,"1",1,1,1,1,1,new Tuple<string, string, string, string>("8", "8", "8", "8"));

            var getTuple = Tuple.Create("Val1","val2","val3", "Val4", "Val5", "Val6", "Val7", ("Val8","1",("2","2")));
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", getTuple.Item1, getTuple.Item2, getTuple.Item3, getTuple.Item4, getTuple.Item5, getTuple.Item6, getTuple.Item7, getTuple.Rest);
           
            //Creating ValueTuple
            ValueTuple<int, string, int, int, int, int, int, ValueTuple<string, string,string, string>> tuple1 = 
                new ValueTuple<int, string, int, int, int, int, int, ValueTuple<string, string, string, string>>(1,"1",1,1,1,1,1,new ValueTuple<string, string, string, string>("8", "8", "8", "8"));

            var getTuple1 = ValueTuple.Create("Val1","val2","val3", "Val4", "Val5", "Val6", "Val7", ("Val8","1",("2","2")));
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", getTuple.Item1, getTuple.Item2, getTuple.Item3, getTuple.Item4, getTuple.Item5, getTuple.Item6, getTuple.Item7, getTuple.Rest);

            PracticeClass getsSum = new PracticeClass();
            getsSum.FindPal();
            getsSum.FindPal1();

            // There are Three Ways we can return Multiple values
            //Using Tuple
            var (Val, Val2) = getsSum.GetValues();

            //Using Out
            getsSum.GetOutValues(out val1, out val2);

            //Using reference type class Person
            var refValue = getsSum.GetReferenceType();

            //Converting From HashTable to Dictionary
            Person P1 = new Person { Id = 1, Name = "Alice" };
            Person P3 = new Person { Id = 2, Name = "Alice1" };

            Hashtable personList = new Hashtable();
            personList.Add(P1.Id, P1.Name);
            personList.Add(P3.Id, P3.Name);

            Dictionary<int, string> getDictValue = personList.Cast<DictionaryEntry>().ToDictionary(x => (int)x.Key, y => (string)y.Value);

            //Casting to list to find SingleOrDefault
            Hashtable personList12 = new Hashtable();
            personList12.Add("1","HI");
            personList12.Add("2", "HI");
            personList12.Add("3", "HI");

            var get = personList12.Cast<DictionaryEntry>().ToList();
            DictionaryEntry getVal = get.SingleOrDefault(x => (string)x.Key == "2");

            //Converting From Dictionary to HashTable
            Dictionary<int, string> personList1= new Dictionary<int, string>();
            personList1.Add(P1.Id, P1.Name);
            personList1.Add(P3.Id, P3.Name);

            Hashtable personNewList = new Hashtable();

            foreach(KeyValuePair<int,string> hashCodes in personList1)
            {
                personNewList.Add(hashCodes.Key, hashCodes.Value);
            }

            //This Code will display the Elements
            int[] newArrList = getsSum.RemoveDuplicateElements();
            string displayArr = "[" + string.Join(",", newArrList) + "]";

            // This Code is to displaying array elements in [2, 7, 11, 15] without using any inbuilt methods

            int[] getArr = getsSum.GetSum11();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[");
            for (int i = 0; i < getArr.Length; i++)
            {
                stringBuilder.Append(getArr[i]);
                if (i< getArr.Length - 1 )
                {
                    stringBuilder.Append(",");
                }
            }
            stringBuilder.Append("]");
            Console.WriteLine(stringBuilder.ToString());

            // This Code is to displaying array elements in [2, 7, 11, 15] with using any inbuilt Join() method
            int[] getArr1 = getsSum.GetSum1();
            string arrayString = "[" + string.Join(", ", getArr1) + "]";
            Console.WriteLine(arrayString);

            //DEF obj = new DEF();
            //int value = 0;
            //obj.GetDataMethod(ref value);
            // Usage
            //int x = 5, y = 3;
            //int resultSum = 0, resultProduct = 0;


            //obj.Calculate(x, y, ref resultSum, ref resultProduct);

            // Console.WriteLine($"Sum: {resultSum}, Product: {resultProduct}");
            // Output: Sum: 8, Product: 15
            //obj.GetDataMethod(ref value, ref value1);
            // ((Abc)obj).GetDataMethod( value : 200);
            //int getValue = value;
            Console.ReadLine();
            
        }
    }

    public class Person
    {
        public int Id;
        public string Name;
    }
    //  public delegate void GetDataMethod1(dynamic value);
    public class PracticeClass
    {
        
        /// <summary>
        /// There are Three Ways we can return Multiple values
        /// 1.Tuple provide a consise way to return multiple values from method
        /// </summary>
        /// <returns></returns>
        public (int, string)GetValues()
        {
            return (1, "12");
        }

        /// <summary>
        /// There are Three Ways we can return Multiple values
        /// 2.Out keyword provide a way to return multiple values from method
        /// </summary>
        /// <returns></returns>
        public void GetOutValues(out int val1, out string val2)
        {
            val1 = 10;
            val2 = "Out Values";
        }

        /// <summary>
        /// There are Three Ways we can return Multiple values
        /// 3.Refernce Type Class Person provide a way to return multiple values from method
        /// </summary>
        /// <returns></returns>
        public Person GetReferenceType( int Id = 10, string Name = "ReferenceType")
        {
            return new Person { Id = Id, Name = Name};
        }

        /// <summary>
        /// This Code is to remove the duplicate elements in an array
        /// </summary>
        /// <returns></returns>
        public int[] RemoveDuplicateElements()
        {
            int[] nums1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4, 8, 7, 5, 6, 9 };
            int j = 1;
            for (int i = 1; i <= nums1.Length -1; i++)
            {
                if (nums1[i] != nums1[i - 1])
                {
                    nums1[j] = nums1[i];
                    j++;
                }
            }
            return nums1;
        }

        public bool FindPal()
        {
            int x = -121;
            string y = x.ToString();
            int left = 0;
            int right = y.Length -1;
             
            while(left < right)
            {
                if (y[left] != y[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        public bool FindPal1()
        {
            int x = 11;
            string y = x.ToString();
            return ReturnPal(y,0,y.Length-1);
        }
        public bool ReturnPal(string y, int left, int right)
        {
            if(left >= right)
            {
                return true;
            }
            if (y[left] != y[right])
            {
                return false;
            }

            return ReturnPal(y,left+1,right - 1);
        }

        public int[] GetSum11()
        {
            return new int[] { 2, 7, 11, 15 };
        }

        /// <summary>
        ///Below methos also return Two Sum but Efficiency: The nested loops result in an O(n^2) time complexity,
        ///which is less efficient compared to the optimal O(n) solution using a dictionary for lookup
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int[] GetSum1()
        {
            int target = 26;
            int[] arrInterger = new int[] { 2, 7, 11, 15 };

            for (int i = 0; i < arrInterger.Length; i++)
            {
                for(int j = i+1; j< arrInterger.Length;j++)
                {
                    if (arrInterger[i] + arrInterger[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            throw new Exception("Not Found");
        }

        /// <summary>
        /// Method will return Two Sum Elements
        /// </summary>
        /// <returns></returns>
        public int[] GetTwoSum()
        {
            int target = 26;
            int[] arrInterger = new int[] { 2, 7, 11, 15 };

            Dictionary<int, int> dictTable = new Dictionary<int, int>();

            for (int i = 0; i < arrInterger.Length; i++)
            {
                int complement = target - arrInterger[i];
                if (dictTable.ContainsKey(complement))
                {
                    return new int[] { dictTable[complement], i }; // dictTable[complement] it will give index of complement element in dictionary
                }
                if (!dictTable.ContainsKey(arrInterger[i]))
                {
                    dictTable.Add(arrInterger[i], i);
                } 
            }

            return null;
        }

        //public void Calculate(int a, int b, ref int sum, ref int product)
        //{
        //    sum = a + b;
        //    product = a * b;
        //}
        //public void GetDataMethod1( dynamic value, int value1 = 200 , bool isBool = false, string valueString = "NewValues")
        //{
        //    Console.WriteLine("Base Class Method {0}", value);
        //    //return true;
        //}
    }


    //public class  DEF : Abc
    //{
    //    private int x = 5, y = 3;
    //    private int resultSum = 0, resultProduct = 0;

    //    private int _get =100;
    //    public int MyProperty
    //    {
    //        get
    //        {
    //            return _get;
    //        }
    //        set
    //        {
    //            if(value > 10000)
    //              _get = value;
    //            else
    //                _get = 0;
    //        }
    //    }

    //    public void GetDataMethod(ref int value)
    //    {
    //        value = 5000;
    //        dynamic getBool = true;
    //        string getString = "getValue";
    //        MyProperty = 2000;
    //        Action<dynamic> get =  (dynamic getVal) =>
    //        {
    //            Console.WriteLine("Hey Buddy!!!...I am delegate {0}", getVal);
    //        };
    //       // GetDataMethod1(get(getBool));
    //        GetDataMethod1(getString, value, getBool);
    //        GetDataMethod1(value, value, getBool);
    //        Console.WriteLine("Child Class Method");
    //    }
    //}
}
  