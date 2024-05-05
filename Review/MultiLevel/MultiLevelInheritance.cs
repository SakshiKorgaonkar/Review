using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel
{
    class B
    {
        public virtual void Method1()
        {
            Console.WriteLine("B method");
        }
    }
    class C : B
    {
        public override void Method1() 
        {
            Console.WriteLine("C method"); 
            base.Method1();
        }
    }
    class D : C
    {
        public override void Method1()
        {
            Console.WriteLine("D method");
            base.Method1();
        }
    }
    internal class MultiInheritance
    {
        static void Main2(string[] args)
        {
            B b = new B();
            b.Method1();
            B b2 = new C();
            b2.Method1();
            B b3= new D();
            b3.Method1();
        }
    }
}
