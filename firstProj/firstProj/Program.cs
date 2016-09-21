using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProj
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************");
            Console.WriteLine("**** Welcome to My Rocking App ******");
            Console.WriteLine("*************************************");
            Console.BackgroundColor = ConsoleColor.Black;
            //ShowSomething();
            //StringInterpolation();
            //int i = 0;
            //Out_mod(ref i);
            //Console.WriteLine(i);
            //named_par("one", three: "three", two: "two");
            simple_array();
            Console.ReadLine();
            return 0;
        }
        static void StringInterpolation()
        {
            int age = 4;
            string name = "Soren";

            string greeting = string.Format("hello {0} you are {1} years old.", name, age);
            string greeting2 = $"hello {name} you are {age} years old.";

            Console.WriteLine(greeting);
            Console.WriteLine(greeting2);
        }
        static void ShowSomething()
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive : {0}", drive);
            Console.WriteLine();
            Console.WriteLine("os: {0}", Environment.OSVersion);
            Console.WriteLine();
            Console.WriteLine(".net version: {0}", Environment.Version);
        }
        static void Out_mod(ref int i)
        {
            i = 33;
        }
        static void named_par(string one,string two, string three)
        {
            Console.WriteLine("one:{0}\ntwo:{1}\nthree:{2}",113,two,three);
        }
        
        
        static void simple_array()
        {
            int[] arr = new int[] { 1 ,3,4,0};
            var a = arr.Reverse();              // this two line reverse the array
            int[] aa = a.ToArray();
            Array.Reverse(arr);

            int[] arrr = new int[] { 3, 2, 2, 4, 3 };
            int[,] two_arr = new int[3, 4];                       // rectangular array
            int[][] other_arr = new int[3][];                     // normal array
            var date = new DateTime(1122, 2, 3);          // when ce date, it will give me the content like int
            Console.WriteLine(two_arr.Rank);
            Console.WriteLine(arr);
            foreach (var ii in aa)
            {
                Console.WriteLine(ii);
            }

        }

        static void enum_fun()
        {

        }
    }
    //class test
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("hah");
    //    }
    //}
}

