using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oob_3.binding
{
    public class parttimeemployee : employee
    {
        public int countofhours {  get; set; }
        public int hoursrate { get; set; }

        public new void getemptype()
        {
            Console.WriteLine("i am employee");
        }
        public new void getempdata()
        {
            Console.WriteLine($"employee : id = {Id} , name = {Name} , age = {age} , countofhours {countofhours} , hoursrate = {hoursrate} ");
        }
    }
}
