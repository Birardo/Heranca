using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class Gerente : Funcionario
    {
        public override double calcularBonusAnual()
        {
            return (0.15 * salario) +1000;
        }
    }
}
