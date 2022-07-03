// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace third_LAB

{
    internal class main
    {

        static void Main(String[] args)
        {
            circle c1 = new circle();
            c1.Radius = 5;
            Console.WriteLine(c1.Area());
            rectangle r1 = new rectangle();
            r1.width = 2;
            r1.length = 2;


            Console.WriteLine(r1.perimeter());


        }


    }
}
