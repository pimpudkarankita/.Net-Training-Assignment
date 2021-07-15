using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using assignment_10thjuly;



namespace Assignment_10thjuly
{
    class Generic
    {
        public static void Main(string[] a)
        {
            List<int> x = new List<int>();
            x.Add(15);
            x.Add(20);
            x.Add(25);
            x.Add(30);

            foreach (int s in x)
            {
                Console.WriteLine(s);

            }
            //compiler error
            //x.Add("Ankita");
        }
    }
}
