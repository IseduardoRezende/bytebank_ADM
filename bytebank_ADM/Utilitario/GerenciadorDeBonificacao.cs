using System;
using System.Collections.Generic;
using System.Text;
using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }        

        public double getBonificacao()
        {
            return this.totalBonificacao;
        }
    }
}
