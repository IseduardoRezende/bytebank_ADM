using bytebank_ADM.SistemaInternos;
using System;
using System.Collections.Generic;
using System.Text;
                                                     //Aplicando Polimorfismo:

namespace bytebank_ADM.Funcionarios     //virtual = ramificações podem redescrever métodos;
{                                       //override = rescrita do código ativa sobre o método;
    public class Diretor: FuncionarioAutenticado
    {                           //Diretor é um funcionario, por isso está herdando atributos dea Classe Funcionario;
        public override double getBonificacao()  //Polimorfismo de Sobrecarga, mesmo Método porém com parametros diferentes;
        {
            return Salario * 0.5;  // + base.getBonificacao();  base => Acesso a métodos da classe base;
        }

        public override double PremioSemestral()
        {
            return Salario + base.PremioSemestral();
        }
        public Diretor(string _cpf): base(_cpf, 5000) //Base utiza-se para receber propriedades de uma classe mãe em uma classe filho;
        {
            //Console.WriteLine("Criando Diretor: ");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
