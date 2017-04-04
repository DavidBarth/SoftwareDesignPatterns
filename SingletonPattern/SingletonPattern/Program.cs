using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
			
            SingleObject obj1 = SingleObject.Instance;
			SingleObject obj2 = SingleObject.Instance;

			if (obj1 == obj2)
			{
				Console.WriteLine("Objects are of the same instance!");

			}

		}
    }
}
