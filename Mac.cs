using System;
using System.Collections.Generic;
using System.Text;

namespace Factory1
{
    class Mac : IComputer
    {
        public void name()
        {
            Console.WriteLine("Bilgisayarın markası mac");
        }

        public void since(int year)
        {
            Console.WriteLine(year + " senesinde alınmış");
        }
    }
}
