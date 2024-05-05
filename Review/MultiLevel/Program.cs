// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
namespace One
{
    public delegate void MethodDelegate(int id);
    public delegate void MethodDelegate1(int id);
    class A
    {
        public void Method(int id)
        {
            Console.WriteLine("method 1 "+id);
        }
        public static void Method1(int id)
        {
            Console.WriteLine("method 2 "+ id);
        }
        public int Method2(int id)
        {
            return id;
        }
        public bool Method3(int id)
        {
            if(id>1)
                return true;
            return false;
        }
    }
    class Program
    {
        static void Main3(string[] args)
        {
            A a = new A();
            MethodDelegate methodDelegate = new MethodDelegate(a.Method);
            methodDelegate.Invoke(2);   //delegate

            MethodDelegate methodDelegate1 = A.Method1;
            methodDelegate1(3);
            methodDelegate1 += a.Method;    //multicast delegate
            methodDelegate1(4);

            MethodDelegate methodDelegate2 = delegate(int id)
            {
                Console.WriteLine("Anonymous method " + id);
            };
            methodDelegate2(5);

            MethodDelegate methodDelegate3 = (int id) =>
            {
                Console.WriteLine("Lambda expression " + id);
            };
            methodDelegate3(6);

            Func<int,int> func = a.Method2;
            Console.WriteLine(func.Invoke(2));
            Action<int> action = a.Method;
            action.Invoke(4);
            Predicate<int> predicate = a.Method3;
            predicate(4);
        }
    }
}