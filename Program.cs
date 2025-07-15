using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
        // array --- fixed size , data type secure
        // list ---- flexible size ,data type secure
        // dictionary --- flexible size, data type secure
        // arraylist --- flexible size,  not data type secure
        //queue 
        //stack

       // List<string> list = new List<string>() { "moin",123};
        
        ArrayList arrayList = new ArrayList() { "moin",123,0.5,"ahmad"};

           for (int i = 0; i < arrayList.Count; i++) { 
                Console.WriteLine(arrayList[i]);
            }
           
           


            foreach (var a in arrayList) { 
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


class Queue {

    public void queefxn() {


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
