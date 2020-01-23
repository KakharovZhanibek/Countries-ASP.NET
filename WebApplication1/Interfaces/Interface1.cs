using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFormsEmpty.Interfaces
{
    public interface ITest<T>
    {
        void do1(T t1, T t2);
    }

    class Test1 : ITest<string>
    {
        public void do1(string t1, string t2)
        {
            Console.WriteLine(t1 + " " + t2);
        }
    }
    class Test2 : ITest<int>
    {
        public void do1(int t1, int t2)
        {
            Console.WriteLine(t1 + t2);
        }
    }

    class Test3 : ITest<decimal>
    {
        public void do1(decimal t1, decimal t2)
        {
            Console.WriteLine(t1 + t2);
        }
    }
}
