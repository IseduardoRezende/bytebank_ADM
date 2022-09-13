using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar: Funcionario
    {
        public Auxiliar(string _cpf): base(_cpf, 2000)
        {
            ///Console.WriteLine("Criando Auxiliar: ");
        }
        public override double getBonificacao()
        {
            return Salario * 0.2;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

    }
}
