using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario //abstract = base para criação de outras classes concretas;
    {
        //private int _tipo;

        //0 funcionário;
        //1 diretor;
        //2 designer;
        //n ...

        public static int totalFuncionario { get; private set; }

        public Funcionario(string _cpf, double _salario)
        {
            Salario = _salario;
            Cpf = _cpf;

            //Console.WriteLine("Criando Funcionário: ");
            totalFuncionario++;
        }

        public string Nome { get; set; }    //Propriedades;
        public string Cpf { get; private set; }
        public double Salario { get; protected set; } //Protegendo Propriedade;       
        public abstract double getBonificacao();  //Refatoração;

        public virtual double PremioSemestral()
        {
            return Salario * 1.2;
        }

        public abstract void AumentarSalario(); 
    }
}
