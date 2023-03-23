using System;
using System.Collections.Generic;
using System.Text;

namespace Factory1
{
    class ComputerFactory
    {
        public IComputer Fabrika(string type)
        {
            if(type.Equals("Mac"))
            {
                return new Mac();
            }
            else if(type.Equals("Asus"))
            {
                return new Asus();
            }
            return null;
        }
    }
}
