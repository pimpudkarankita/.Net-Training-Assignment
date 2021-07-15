using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class library
    {
        
        public int k = 20;//Accessed
        private int j = 10;//not accessed
        protected int b = 30;//not accessed
        internal int c = 40;//not accessed
        protected internal int d = 50;//not accessed
        private protected int e = 60;//not accessed
        public int getData()//accessed
        {
            int a = 25;
            return a;

        }
        private int get() //not accesed
        {
            int b = 20;
            return b;
        }

        protected int Put() //not accessed
        {
            int c = 20;
            return c;
        }

        internal int Print()//not accsessed
        {
            int d = 10;
            return d;
        }

        protected internal int putData()//not accessed
        {
            int d = 50;
            return d;
        }

        private protected int data()//not accessed
        {
            int d = 60;
            return d;
        }
    }
    internal class Class2 //not accessed
    {
        public int i = 10;
    }

}

