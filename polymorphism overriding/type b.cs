using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oob_3.polymorphism_overriding
{
    internal class type_b: typeA
    {
        public int B {  get; set; }

        public type_b(int b , int a) : base(a)
        {
           B = b;
        }
    }
}
