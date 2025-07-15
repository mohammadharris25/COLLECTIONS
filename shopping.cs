using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class shopping
    {
        List<string> list = new List<string> { "brush", "shoes", "towel", "headphone", "phone" };
        

        public void display()
        {
           

            
            {
                foreach (string displays in list)
                {
                    Console.WriteLine(displays);

                }
            }


        }
        public void add()
        {
            
            string add = Console.ReadLine();
            list.Add(add);
            foreach (string displays in list)
            {
                Console.WriteLine(displays);

            }
            Console.Write( add + " HAS BEEN ADDED SUCCESSFULLY");
        }
        public void remove()
        {
            Console.WriteLine("enter item to remove from list");
            string remove = Console.ReadLine();
            list.Remove(remove);
            foreach (string displays in list)
            {
                Console.WriteLine(displays);

            }
            Console.Write(remove + " HAS BEEN REMOVED SUCCESSFULLY");
        }
         



}
}
