using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;


//namespace unitTest
//{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int yy = add(4,5);
            Console.WriteLine(yy);
            Console.WriteLine (isOdd(5));

        }
        public static int add(int x, int y)
        {
            return x+y;
        }
        public static bool isOdd(int value)
        {
            return value % 2 ==1;
        }
         
    }
//}
