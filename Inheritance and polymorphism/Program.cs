using System;
using System.Threading.Channels;

namespace Inheritance_and_polymorphism
{

   class BaseClass
    {
        public void Method(object obj)
        {
            if (obj is string)
            {
                Console.WriteLine("Its string");
            }
            else
            {
                {
                    Console.WriteLine("Its not string");
                }
            }

        }
    }

   

     class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();

            baseClass.Method("Hi");
        }
    }
}
