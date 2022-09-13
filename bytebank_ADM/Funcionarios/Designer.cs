using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM.Funcionarios
{
    public class Designer: Funcionario
    {
        public Designer(string _cpf): base(_cpf, 3000)
        {
            //Console.WriteLine("Criando Designer: ");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
        public override double getBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
