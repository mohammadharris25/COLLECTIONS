using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    internal class Program
    {
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
            Console.WriteLine( queue1.Peek()+" :------peek element");
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
              foreach (var name in stack1) {
                  Console.WriteLine(name);
              }
            Console.WriteLine("------------------");
            stack1.Pop();
            foreach (var name in stack1)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("------------------");
            Console.WriteLine( stack1.Peek());


              string q;
              int c = stack1.Count;

              Console.WriteLine(queue1.Count);
              Console.WriteLine("------------");
              for (int m = 0; m < c; m++)
              {
                  q = stack1.Pop();
                  Console.WriteLine(q+ " removed");
                  Console.WriteLine(queue1.Count);
              }
            
        }
    }
}
