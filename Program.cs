using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> l1 = new List<string>();

            using (LargeDataCollection dc = new LargeDataCollection(l1))
            {

                Console.WriteLine("Enter how many items do u wanna add");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter items to insert into list");
                for (int i = 0; i < num; i++)
                {
                    string add = Console.ReadLine();
                    dc.Push(add);
                }
                dc.Read();
                Console.WriteLine("Enter item name to Delete");
                string del = Console.ReadLine();
                dc.Delete(del);

                Console.WriteLine("Enter item name to search");
                string search = Console.ReadLine();
                dc.getItem(search);

                
            };

            Console.ReadKey();
        }
    }
}
