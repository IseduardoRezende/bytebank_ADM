using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM.Funcionarios
{
    public class Arquiteto : PrestadorDeServicos
    {
        public string Senha { get; set; }

        public bool Autenticar(string _senha)
        {
            return Senha == _senha;
        }
    }
}
