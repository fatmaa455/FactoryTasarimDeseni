using System;

namespace Factory1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factory ornek

            ComputerFactory factory = new ComputerFactory();

            IComputer computer = factory.Fabrika("Mac");
            computer.name();
            computer.since(2020);

            IComputer computer2 = factory.Fabrika("Asus");
            computer2.name();
            computer2.since(2000);
        }
    }
}
