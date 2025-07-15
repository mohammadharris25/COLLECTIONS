
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            shopping s1 = new shopping();
            

            List<string> list = new List<string> { "brush", "shoes", "towel", "headphone", "phone" };
            Console.WriteLine("press (1) to diplay");
            Console.WriteLine("press (2) to add item in list");
            Console.WriteLine("press (3) to revome item from the list");
            int choice = int.Parse(Console.ReadLine());
            if (choice==1) 
            {
                s1.display();
            }
      



           else  if (choice==2)
            {
                s1.add();

            }
       
            


             else if (choice == 3)
            {
            s1.remove();
                

            }
            else
            {
                Console.WriteLine("invalid choice");
            }
















        }
    }
}
