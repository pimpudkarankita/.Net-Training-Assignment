using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Datatype
    {
		static void Main(string[] args)
		{
			int i = 10;
			float f = 10.2f;
			long l = 457554522;

			double d = 11452222.555d;
			decimal mon = 1000.15m;
			char ch = 'A';
			Console.WriteLine(i);
			Console.WriteLine(f);
			Console.WriteLine(l);

			Console.WriteLine(d);
			Console.WriteLine(mon);
			Console.WriteLine(ch);



			//
			Console.WriteLine("sizeof(int): {0}", sizeof(int));
			Console.WriteLine("sizeof(float): {0}", sizeof(float));
			Console.WriteLine("sizeof(char): {0}", sizeof(char));
			Console.WriteLine("sizeof(double): {0}", sizeof(double));
			Console.WriteLine("sizeof(bool): {0}", sizeof(bool));

			//hit ENTER to exit the program
			Console.ReadLine();
		}
	}
}
    

