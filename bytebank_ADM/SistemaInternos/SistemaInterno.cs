using System;
using System.Collections.Generic;
using System.Text;
using bytebank_ADM.Funcionarios;
using bytebank_ADM.ParceriaComercial;

namespace bytebank_ADM.SistemaInternos
{
    public class SistemaInterno
    {
        public bool Logar(Iautenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
