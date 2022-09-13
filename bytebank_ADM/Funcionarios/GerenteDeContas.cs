using bytebank_ADM.SistemaInternos;
using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas: FuncionarioAutenticado
    {
        public GerenteDeContas(string _cpf): base(_cpf, 4000)
        {
           // Console.WriteLine("Criando Gerente de Contas: ");
        }
        public override double getBonificacao()
        {
            return Salario * 0.25;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}
