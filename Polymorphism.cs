using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Polymorphism
    {
        static void Main(string[]args)
        {
            PolyEx p = new PolyEx();
            p.Add();
            p.Add(10, 15.02f);
            p.Add(17.03f, 7);
            p.Add(10, 20);

        }

    }
    class PolyEx
    {
        public void Add()
        {
            Console.WriteLine("Add method");
        }


        public void Add(int a, float b)
        {
            Console.WriteLine(a + b);

        }
       
        public float Add(float a, float b)
        {
            float result = a + b;
            Console.WriteLine(result);
            return result;
        }
    }
}
