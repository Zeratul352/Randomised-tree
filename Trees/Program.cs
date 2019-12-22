using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int a = random.Next(0, 15);
            //Console.WriteLine(a);
            Random_Tree tree = null;
            for(int i = 0; i < 1024; i++)
            {
                //a = random.Next(0, 15);
                //Console.WriteLine(a);
                 tree = Random_Tree.Insert(tree, i);
                //int d = tree.size;
            }
            Console.WriteLine(tree.size);
            //Random_Tree.Print(tree);
        }
    }
}
