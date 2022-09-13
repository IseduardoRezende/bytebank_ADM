using System;
using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInternos;
using bytebank_ADM.Utilitario;
using bytebank_ADM.ParceriaComercial;

namespace bytebank_ADM
{
    class Program
    {        
        static void Main(string[] args)     
        {
            Console.WriteLine("Boas Vindas, ao ByteBank Administração.\n");

            Console.WriteLine("Bonificação dos Funcionários: \n");

            CalcularBonificacao();

            Console.WriteLine("=====================");

            Console.WriteLine("Acesso ao ADM: ");

            UsarSistema();
          
            void CalcularBonificacao()
            {
                GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

                Designer designer = new Designer("21342342");
                designer.Nome = "Juca";

                Diretor diretor = new Diretor("21324214");
                diretor.Nome = "Lívia";

                Auxiliar auxiliar = new Auxiliar("2132312");
                auxiliar.Nome = "Jorge";

                GerenteDeContas gerente = new GerenteDeContas("23214214");
                gerente.Nome = "Leclear";

                Desenvolvedor desenvolvedor = new Desenvolvedor("2132243553");
                desenvolvedor.Nome = "Eduardo";

                gerenciador.Registrar(designer);
                gerenciador.Registrar(gerente);
                gerenciador.Registrar(auxiliar);
                gerenciador.Registrar(gerente);
                gerenciador.Registrar(desenvolvedor);

                Console.WriteLine("Total de Funcionários: " + Funcionario.totalFuncionario);
                Console.WriteLine("Total de Bonificações: " + gerenciador.getBonificacao() + "R$");
            }

            void UsarSistema()
            {
                SistemaInterno sistemaInterno = new SistemaInterno();

                Diretor diretor1 = new Diretor("159.753.398-04");
                diretor1.Nome = "Emilia";
                diretor1.Senha = "123";

                GerenteDeContas gerente1 = new GerenteDeContas("326.985.628-89");
                gerente1.Nome = "Eduardo";
                gerente1.Senha = "321";

                ParceiroComercial parceiroComercial = new ParceiroComercial();
                parceiroComercial.Senha = "789";
                
                sistemaInterno.Logar(diretor1, "123");
                sistemaInterno.Logar(gerente1, gerente1.Senha);
                sistemaInterno.Logar(parceiroComercial, "345");
            }

            Console.ReadKey();
        }
    }
}
