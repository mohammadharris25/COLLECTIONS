using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
            int smallest = numbers[0];
            for (int i = 0;  i<numbers.Length;i++)
            {
                if (numbers[i]<smallest)
                {
                    smallest = numbers[i];
                }

            }
            Console.WriteLine(smallest);
            int[] evenodd = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
           
            for (int i = 0; i<evenodd.Length;i++)
            {
                if (evenodd[i]%2==0)
                {
                    Console.WriteLine(evenodd[i]);
                }
            }
           
            long[] numbers = { 1000000,12000000,13000000000000 };
            long larger = numbers[0];
            long secondlarger = numbers[1] ;
            for (long i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > larger)
                {
                    larger = numbers[i];

                }
                else if (numbers[i]>secondlarger)
                {
                    secondlarger = numbers[i];
                }

            }
            Console.WriteLine(secondlarger);
            // SECOND LARGER
            long[] numbers = { 1000, 1200, 1300,1700 };
            long larger = 0;
            long secondlarger = 0;
            for (long i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > larger)
                {
                    secondlarger = larger;
                    larger = numbers[i];
                }
                else if (numbers[i] > secondlarger)
                {
                    secondlarger = numbers[i];
                }
            }
            Console.WriteLine(larger);
            Console.WriteLine(secondlarger);
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 800, 9, 10, 111, 12, 13, 14, };
            Console.WriteLine("enter a number");
            int number = int.Parse(Console.ReadLine());
            bool x = false;
            for (int i = 0;i<array.Length;i++)
            {
                if (number==array[i])
                {
                    x = true;
                }

            }
            if (x == true)
            {
                Console.WriteLine("number is present");
            }
            else
            {
                Console.WriteLine("number is absent");
            }
            string[] names = { "harris", "tanfeez", "afnan", "sahil" };
           // by all loops at home;
           //Console.WriteLine(names[3]);
            for (int i = 0; i<names.Length;i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("_______________________");
            names[1] = "aahil";

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            int largest = 0;
            foreach (int a in array)
            {
            
                if (a>largest)
                {
                    largest = a;
                }
            }
            Console.WriteLine("LARGEST NUMBER = "+largest);

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            Console.WriteLine("LARGEST NUMBER = " + array.Max()); 

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            int smallest = array[0];
            foreach (int a in array)
            {

                if (a < smallest)
                {
                    smallest = a;
                }
            }
            Console.WriteLine("SMALLEST NUMBER = " + smallest); */

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            int largest = 0;
            int second_largest = 0;
            foreach (int a in array)
            {

                if (a > largest)
                {
                    second_largest = largest;
                    largest = a;
                    
                }
                else if(a>second_largest)
                {
                    second_largest = a;
                }
            }
            Console.WriteLine("LARGEST NUMBER ="+ largest+"\n"+"SECOND LARGEST NUMBER =" +second_largest);

          








        }
    }
}
