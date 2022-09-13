using bytebank_ADM.SistemaInternos;
using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM.Funcionarios
{
    public abstract class PrestadorDeServicos: IBonificavel
    {
        public string Cnpj { get; set; }

        public double GetBonificacao()
        {
            return 1000;
        }
    }
}
