using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class Animal
    {
        public string Nome;
        public void comer()
        {
            Console.WriteLine($"O {Nome} está comendo");
        }
    }
}
