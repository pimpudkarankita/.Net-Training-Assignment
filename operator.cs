using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class @operator
    {
        static void Main(string[] args)

        {

            int result1, result4, result5;

            bool result2, result3;

            int x = 10, y = 5;



            // Using Arithmetic operator 

            result1 = (x + y);

            Console.WriteLine("Addition Operator: " + result1);



            // Using Relation operator 

            result2 = (x == y);

            Console.WriteLine("Equal to Operator: " + result2);



            bool a = true, b = false;



            // Using Logical Operator 

            result3 = a && b;

            Console.WriteLine("AND Operator: " + result3);



            // Using Bitwise Operator 

            result4 = x & y;

            Console.WriteLine("Bitwise AND: " + result4);



            // Using Assignment Operator 


            int m = 15; 

            m += 10;

            Console.WriteLine("Add Assignment Operator: " + m);

            result5 = x < y ? x : y;

            Console.WriteLine("Result: " + result5);

        }
    }
}

