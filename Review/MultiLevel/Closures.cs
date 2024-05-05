using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel
{
    class E
    {
        public Func<int> Method()
        {
            int outerVariable = 1;
            Func<int> InnerMethod = () =>
            {
                int innerVariable = 10;
                outerVariable += 5;
                return outerVariable + innerVariable;
            };
            return InnerMethod;
        }
    }
    internal class Closures
    {   
        static void Main1(string[] args)
        {
            E e = new E();
            Func<int> Method1=e.Method();
            Console.WriteLine(Method1());
            Console.WriteLine(Method1());
        }
    }
}
