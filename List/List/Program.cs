using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Element<int> a = new Element<int>(5); 
            Element<int> b = new Element<int>(8);
            Element<int> c = new Element<int>(10);
            List<int> list = new List<int>();
            list.addfirst(a);
            list.addfirst(b);
            list.addfirst(c);
            list.PrintList();
            List<string> list2 = new List<string>();
            list2.addfirst(new Element<string>("A"));
            list2.addfirst(new Element<string>("B"));
            list2.addfirst(new Element<string>("C"));
            list2.PrintList();

            Console.ReadKey();
        }
    }
}
