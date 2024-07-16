using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oob_3.binding
{
    public class employee
    {
        public employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public employee()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void getemptype()
        {
            Console.WriteLine("i am employee");
        }
        public void getempdata()
        {
            Console.WriteLine($"employee : id = {Id} , name = {Name} , age = {age}");
        }
    }    
}
 