using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    internal class phonebook
    {
        Dictionary<long, string> info = new Dictionary<long, string>
        {
            {7780893532,"imtiyaz ahmad"},
            {9682697936,"harris" },
            {9086814855,"gulzaar" },
            {9906900772,"gill" },
            {9149455384,"tanfeez" },

        };
        public void display()
        {

            string display = Console.ReadLine();
            foreach (var display_item in info)
            {
                Console.WriteLine(display_item);
            }
        }
        public void add()
        {
            Console.WriteLine("enter  name to add");
            string add_name = Console.ReadLine();
            Console.WriteLine("enter  number to add");
            long add_number = long.Parse(Console.ReadLine());

            info.Add(add_number, add_name);
            foreach (var add_items in info)
            {
                Console.WriteLine(add_items.Key + add_items.Value);
            }
            Console.WriteLine(add_name + " name added successfully" + add_number + " number added successfully");
        }
        public void remove()
        {
            Console.WriteLine("enter  item to remove");
            long remove_item = long.Parse(Console.ReadLine());
            info.Remove(remove_item);
            foreach (var remove_items in info)
            {
                Console.WriteLine(remove_items.Key + remove_items.Value);
            }
            Console.WriteLine(remove_item + "removed successfully");
        }

        public void search()
        {
            Console.WriteLine("enter phone to find ");
            long search_phone = long.Parse(Console.ReadLine());
            bool x = false;
            string name = "";
             foreach (var search_item in info)
             {
                 if (search_phone == search_item.Key)
                 {
                    x= true;
                    name= search_item.Value;
                   
                   
                }

               

             }
            if (x == true)
            {
                Console.WriteLine(name);
            }
            else {
                Console.WriteLine("not found");
            }



        }




















    }
}
