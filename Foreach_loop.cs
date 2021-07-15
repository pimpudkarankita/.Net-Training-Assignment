using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Foreach_loop
    {
        static public void Main()
        {

            Console.WriteLine("Print array");

       
            int[] a_array = new int[] { 1, 2, 3, 4, 5 };

          
            foreach (int items in a_array)
            {
                Console.WriteLine(items);
            }
        }
    }
}
    

