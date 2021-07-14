using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Boxing_Unboxing
    {
        static void Main()
        {
            int i = 10;

            // Boxing copies the value of i into object o.
            object o = i;

            
            i = 20;

            // The change in i doesn't affect the value stored in o.
            System.Console.WriteLine("The value-type value = {0}", i);
            System.Console.WriteLine("The object-type value = {0}", o);


            int ii = 30;
            object oo = i;  // implicit boxing

            try
            {
                int j = (short)oo;  // attempt to unbox

                System.Console.WriteLine("Unboxing");
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
            }


        }
    }
}

    

