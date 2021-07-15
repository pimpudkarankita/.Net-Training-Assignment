using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment_10thjuly
{
    class Collection
    {
        public static void PrintValues(IEnumerable x)
        {
            // start with capital I is interface
            IEnumerator z = x.GetEnumerator();
            while (z.MoveNext())
            {
                Console.WriteLine(z.Current);
            }
        }
        //ArrayList arrayList = new ArrayList();
        static void Main(string[] d)
        {


            try
            {
                ArrayList arrayList = new ArrayList();

                //implicitly boxking happening
                arrayList.Add(10);
                arrayList.Add("Ankita");
                arrayList.Add(true);


                //implicitly converting into object
                foreach (int x in arrayList)
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine("With IEnumrable");
                Collection.PrintValues(arrayList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("finally block will executed ");
            }


        }
        // the below method is Iterationg the values from arrayList Using its Interface


    }
}


