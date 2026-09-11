using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class Desenvolvedor : Funcionario
    {
        public override double calcularBonusAnual()
        {
            return 0.12 * salario;
        }
    }
}
