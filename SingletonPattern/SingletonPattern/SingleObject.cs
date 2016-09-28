using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingleObject
    {
        //instance field
        private static SingleObject instance;

        //constructor
        private SingleObject()
        {
            
        }

        //Instance property
        public static SingleObject Instance
        {
            get {

                if (instance == null)
                {
                    instance = new SingleObject();
                }
                return instance;
            }
        }

        public void showMessage()
        {
            Console.WriteLine("This is is coming from the single object!");
            Console.ReadKey();
        }
    }
}
