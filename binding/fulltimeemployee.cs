using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace demo_oob_3.binding
{
    public class fulltimeemployee : employee
    {
        public decimal salary { get; set; }
    }
    public new void getemptype()
    {
        Console.WriteLine("i am fulltimeemployee");
    }
    public override void getempdata()
    {
        Console.WriteLine($"fulltimeemployee : id = {Id} , name = {Name} , age = {age}");
    }
}
