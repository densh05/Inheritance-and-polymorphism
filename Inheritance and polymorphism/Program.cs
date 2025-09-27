using System;

namespace Inheritance_and_polymorphism
{

    class BaseClass
    {
        public  virtual void Method()
        {
            Console.WriteLine("Method from BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Method()
        {
            base.Method();

            Console.WriteLine("Method from DerivedClass");
        }
    }
    

     
     class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            
           
        }
    }
}
