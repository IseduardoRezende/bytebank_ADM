using bytebank_ADM.SistemaInternos;
using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticado : Funcionario, Iautenticavel
    {
        protected FuncionarioAutenticado(string _cpf, double _salario) : base(_cpf, _salario)
        {
        }
        public string Senha { get; set; }
        public bool Autenticar(string _senha)
        {
            return Senha == _senha;
        }
    }
}
