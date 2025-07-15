using System;
using System.Collections;
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
           // static void Main(string[] args)
            {

                // array --- fixed size , data type secure
                // list ---- flexible size ,data type secure
                // dictionary --- flexible size, data type secure
                // arraylist --- flexible size,  not data type secure
                //queue 
                //stack

                // List<string> list = new List<string>() { "moin",123};

                ArrayList arrayList = new ArrayList() { "moin", 123, 0.5, "ahmad" };

                for (int i = 0; i < arrayList.Count; i++)
                {
                    Console.WriteLine(arrayList[i]);
                }




                foreach (var a in arrayList)
                {
                    Console.WriteLine(a);
                }

                arrayList.Add(1);
                arrayList.Add("harris");
                Console.WriteLine("---------------------");
                foreach (var a in arrayList)
                {
                    Console.WriteLine(a);
                }


                arrayList.Remove("ahmad");
                Console.WriteLine("---------------------");
                foreach (var a in arrayList)
                {
                    Console.WriteLine(a);
                }
                arrayList[0] = "tanfeez";
                Console.WriteLine("---------------------");
                foreach (var a in arrayList)
                {
                    Console.WriteLine(a);
                }


                arrayList.Insert(3, "burhan");
                Console.WriteLine("---------------------");
                foreach (var a in arrayList)
                {
                    Console.WriteLine(a);
                }
                /*
                arrayList.Add(1);
                arrayList.Add(1);
                arrayList.Add(1);

                Console.WriteLine(arrayList.Count);
                arrayList.Clear();
                Console.WriteLine(arrayList.Count);*/


                // ArrayList arraylist = new ArrayList() { "moin", 9682, 0.5, "ahmad" };


                // queue

                List<string> list = new List<string>() { };

                Queue q1 = new Queue();
                q1.queefxn();


                /* Console.WriteLine("------------------");
                 foreach (var name in queue1)
                 {
                     Console.WriteLine(name);
                 }
                 Console.WriteLine("------------------");
                 Console.WriteLine(queue1.Peek());
                */





            }

        }
    }


    class Queue
    {

        public void queefxn()
        {


            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("moin");
            queue1.Enqueue("ahmad");
            queue1.Enqueue("basit");
            queue1.Enqueue("umar");
            queue1.Enqueue("sahil");


            foreach (var name in queue1)
            {
                Console.WriteLine(name);
            }



            Console.WriteLine("------------------");

            int a;
            string x;
            int b = queue1.Count;
            Console.WriteLine(queue1.Count);

            for (a = 0; a < queue1.Count; a++)
            {
                x = queue1.Dequeue();
                Console.WriteLine(x + " removed");
            }





        }



    }
       static void Main(string[] args)
        {


            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("moin");
            queue1.Enqueue("ahmad");
            queue1.Enqueue("basit");
            queue1.Enqueue("umar");
            queue1.Enqueue("sahil");


            foreach (var name in queue1)
            {
                Console.WriteLine(name);
            }

            queue1.Enqueue("bilal");
            Console.WriteLine("_______________");
            foreach (var name in queue1)
            {
                Console.WriteLine(name);
            }
            queue1.Dequeue();

            Console.WriteLine("_______________");

            foreach (var name in queue1)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("_______________");
            Console.WriteLine(queue1.Peek() + " :------peek element");
            Console.WriteLine("_______________");
            Console.WriteLine(queue1.Count);




            /*Console.WriteLine("------------------");

              int a;
              string x;
              int b = queue1.Count;

              //Console.WriteLine(queue1.Count);

              for (a = 0; a < b; a++)
              {
                  x = queue1.Dequeue();
                  Console.WriteLine(x + " removed");
                  //Console.WriteLine(queue1.Count);
              }
            */

            Stack<string> stack1 = new Stack<string>();
            stack1.Push("moin");
            stack1.Push("ahmad");
            stack1.Push("basit");
            stack1.Push("Umar");
            stack1.Push("sahil");
            Console.WriteLine("------------------");
            foreach (var name in stack1)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("------------------");
            stack1.Pop();
            foreach (var name in stack1)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("------------------");
            Console.WriteLine(stack1.Peek());


            string q;
            int c = stack1.Count;

            Console.WriteLine(queue1.Count);
            Console.WriteLine("------------");
            for (int m = 0; m < c; m++)
            {
                q = stack1.Pop();
                Console.WriteLine(q + " removed");
                Console.WriteLine(queue1.Count);
            }



            // Dictionary ; ---------- ( key and value present in a pair word and meaning)      
            // # / hastable table
            // no sequence and non generic dictinary
            /*  Hashtable ht = new Hashtable();
             ht.Add("moin","harris");
             ht.Add(101,"ahmad");
             ht.Add("umar",18.6);
             foreach (DictionaryEntry a in ht ) 
             { 


             Console.WriteLine(a.Key+"---------------"+a.Value);


             }
             Console.WriteLine("_____________");
             ht.Add("cr7",123456);

             foreach (DictionaryEntry a in ht)
             {


                 Console.WriteLine(a.Key + "---------------" + a.Value);


             }
             ht.Remove("umar");
             Console.WriteLine("_____________");
             foreach (DictionaryEntry a in ht)
             {


                 Console.WriteLine(a.Key + "---------------" + a.Value);


             }

             SortedList sortedList = new SortedList();
             // non generic  key and value

             sortedList.Add(07,"cr7");
             sortedList.Add( 10, "messi");
             sortedList.Add(01,"beckham");
             foreach ( DictionaryEntry item in sortedList)
             {
                 Console.WriteLine(item.Key +"----------"+ item.Value);

             }
             */







        }



