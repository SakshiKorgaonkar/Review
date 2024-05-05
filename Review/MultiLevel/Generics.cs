using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel
{
    public class Pairs<T>
    {
        private T data;
        private T data1;

        public Pairs()
        {
            this.data1 = default;
            this.data = default;
        }
        public Pairs(T data, T data1)
        {
            this.data = data;
            this.data1 = data1;
        }
        public T getData() { return data; }
        public T getData1() { return data1; }
    }
    internal class Generics
    {
        static void Main(string[] args)
        {
            Pairs<int> pairs = new Pairs<int>();
            Console.WriteLine(pairs.getData());
            Console.WriteLine(pairs.getData1());

            Pairs<int> pairs1 = new Pairs<int>(2, 3);
            Console.WriteLine(pairs1.getData());
            Console.WriteLine(pairs1.getData1());
        }
    }
}
