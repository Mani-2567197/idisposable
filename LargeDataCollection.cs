using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_collections
{
    public class LargeDataCollection : IDisposable
    {
        private List<string> list = null;
        bool disposed;
        public int count;
        

        public LargeDataCollection(List<string> list)
        {
            this.list = list;
            Console.WriteLine("List Created");

        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    list.Clear();

                }
            }
            list = null;
            disposed = true;
           
            Console.WriteLine($"Collection {list} has been disposed");
          
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public string Push(string item)
        {
            list.Add(item);
            return item;
        }
        public void Read()
        {
            foreach (string i in list)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine("\n");
        }
        public void Delete(string item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                Console.WriteLine($"{item} is deleted successfully from the list");
            }
            else
            {
                Console.WriteLine($"{item} is not in the list");
            }
            
        }
        public void getItem(string item)
        {
            if (list.Contains(item))
            {
                Console.WriteLine($"{item} is available in the list");
            }
            else
            {
                Console.WriteLine($"{item} is not available in the List");
            }
        }
        ~LargeDataCollection()
        {
            Dispose(false);
        }
    
    }
}
