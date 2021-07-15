using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class MethodOverride
    {
        /*static void Main(string[]args)
        {
            Bank b = new Bank();
            b.Roi();
            Bank b1 = new ICICI();
            b.Roi();
            ICICI b2 = new ICICI();
            b.Roi();
            //ICICI b3=new Bank();
        }*/
    }
    class Bank
    {
        public virtual float Roi()
        {
            float irr = 4.5f;
            Console.WriteLine(irr);
            return irr;
        }
    }
    class ICICI: Bank
    {
        public override float Roi()
        {
            float ir = 7.5f;
            Console.WriteLine(ir);
            return ir;
        }
    }
}
