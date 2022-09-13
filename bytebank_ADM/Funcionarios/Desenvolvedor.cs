using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM.Funcionarios
{
    public class Desenvolvedor: Funcionario
    {
        public Desenvolvedor(string _cpf) : base(_cpf, 3000)
        {
           // Console.WriteLine("Criando Desenvolvedor: ");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.15;
        }

        public override double getBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
