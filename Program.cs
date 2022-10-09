using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.add(121,"Ashwin", 75.7);
            Console.WriteLine(s1.Print());
        }
    }
}
