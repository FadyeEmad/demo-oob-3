using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace demo_oob_3.polymorphism_overriding
{
    internal class typeA
    {
        public int A {  get; set; }

        public typeA(int a)
        {
            A = a;
        }

        public void myfun1()
        {
            Console.WriteLine("i am base [parent]");
        }
        public void myfun2()
        {
            Console.WriteLine($" tyoeA : A = {A}");
        }
    }
}
