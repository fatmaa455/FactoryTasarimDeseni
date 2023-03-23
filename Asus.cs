using System;
using System.Collections.Generic;
using System.Text;

namespace Factory1
{
    class Asus : IComputer
    {
        public void name()
        {
            Console.WriteLine("Bilgisayarın markası asus");
        }

        public void since(int year)
        {
            Console.WriteLine(year + " senesinde alınmış");
        }
    }
}
